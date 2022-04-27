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
            for (int i = 0; i < showings.Count; i++)
            {
                Showings.Add(showings[i]);

            }
            uxShowingBox.DataSource = Showings;
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
            smr.CreateShowingAttendance(CurUser.UserID, s.ShowingID);
        }
    }
}
