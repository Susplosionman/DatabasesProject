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
        User CurUser { get; set; }
        public CustomerView(User u)
        {
            InitializeComponent();
            List<Movie> movies = (List<Movie>)smr.RetrieveMovies();
            CurUser = u;
            for (int i = 0; i < movies.Count; i++)
            {
                Movies.Add(movies[i]);
            }
            for (int i = 0; i < movies.Count; i++)
            {
                ListViewItem item = new ListViewItem(Movies[i].ToString());
                List<Showing> showingsForMovieI = (List<Showing>)smr.RetrieveShowingsForMovie(Movies[i].MovieID);
                
                Review r = smr.GetAvgReviewsForMovie(Movies[i].MovieID);
                
                item.SubItems.Add(String.Format("{0:0.00}", r.Rating));


                List<Showing> futureShowings = new List<Showing>();
                for (int j = 0; j < showingsForMovieI.Count; j++)
                {
                    if (showingsForMovieI[j].ShowTime >= DateTimeOffset.Now)
                    {
                        futureShowings.Add(showingsForMovieI[j]);
                    }
                }

                if (futureShowings.Count > 0)
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
            uxBuyTicket.Enabled = false;
            uxSeeMovieInfo.Enabled = false;
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
            Movie movieToUse = FindMovieUsingMovieName(uxListView.SelectedItems[0].Text);
            if (this.FindForm() is UserInterface ui)
            {
                ui.Controls.Remove(this);

                MovieInfoControl movieInfoControl = new MovieInfoControl(movieToUse, CurUser);

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

        private void uxBuyTicket_Click(object sender, EventArgs e)
        {
            if (this.FindForm() is UserInterface ui)
            {
                ui.Controls.Remove(this);

                Movie movieToUse = FindMovieUsingMovieName(uxListView.SelectedItems[0].Text);
                BuyTicketControl btc = new BuyTicketControl(movieToUse, CurUser);

                ui.Controls.Add(btc);
                ui.Size = new Size(btc.Width + 50, btc.Height + 50);
            }
        }

        private void uxUserProfileButton_Click(object sender, EventArgs e)
        {
            if (this.FindForm() is UserInterface ui)
            {
                ui.Controls.Remove(this);

                
                UserProfile up = new UserProfile(CurUser);

                ui.Controls.Add(up);
                ui.Size = new Size(up.Width + 50, up.Height + 50);
            }
        }

        private void uxListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(uxListView.SelectedItems.Count > 0 && uxListView.SelectedItems.Count < 2)
            {
                uxBuyTicket.Enabled = true;
                uxSeeMovieInfo.Enabled = true;
            }
            if(uxListView.SelectedItems.Count == 0)
            {
                uxBuyTicket.Enabled = false;
                uxSeeMovieInfo.Enabled = false;
            }
        }
    }
}
