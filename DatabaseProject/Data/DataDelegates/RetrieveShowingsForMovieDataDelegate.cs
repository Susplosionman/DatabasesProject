using DataAccess;
using Data.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Data.DataDelegates
{
    internal class RetrieveShowingsForMovieDataDelegate : DataReaderDelegate<IReadOnlyList<Showing>>
    {
        public int MovieID { get; set; }
        public RetrieveShowingsForMovieDataDelegate(int id)
           : base("Movie.RetrieveShowingsForMovie")
        {
            MovieID = id;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("MovieID", MovieID);

        }

        public override IReadOnlyList<Showing> Translate(SqlCommand command, IDataRowReader reader)
        {
            var showings = new List<Showing>();

            while (reader.Read())
            {
                showings.Add(new Showing(
                   reader.GetInt32("ShowingID"),
                   reader.GetDateTimeOffset("ShowTime"),
                   reader.GetInt32("TicketPrice"),
                   MovieID));
            }

            return showings;
        }
    }
}