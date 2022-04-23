using DataAccess;
using Data.Models;
using System.Data;
using System.Data.SqlClient;

namespace Data.DataDelegates
{
    internal class FetchSpecificShowingDataDelegate : DataReaderDelegate<Showing>
    {
        private string MovieName;

        public FetchSpecificShowingDataDelegate(string movieName) : base("Movie.FetchSpecificShowing")
        {
            MovieName = movieName;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("MovieName", MovieName);
        }

        public override Showing Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
            {
                return new Showing(-1, System.DateTimeOffset.MinValue, -1, -1);
            }
            else
            {
                return new Showing(reader.GetInt32("ShowingID"), reader.GetDateTimeOffset("ShowTime"), reader.GetInt32("TicketPrice"), reader.GetInt32("MovieID"));
            }



        }
    }
}
