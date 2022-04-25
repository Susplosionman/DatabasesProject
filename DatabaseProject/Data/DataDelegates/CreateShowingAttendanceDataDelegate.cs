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
    public class CreateShowingAttendanceDataDelegate : NonQueryDataDelegate<ShowingAttendance>
    {
        public int ShowingID { get; set; }
        public int UserID { get; set; }

        public CreateShowingAttendanceDataDelegate(int uID, int sID) : base("Movie.CreateShowingAttendance")
        {
            UserID = uID;
            ShowingID = sID;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("UserID", UserID);
            command.Parameters.AddWithValue("ShowingID", ShowingID);

        }


        public override ShowingAttendance Translate(SqlCommand command)
        {
            return new ShowingAttendance(UserID, ShowingID);
        }
    }
}
