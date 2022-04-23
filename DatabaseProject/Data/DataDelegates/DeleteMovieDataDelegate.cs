using DataAccess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DataDelegates
{
    public class DeleteMovieDataDelegate : DataDelegate
    {
        public int MovieID { get; set; }
        public DeleteMovieDataDelegate(int id) : base("Movie.DeleteMovie")
        {
            MovieID = id;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("MovieID", MovieID);
        }
    }
}
