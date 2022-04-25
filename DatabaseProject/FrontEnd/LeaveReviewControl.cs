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
        User CurUser { get; set; }
        Movie CurMovie { get; set; }
        public LeaveReviewControl(Movie m, User u)
        {
            InitializeComponent();
            CurMovie = m;
            CurUser = u;
        }

        private void uxLeaveReviewButton_Click(object sender, EventArgs e)
        {
            
            smr.CreateReview(CurUser.UserID, (int)uxRatingUpDown.Value, uxCommentTB.Text, CurMovie.MovieID);

            if (this.FindForm() is UserInterface ui)
            {
                MovieInfoControl mic = new MovieInfoControl(CurMovie, CurUser);
                ui.Controls.Remove(this);
                ui.Controls.Add(mic);
                ui.Size = new Size(mic.Width + 50, mic.Height + 50);
            }
        }

        private void uxBackButton_Click(object sender, EventArgs e)
        {
            if (this.FindForm() is UserInterface ui)
            {
                MovieInfoControl mic = new MovieInfoControl(CurMovie, CurUser);
                ui.Controls.Remove(this);
                ui.Controls.Add(mic);
                ui.Size = new Size(mic.Width + 50, mic.Height + 50);
            }
        }
    }
}
