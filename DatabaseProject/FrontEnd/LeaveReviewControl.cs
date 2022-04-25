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
    public partial class LeaveReviewControl : UserControl
    {
        public SqlMovieRepository smr = new SqlMovieRepository(@"Server=(localdb)\MSSQLLocalDb;Database=CIS560;Integrated Security=SSPI;");

        Movie CurMovie { get; set; }
        public LeaveReviewControl(Movie m)
        {
            InitializeComponent();
            CurMovie = m;
        }

        private void uxLeaveReviewButton_Click(object sender, EventArgs e)
        {
            smr.CreateUser("Customer", "Jimbo Fisher", "yeehaw");
            smr.CreateReview(1, (int)uxRatingUpDown.Value, uxCommentTB.Text, CurMovie.MovieID); // dummy value for user

            if (this.FindForm() is UserInterface ui)
            {
                MovieInfoControl mic = new MovieInfoControl(CurMovie);
                ui.Controls.Remove(this);
                ui.Controls.Add(mic);
                ui.Size = new Size(mic.Width + 50, mic.Height + 50);
            }
        }

        private void uxBackButton_Click(object sender, EventArgs e)
        {
            if (this.FindForm() is UserInterface ui)
            {
                MovieInfoControl mic = new MovieInfoControl(CurMovie);
                ui.Controls.Remove(this);
                ui.Controls.Add(mic);
                ui.Size = new Size(mic.Width + 50, mic.Height + 50);
            }
        }
    }
}
