using DataAccess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DataDelegates
{
    public class UpdateShowingDataDelegate : DataDelegate
    {
        public int ShowingID { get; set; }
        DateTimeOffset ShowTime { get; set; }
        int Price { get; set; }
        int MovieID { get; set; }
        public UpdateShowingDataDelegate(int sid, DateTimeOffset time, int price, int mID) : base("Movie.UpdateShowing")
        {
            ShowingID = sid;
            ShowTime = time;
            Price = price;
            MovieID = mID;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("ShowingID", ShowingID);
            command.Parameters.AddWithValue("ShowTime", ShowTime);
            command.Parameters.AddWithValue("TicketPrice", Price);
            command.Parameters.AddWithValue("MovieID", MovieID);
        }
    }
}
