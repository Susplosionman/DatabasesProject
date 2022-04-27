using DataAccess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DataDelegates
{
    public class DeleteReviewDataDelegate : DataDelegate
    {
        public int ReviewID { get; set; }
        public DeleteReviewDataDelegate(int id) : base("Movie.DeleteReview")
        {
            ReviewID = id;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("ReviewID", ReviewID);
        }
    }
}
