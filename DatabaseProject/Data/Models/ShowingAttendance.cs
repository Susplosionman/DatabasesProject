using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class ShowingAttendance
    {
        public int ShowingID { get; set; }
        public int UserID { get; set; }

        public ShowingAttendance(int uID, int sID)
        {
            UserID = uID;
            ShowingID = sID;
        }
    }
}
