using DataAccess;
using Data.Models;
using System.Collections.Generic;
using System.Data.SqlClient;
using System;
using System.Text;

namespace Data.DataDelegates
{
    internal class RetrieveUserStatisticsDataDelegate : DataReaderDelegate<Dictionary<string, List<string>>>
    {
        public int Highest { get; set; }
        public RetrieveUserStatisticsDataDelegate(int highest)
           : base("Movie.RetrieveUserActivity")
        {
            Highest = highest;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("HighestRank", Highest);

        }

        public override Dictionary<string, List<string>> Translate(SqlCommand command, IDataRowReader reader)
        {
            var activityDict = new Dictionary<string, List<string>>();

            while (reader.Read())
            {
                activityDict.Add(
                   reader.GetString("Username"),
                   new List<string> { reader.GetInt32("MoviesAttended").ToString(), reader.GetInt32("ReviewCount").ToString(), reader.GetInt64("Rank").ToString() });
            }

            return activityDict;
        }
    }
}