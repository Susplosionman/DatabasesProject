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
    public partial class CustomerView : UserControl
    {
        public SqlMovieRepository smr = new SqlMovieRepository(@"Server=(localdb)\MSSQLLocalDb;Database=CIS560;Integrated Security=SSPI;");

        public BindingList<Movie> Movies { get; set; } = new BindingList<Movie>();
        public BindingList<Showing> Showings { get; set; } = new BindingList<Showing>();

        public CustomerView()
        {
            InitializeComponent();
            List<Movie> movies = (List<Movie>)smr.RetrieveMovies();
            for (int i = 0; i < movies.Count; i++)
            {
                Movies.Add(movies[i]);
            }
            for (int i = 0; i < movies.Count; i++)
            {
                ListViewItem item = new ListViewItem(Movies[i].ToString());
                List<Showing> showingsForMovieI = (List<Showing>)smr.RetrieveShowingsForMovie(Movies[i].MovieID);
                item.SubItems.Add("aint got no ratin yet");

                if (showingsForMovieI.Count > 0)
                {
                    item.SubItems.Add("Yes");
                }
                else
                {
                    item.SubItems.Add("No");
                } 
                // int avgreview = smr.GetAvgReview
                //item.SubItems.Add(avgreview);
                //if (showings.Count > 0) { Is showing = yes } else { no }
                
                uxListView.Items.Add(item);
            }
        }

        private void uxLogoutButton_Click(object sender, EventArgs e)
        {
            if (this.FindForm() is UserInterface ui)
            {
                ui.Controls.Remove(this);
                ui.Controls.Add(new LoginControl());
                ui.Size = new Size(ui._loginControl.Width + 50, ui._loginControl.Height + 50);
            }
        }

        private void uxSeeMovieInfo_Click(object sender, EventArgs e)
        {
            if (this.FindForm() is UserInterface ui)
            {
                ui.Controls.Remove(this);

                Movie movieToUse = FindMovieUsingMovieName(uxListView.SelectedItems[0].Text);
                MovieInfoControl movieInfoControl = new MovieInfoControl(movieToUse);

                ui.Controls.Add(movieInfoControl);
                ui.Size = new Size(movieInfoControl.Width + 50, movieInfoControl.Height + 50);
            }
        }

        private Movie FindMovieUsingMovieName(string name)
        {
            for (int i = 0; i < Movies.Count; i++)
            {
                if (Movies[i].Name == name)
                {
                    return Movies[i];
                }
            }
            return null;
        }
    }
}
