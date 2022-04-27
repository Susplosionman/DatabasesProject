using DataAccess;
using Data.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Data.DataDelegates
{
    internal class MovieTotalGrossDataDelegate : DataReaderDelegate<Dictionary<string,List<string>>>
    {
      
        public MovieTotalGrossDataDelegate()
           : base("Movie.MovieTotalGross")
        {
           
        }
        /*
        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("UserID", UserID);

        }*/

        public override Dictionary<string, List<string>> Translate(SqlCommand command, IDataRowReader reader)
        {
            var salesDict = new Dictionary<string, List<string>>();

            while (reader.Read())
            {
                salesDict.Add(
                   reader.GetString("Name"),
                   new List<string> {reader.GetString("Genre"), reader.GetDateTimeOffset("ReleaseDate").ToString(), reader.GetString("Name"), reader.GetInt32("GrossSales").ToString() });
            }

            return salesDict;
        }
    }
}