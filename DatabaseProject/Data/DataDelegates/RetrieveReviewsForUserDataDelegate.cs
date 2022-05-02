using DataAccess;
using Data.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Data.DataDelegates
{
    internal class RetrieveReviewsForUserDataDelegate : DataReaderDelegate<List<List<string>>>
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

        public override List<List<string>> Translate(SqlCommand command, IDataRowReader reader)
        {
            var reviews = new List<List<string>>();


            
            while (reader.Read())
            {
                reviews.Add(new List<string> { reader.GetString("MovieName"), reader.GetString("DirectorName"), reader.GetInt32("Rating").ToString(), reader.GetString("Comment"), reader.GetInt32("ReviewID").ToString() });
            }

            return reviews;
        }
    }
}