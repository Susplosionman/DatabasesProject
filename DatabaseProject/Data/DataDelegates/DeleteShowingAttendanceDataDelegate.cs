using DataAccess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DataDelegates
{
    public class DeleteShowingAttendanceDataDelegate : DataDelegate
    {
        public int ShowingID { get; set; }
        public DeleteShowingAttendanceDataDelegate(int id) : base("Movie.DeleteShowingAttendance")
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