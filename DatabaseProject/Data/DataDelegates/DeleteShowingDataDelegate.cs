using DataAccess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DataDelegates
{
    public class DeleteShowingDataDelegate : DataDelegate
    {
        public int ShowingID { get; set; }
        public DeleteShowingDataDelegate(int id) : base("Movie.DeleteShowing")
        {
            ShowingID = id;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("ShowingID", ShowingID);
        }
    }
}
