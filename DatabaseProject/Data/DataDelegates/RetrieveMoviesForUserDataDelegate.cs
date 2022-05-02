using DataAccess;
using Data.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Data.DataDelegates
{
    internal class RetrieveMoviesForUserDataDelegate : DataReaderDelegate<List<List<string>>>
    {
        public int UserID { get; set; }
        public RetrieveMoviesForUserDataDelegate(int id)
           : base("Movie.RetrieveMoviesForUser")
        {
            UserID = id;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("UserID", UserID);

        }

        public override List<List<string>> Translate(SqlCommand command, IDataRowReader reader)
        {
            var movies = new List<List<string>>();

            while (reader.Read())
            {
                movies.Add(new List<string>() { reader.GetString("Name"), reader.GetString("Genre"), reader.GetDateTimeOffset("ReleaseDate").ToString() });
                   
            }

            return movies;
        }
    }
}