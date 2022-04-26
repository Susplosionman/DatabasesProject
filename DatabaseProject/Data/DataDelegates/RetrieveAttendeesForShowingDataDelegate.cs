using DataAccess;
using Data.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Data.DataDelegates
{
    internal class RetrieveAttendeesForShowingDataDelegate : DataReaderDelegate<IReadOnlyList<ShowingAttendance>>
    {
        public int ShowingID { get; set; }
        public RetrieveAttendeesForShowingDataDelegate(int id)
           : base("Movie.RetrieveAttendeesForShowing")
        {
            ShowingID = id;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("ShowingID", ShowingID);

        }

        public override IReadOnlyList<ShowingAttendance> Translate(SqlCommand command, IDataRowReader reader)
        {
            var showings = new List<ShowingAttendance>();

            while (reader.Read())
            {
                showings.Add(new ShowingAttendance(
                   reader.GetInt32("UserID"),
                   ShowingID));
            }

            return showings;
        }
    }
}