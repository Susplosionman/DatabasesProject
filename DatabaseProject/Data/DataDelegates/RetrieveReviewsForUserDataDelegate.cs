using DataAccess;
using Data.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Data.DataDelegates
{
    internal class RetrieveReviewsForUserDataDelegate : DataReaderDelegate<IReadOnlyList<Review>>
    {
        public int UserID { get; set; }
        public RetrieveReviewsForUserDataDelegate(int id)
           : base("Movie.RetrieveReviewsForUser")
        {
            UserID = id;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("UserID", UserID);

        }

        public override IReadOnlyList<Review> Translate(SqlCommand command, IDataRowReader reader)
        {
            var reviews = new List<Review>();

            while (reader.Read())
            {
                reviews.Add(new Review(
                   reader.GetInt32("ReviewID"),
                   UserID,
                   reader.GetDecimal("Rating"),
                   reader.GetString("Comment"),
                   reader.GetInt32("MovieID")));
            }

            return reviews;
        }
    }
}