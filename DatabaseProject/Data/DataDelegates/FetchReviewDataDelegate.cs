using DataAccess;
using Data.Models;
using System.Data;
using System.Data.SqlClient;

namespace Data.DataDelegates
{
    internal class FetchReviewDataDelegate : DataReaderDelegate<Review>
    {
        private string MovieName;

        public FetchReviewDataDelegate(string movieName): base("Movie.FetchReview")
        {
            MovieName = movieName;
        }
        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("MovieName", MovieName);
        }

        public override Review Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
            {
                return new Review(-1, -1, -1, "Not Found", -1);
            }
            else
            {
                return new Review(reader.GetInt32("ReviewID"), reader.GetInt32("UserID"), reader.GetDecimal("Rating"), reader.GetString("Comment"), reader.GetInt32("MovieID"));
            }
        }
    }
}
