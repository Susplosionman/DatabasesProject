using Data;
using Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontEnd
{
    public partial class BuyTicketControl : UserControl
    {
        public SqlMovieRepository smr = new SqlMovieRepository(@"Server=(localdb)\MSSQLLocalDb;Database=CIS560;Integrated Security=SSPI;");
        Movie CurMovie { get; set; }
        User CurUser { get; set; }
        BindingList<Showing> Showings { get; set; } = new BindingList<Showing>();
        public BuyTicketControl(Movie m, User u) 
        {
            InitializeComponent();
            CurUser = u;
            CurMovie = m;

            List<Showing> showings = (List<Showing>)smr.RetrieveShowingsForMovie(CurMovie.MovieID);
            
            
            for (int j = 0; j < showings.Count; j++)
            {
                if (showings[j].ShowTime >= DateTimeOffset.Now)
                {
                    Showings.Add(showings[j]);
                }
            }

 

            uxShowingBox.DataSource = Showings;
            uxBuyTicketButton.Enabled = false;
            if (Showings.Count > 0)
            {
                uxBuyTicketButton.Enabled = true;
            }
            
        }

        private void uxBackButton_Click(object sender, EventArgs e)
        {
            if (this.FindForm() is UserInterface ui)
            {
                CustomerView mic = new CustomerView(CurUser);
                ui.Controls.Remove(this);
                ui.Controls.Add(mic);
                ui.Size = new Size(mic.Width + 50, mic.Height + 50);
            }
        }

        private void uxBuyTicketButton_Click(object sender, EventArgs e)
        {
            
            Showing s = uxShowingBox.SelectedItem as Showing;

            List<ShowingAttendance> attendees = (List<ShowingAttendance>)smr.RetrieveAttendeesForShowing(s.ShowingID);
            
            
            if (!UserAlreadyAttendingShowing(attendees))
            {
                smr.CreateShowingAttendance(CurUser.UserID, s.ShowingID);
                uxBuyTicketButton.Enabled = false;
            }
            else
            {
                uxBuyTicketButton.Enabled = false;
                label1.Text = "Failed. Not allowed to buy more tickets for this showing.";
            }
            
        }

        private void uxShowingBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(uxShowingBox.SelectedIndex < 0 || uxShowingBox.SelectedIndex > Showings.Count-1)
            {
                uxBuyTicketButton.Enabled = false;
            }
            else
            {
                uxBuyTicketButton.Enabled = true;
            }
        }
        private bool UserAlreadyAttendingShowing(List<ShowingAttendance> sa)
        {
            for (int i = 0; i < sa.Count; i++)
            {
                if (sa[i].UserID == CurUser.UserID)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
