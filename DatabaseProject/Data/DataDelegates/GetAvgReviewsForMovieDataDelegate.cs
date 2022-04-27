using DataAccess;
using Data.Models;
using System.Data;
using System.Data.SqlClient;

namespace Data.DataDelegates
{
    internal class GetAvgReviewsForMovieDataDelegate : DataReaderDelegate<Review>
    {
        private int MovieID { get; set; }

        public GetAvgReviewsForMovieDataDelegate(int id) : base("Movie.GetAvgReviewForMovie")
        {
            MovieID = id;
        }
        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("MovieID", MovieID);
        }

        public override Review Translate(SqlCommand command, IDataRowReader reader)
        {
            if (reader.Read())
            {
                return new Review(-1, -1, reader.GetDecimal("AvgRatingForMovie"), "No comment", -1);
            }
            return null;
        }
    }
}
