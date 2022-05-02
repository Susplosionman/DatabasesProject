using DataAccess;
using Data.Models;
using System.Collections.Generic;
using System.Data.SqlClient;
using System;
using System.Text;

namespace Data.DataDelegates
{
    internal class MovieTotalGrossDataDelegate : DataReaderDelegate<List<List<string>>>
    {
        public int Highest { get; set; }
        public MovieTotalGrossDataDelegate(int highest)
           : base("Movie.MovieTotalGross")
        {
           Highest = highest;
        }
        
        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("HighestRank", Highest);

        }

        public override List<List<string>> Translate(SqlCommand command, IDataRowReader reader)
        {
            var salesDict = new List<List<string>>();

            while (reader.Read())
            {
                DateTimeOffset time = reader.GetDateTimeOffset("ReleaseDate");
                StringBuilder s = new StringBuilder();

               
                s.Append(time.Month.ToString() + "/" + time.Day.ToString() + "/" + time.Year.ToString());
                
                salesDict.Add(
                   
                   new List<string> {reader.GetString("Name"), reader.GetString("Genre"), s.ToString(), reader.GetString("DirectorName"), "$" + reader.GetInt32("GrossSales").ToString(), reader.GetInt64("MovieRank").ToString()});
            }

            return salesDict;
        }
    }
}