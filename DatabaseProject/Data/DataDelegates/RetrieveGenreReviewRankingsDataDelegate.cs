using DataAccess;
using Data.Models;
using System.Collections.Generic;
using System.Data.SqlClient;
using System;

namespace Data.DataDelegates
{
    internal class RetrieveGenreReviewRankingsDataDelegate : DataReaderDelegate<Dictionary<string, List<string>>>
    {
        string Genre { get; set; }
        public RetrieveGenreReviewRankingsDataDelegate(string genre)
           : base("Movie.GenreReviewRankings")
        {
            Genre = genre;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("Genre", Genre);
        }

        public override Dictionary<string, List<string>> Translate(SqlCommand command, IDataRowReader reader)
        {
            var stats = new Dictionary<string, List<string>>();

            while (reader.Read())
            {
                stats.Add(reader.GetString("Name").ToString(), new List<string> { String.Format("{0:0.00}", reader.GetDecimal("AvgRating")), reader.GetInt64("Rank").ToString() });
            }

            return stats;
        }
    }
}