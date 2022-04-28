﻿using DataAccess;
using Data.Models;
using System.Collections.Generic;
using System.Data.SqlClient;
using System;
using System.Text;

namespace Data.DataDelegates
{
    internal class MovieTotalGrossDataDelegate : DataReaderDelegate<Dictionary<string,List<string>>>
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

        public override Dictionary<string, List<string>> Translate(SqlCommand command, IDataRowReader reader)
        {
            var salesDict = new Dictionary<string, List<string>>();

            while (reader.Read())
            {
                DateTimeOffset time = reader.GetDateTimeOffset("ReleaseDate");
                StringBuilder s = new StringBuilder();

               
                s.Append(time.Month.ToString() + "/" + time.Day.ToString() + "/" + time.Year.ToString());
                
                salesDict.Add(
                   reader.GetString("Name"),
                   new List<string> {reader.GetString("Genre"), s.ToString(), reader.GetString("Name"), "$" + reader.GetInt32("GrossSales").ToString(), reader.GetInt64("MovieRank").ToString()});
            }

            return salesDict;
        }
    }
}