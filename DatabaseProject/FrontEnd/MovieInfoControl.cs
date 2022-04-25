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
        public MovieInfoControl(Movie movie)
        {
            InitializeComponent();
            
            CurMovie = movie;
            Director d = smr.FetchDirectorByID(movie.DirectorID);
            
            List<Showing> showings = (List<Showing>)smr.RetrieveShowingsForMovie(CurMovie.MovieID);
            uxShowingBox.DataSource = showings;

            uxMovieLabel.Text = CurMovie.Name;
            uxDirectorLabel.Text = d.Name;
            
            //List<Actor> actors = (List<Actor>)smr.GetActorsForMovie(CurMovie.MovieID);
            //uxActorsLabel1.Text = actors[0];
            //uxActorsLabel2.Text = actors[1];
            //uxActorsLabel3.Text = actors[2];
            //uxRatingLabel.Text = smr.GetAvgReviewForMovie(CurMovie.MovieID);
        }

        private void uxBackButton_Click(object sender, EventArgs e)
        {
            if (this.FindForm() is UserInterface ui)
            {
                ui.Controls.Remove(this);
                ui.Controls.Add(new CustomerView());
                ui.Size = new Size(ui._customerView.Width + 50, ui._customerView.Height + 50);
            }
        }

        private void uxLeaveReviewButton_Click(object sender, EventArgs e)
        {
            if (this.FindForm() is UserInterface ui)
            {
                LeaveReviewControl lrc = new LeaveReviewControl(CurMovie);
                ui.Controls.Remove(this);
                ui.Controls.Add(lrc);
                ui.Size = new Size(lrc.Width + 50, lrc.Height + 50);
            }
        }

        private void uxBuyTicketButton_Click(object sender, EventArgs e)
        {
            if (this.FindForm() is UserInterface ui)
            {
                BuyTicketControl btc = new BuyTicketControl(CurMovie);
                ui.Controls.Remove(this);
                ui.Controls.Add(btc);
                ui.Size = new Size(btc.Width + 50, btc.Height + 50);
            }
        }
    }
}
