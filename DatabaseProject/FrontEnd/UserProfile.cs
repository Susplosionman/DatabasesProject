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
    public partial class UserProfile : UserControl
    {
        public SqlMovieRepository smr = new SqlMovieRepository(@"Server=(localdb)\MSSQLLocalDb;Database=CIS560;Integrated Security=SSPI;");
        User CurUser { get; set; }
        List<Movie> MoviesAttended { get; set; } = new List<Movie>();
        List<Review> Reviews { get; set; } = new List<Review>();
        public UserProfile(User user)
        {
            CurUser = user;
            InitializeComponent();
            uxUsernameLabel.Text = user.Username +"'s Profile";
            MoviesAttended = (List<Movie>)smr.RetrieveMoviesForUser(CurUser.UserID);
            Reviews = (List<Review>)smr.RetrieveReviewsForUser(CurUser.UserID);

        }

        private void uxViewReviewsButton_Click(object sender, EventArgs e)
        {
            uxDataGrid.DataSource = Reviews;
        }

        private void uxViewMoviesAttendedButton_Click(object sender, EventArgs e)
        {
            uxDataGrid.DataSource = MoviesAttended;
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
    }
}
