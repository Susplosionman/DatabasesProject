using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Showing
    {
        public int ShowingID { get; set; }
        public DateTimeOffset ShowTime { get; set; }
        public int TicketPrice { get; set; }
        public int MovieID { get; set; }

        public Showing(int showingID, DateTimeOffset time, int price, int movieID)
        {
            ShowingID = showingID;
            ShowTime = time;
            TicketPrice = price;
            MovieID = movieID;

        }
        public override string ToString()
        {
            return ShowTime.ToString();
        }
    }
}
