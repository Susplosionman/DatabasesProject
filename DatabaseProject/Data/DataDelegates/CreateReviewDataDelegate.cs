using Data.Models;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DataDelegates
{
    public class CreateReviewDataDelegate : NonQueryDataDelegate<Review>
    {
        
        public int UserID { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        public int MovieID { get; set; }

        public CreateReviewDataDelegate(int userID, int rating, string comment, int movieID) : base("Movie.CreateReview")
        {
           
            UserID = userID;
            Rating = rating;
            Comment = comment;
            MovieID = movieID;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("UserID", UserID);
            command.Parameters.AddWithValue("Rating", Rating);
            command.Parameters.AddWithValue("Comment", Comment);
            command.Parameters.AddWithValue("MovieID", MovieID);

            var p = command.Parameters.Add("ReviewID", System.Data.SqlDbType.Int);
            p.Direction = System.Data.ParameterDirection.Output;
        }


        public override Review Translate(SqlCommand command)
        {
            return new Review((int)command.Parameters["ReviewID"].Value, UserID, Rating, Comment, MovieID);
        }
    }
}
