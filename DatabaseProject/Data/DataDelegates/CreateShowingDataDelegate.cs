using Data.Models;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DataDelegates
{
    public class CreateShowingDataDelegate : NonQueryDataDelegate<Showing>
    {
        public DateTimeOffset ShowTime { get; set; }
        public int TicketPrice { get; set; }
        public int MovieID { get; set; }

        public CreateShowingDataDelegate(DateTimeOffset time, int price, int movieID) : base("Movie.CreateShowing")
        {
            ShowTime = time;
            TicketPrice = price;
            MovieID = movieID;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("ShowTime", ShowTime);
            command.Parameters.AddWithValue("TicketPrice", TicketPrice);
            command.Parameters.AddWithValue("MovieID", MovieID);
            

            var p = command.Parameters.Add("ShowingID", System.Data.SqlDbType.Int);
            p.Direction = System.Data.ParameterDirection.Output;
        }


        public override Showing Translate(SqlCommand command)
        {
            return new Showing((int)command.Parameters["ShowingID"].Value,ShowTime, TicketPrice, MovieID);
        }
    }
}
