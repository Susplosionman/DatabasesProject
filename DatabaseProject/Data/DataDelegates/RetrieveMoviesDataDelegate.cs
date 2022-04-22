using DataAccess;
using Data.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Data.DataDelegates
{
    internal class RetrieveMoviesDataDelegate : DataReaderDelegate<IReadOnlyList<Movie>>
    {
        public RetrieveMoviesDataDelegate()
           : base("Movie.RetrieveMovies")
        {
        }

        public override IReadOnlyList<Movie> Translate(SqlCommand command, IDataRowReader reader)
        {
            var movies = new List<Movie>();

            while (reader.Read())
            {
                movies.Add(new Movie(
                   reader.GetInt32("MovieID"),
                   reader.GetString("Name"),
                   reader.GetDateTimeOffset("ReleaseDate"),
                   reader.GetString("Genre"),
                   reader.GetInt32("DirectorID")));
            }

            return movies;
        }
    }
}