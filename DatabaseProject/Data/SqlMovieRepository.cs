using Data.DataDelegates;
using Data.Models;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class SqlMovieRepository
    {
        private SqlCommandExecutor executor;

        public SqlMovieRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public Movie CreateMovie(string name, DateTimeOffset release, string genre, int directorID)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(name));

            if (string.IsNullOrWhiteSpace(genre))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(genre));

            var d = new CreateMovieDataDelegate(name, release, genre, directorID);
            return executor.ExecuteNonQuery(d);
        }
        public Director CreateDirector(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(name));

            var d = new CreateDirectorDataDelegate(name);
            return executor.ExecuteNonQuery(d);
        }
    }
}
