using DataAccess;
using Data.Models;
using System.Collections.Generic;
using System.Data.SqlClient;
using System;

namespace Data.DataDelegates
{
    internal class RetrieveRecentShowingStatsDataDelegate : DataReaderDelegate<Dictionary<string, List<string>>>
    {
        DateTimeOffset From { get; set; }
        DateTimeOffset To { get; set; }
        public RetrieveRecentShowingStatsDataDelegate(DateTimeOffset from, DateTimeOffset to)
           : base("Movie.RetrieveRecentShowingStats")
        {
            From = from;
            To = to;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("FirstDate", From);
            command.Parameters.AddWithValue("LastDate", To);

        }

        public override Dictionary<string, List<string>> Translate(SqlCommand command, IDataRowReader reader)
        {
            var stats = new Dictionary<string, List<string>>();

            while (reader.Read())
            {
                stats.Add(reader.GetDateTimeOffset("ShowTime").ToString(), new List<string> {reader.GetString("MovieName"), reader.GetInt32("TicketSales").ToString(), String.Format("{0:0.00}", reader.GetDecimal("AverageReview")) });
            }

            return stats;
        }
    }
}