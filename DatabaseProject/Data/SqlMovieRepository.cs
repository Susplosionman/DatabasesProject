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
        public Review CreateReview(int uID, int rating, string comment, int mID)
        {
            var d = new CreateReviewDataDelegate(uID, rating, comment, mID);
            return executor.ExecuteNonQuery(d);
        }
        public User CreateUser(string type, string username, string pw)
        {
            var d = new CreateUserDataDelegate(type, username, pw);
            return executor.ExecuteNonQuery(d);
        }
        public ShowingAttendance CreateShowingAttendance(int uID, int sID)
        {
            var d = new CreateShowingAttendanceDataDelegate(uID,sID);
            return executor.ExecuteNonQuery(d);
        }
        public IReadOnlyList<Movie> RetrieveMovies()
        {
            return executor.ExecuteReader(new RetrieveMoviesDataDelegate());
        }
        public IReadOnlyList<User> RetrieveAllUsers()
        {
            return executor.ExecuteReader(new RetrieveAllUsersDataDelegate());
        }
        public IReadOnlyList<ShowingAttendance> RetrieveAttendeesForShowing(int id)
        {
            return executor.ExecuteReader(new RetrieveAttendeesForShowingDataDelegate(id));
        }
        public void DeleteMovie(int id)
        {
            executor.ExecuteNonQuery(new DeleteMovieDataDelegate(id));

        }
        public void DeleteReview(int id)
        {
            executor.ExecuteNonQuery(new DeleteReviewDataDelegate(id));

        }
        public void DeleteShowingAttendance(int id)
        {
            executor.ExecuteNonQuery(new DeleteShowingAttendanceDataDelegate(id));

        }

        public Director FetchDirector(string name)
        {
            var d = new FetchDirectorDataDelegate(name);
            return executor.ExecuteReader(d);
        }
        public Director FetchDirectorByID(int id)
        {
            var d = new FetchDirectorByIDDataDelegate(id);
            return executor.ExecuteReader(d);
        }
        public IReadOnlyList<Showing> RetrieveShowingsForMovie(int id)
        {
            return executor.ExecuteReader(new RetrieveShowingsForMovieDataDelegate(id));
        }
        public IReadOnlyList<Movie> RetrieveMoviesForUser(int id)
        {
            return executor.ExecuteReader(new RetrieveMoviesForUserDataDelegate(id));
        }
        public IReadOnlyList<Review> RetrieveReviewsForUser(int id)
        {
            return executor.ExecuteReader(new RetrieveReviewsForUserDataDelegate(id));
        }
        public Review GetAvgReviewsForMovie(int id)
        {
            return executor.ExecuteReader(new GetAvgReviewsForMovieDataDelegate(id));
        }

        public Showing CreateShowing(DateTimeOffset time, int price, int movieID)
        {
            var d = new CreateShowingDataDelegate(time, price, movieID);
            return executor.ExecuteNonQuery(d);
        }
        public void DeleteShowing(int id)
        {
            executor.ExecuteNonQuery(new DeleteShowingDataDelegate(id));

        }

        
    }
}