using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Review
    {
        public int ReviewID { get; set; }
        public int UserID { get; set; }
        public decimal Rating { get; set; }
        public string Comment { get; set; }
        public int MovieID { get; set; }

        public Review(int reviewID, int userID, decimal rating, string comment, int movieID)
        {
            ReviewID = reviewID;
            UserID = userID;
            Rating = rating;
            Comment = comment;
            MovieID = movieID;
        }
    }
}
