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
        List<List<string>> MoviesAttended { get; set; } = new List<List<string>>();
        List<List<string>> Reviews { get; set; } = new List<List<string>>();
        public UserProfile(User user)
        {
            CurUser = user;
            InitializeComponent();
            uxUsernameLabel.Text = user.Username +"'s Profile";
            MoviesAttended = smr.RetrieveMoviesForUser(CurUser.UserID);
            Reviews = smr.RetrieveReviewsForUser(CurUser.UserID);

        }

        private void uxViewReviewsButton_Click(object sender, EventArgs e)
        {
            uxDataGrid.Columns.Clear();
            uxDataGrid.DataSource = null;
            uxDataGrid.Rows.Clear();

            Reviews = smr.RetrieveReviewsForUser(CurUser.UserID);
            uxDataGrid.Columns.Add("Key", "Movie Name");
            uxDataGrid.Columns.Add("Values", "Director Name");
            uxDataGrid.Columns.Add("Values", "Rating");
            uxDataGrid.Columns.Add("Values", "Comment");

            foreach (List<string> item in Reviews)
            {
                uxDataGrid.Rows.Add(item[0], item[1], item[2], item[3]);
            }
            uxDataGrid.Refresh();
                

            
        }

        private void uxViewMoviesAttendedButton_Click(object sender, EventArgs e)
        {
            uxDataGrid.Columns.Clear();
            uxDataGrid.DataSource = null;
            uxDataGrid.Rows.Clear();

            Reviews = smr.RetrieveReviewsForUser(CurUser.UserID);
            uxDataGrid.Columns.Add("Key", "Movie Name");
            //uxDataGrid.Columns.Add("Values", "Director Name");
            uxDataGrid.Columns.Add("Values", "Genre");
            uxDataGrid.Columns.Add("Values", "Release Date");

            foreach (List<string> item in MoviesAttended)
            {
                uxDataGrid.Rows.Add(item[0], item[1], item[2]);
            }
            uxDataGrid.Refresh();
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

        private void uxDeleteReview_Click(object sender, EventArgs e)
        {
            

            if (uxDataGrid.SelectedRows.Count > 0)
            {
                int selectedRowIndex = uxDataGrid.CurrentRow.Index;
                if (selectedRowIndex < Reviews.Count)
                {
                    smr.DeleteReview(Convert.ToInt32(Reviews[selectedRowIndex][4]));
                    Reviews = smr.RetrieveReviewsForUser(CurUser.UserID);

                    uxDataGrid.Columns.Clear();
                    uxDataGrid.DataSource = null;
                    uxDataGrid.Rows.Clear();

                    uxDataGrid.Columns.Add("Key", "Movie Name");
                    uxDataGrid.Columns.Add("Values", "Director Name");
                    uxDataGrid.Columns.Add("Values", "Rating");
                    uxDataGrid.Columns.Add("Values", "Comment");

                    foreach (List<string> item in Reviews)
                    {
                        uxDataGrid.Rows.Add(item[0], item[1], item[2], item[3]);
                    }
                    uxDataGrid.Refresh();
                }
                
                    
                
                
            }
        }
    }
}
