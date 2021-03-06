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
    public partial class MovieInfoControl : UserControl
    {
        public SqlMovieRepository smr = new SqlMovieRepository(@"Server=(localdb)\MSSQLLocalDb;Database=CIS560;Integrated Security=SSPI;");
        Movie CurMovie { get; set; }
        User CurUser { get; set; }
        public MovieInfoControl(Movie movie, User u)
        {
            InitializeComponent();
            CurUser = u;
            CurMovie = movie;
            Director d = smr.FetchDirectorByID(movie.DirectorID);
            
            List<Showing> showings = (List<Showing>)smr.RetrieveShowingsForMovie(CurMovie.MovieID);
            List<Showing> futureShowings = new List<Showing>();
            for (int i = 0; i < showings.Count; i++)
            {
                if (showings[i].ShowTime >= DateTimeOffset.Now)
                {
                    futureShowings.Add(showings[i]);
                }
            }
            uxShowingBox.DataSource = futureShowings;

            uxMovieLabel.Text = CurMovie.Name;
            uxDirectorLabel.Text = d.Name;
            
            //List<Actor> actors = (List<Actor>)smr.GetActorsForMovie(CurMovie.MovieID);
            //uxActorsLabel1.Text = actors[0];
            //uxActorsLabel2.Text = actors[1];
            //uxActorsLabel3.Text = actors[2];
            uxRatingLabel.Text = String.Format("{0:0.00}", smr.GetAvgReviewsForMovie(CurMovie.MovieID).Rating);
        }

        private void uxBackButton_Click(object sender, EventArgs e)
        {
            if (this.FindForm() is UserInterface ui)
            {
                ui.Controls.Remove(this);
                ui.Controls.Add(new CustomerView(CurUser));
                ui.Size = new Size(ui._customerView.Width + 50, ui._customerView.Height + 50);
            }
        }

        private void uxLeaveReviewButton_Click(object sender, EventArgs e)
        {
            if (this.FindForm() is UserInterface ui)
            {
                LeaveReviewControl lrc = new LeaveReviewControl(CurMovie, CurUser);
                ui.Controls.Remove(this);
                ui.Controls.Add(lrc);
                ui.Size = new Size(lrc.Width + 50, lrc.Height + 50);
            }
        }

        private void uxBuyTicketButton_Click(object sender, EventArgs e)
        {
            if (this.FindForm() is UserInterface ui)
            {
                BuyTicketControl btc = new BuyTicketControl(CurMovie, CurUser);
                ui.Controls.Remove(this);
                ui.Controls.Add(btc);
                ui.Size = new Size(btc.Width + 50, btc.Height + 50);
            }
        }
    }
}
