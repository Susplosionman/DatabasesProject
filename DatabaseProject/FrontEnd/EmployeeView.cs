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
    public partial class EmployeeView : UserControl
    {
        public SqlMovieRepository smr = new SqlMovieRepository(@"Server=(localdb)\MSSQLLocalDb;Database=CIS560;Integrated Security=SSPI;");

        BindingList<Movie> Movies = new BindingList<Movie>();

        private Movie _selectedMovie { get; set; }
        public EmployeeView()
        {
            InitializeComponent();
            //AddDummyMovies(movies);

            List<Movie> movies = (List<Movie>)smr.RetrieveMovies();
            for (int i = 0; i < movies.Count; i++)
            {
                Movies.Add(movies[i]);
            }
            uxMovieBox.DataSource = Movies;
            
            
            
        }
        private void uxTestAdd_Click(object sender, EventArgs e)
        {
            smr.CreateDirector("Bob Jones");
            smr.CreateMovie("TestMovie", new DateTimeOffset(), "testgenre", 1);
            List<Movie> movies = (List<Movie>)smr.RetrieveMovies();
            for (int i = 0; i < movies.Count; i++)
            {
                Movies.Add(movies[i]);
            }
            uxMovieBox.Update();

        }
        private void uxMovieBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedMovie = (Movie)uxMovieBox.SelectedItem;
        }

        private void uxDeleteSelectedButton_Click(object sender, EventArgs e)
        {
            smr.DeleteMovie(_selectedMovie.MovieID);
            List<Movie> movies = (List<Movie>)smr.RetrieveMovies();
            
            Movies.Remove(_selectedMovie);
            uxMovieBox.Update();
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

        private void uxAddMovieButton_Click(object sender, EventArgs e)
        {
            if (this.FindForm() is UserInterface ui)
            {
                ui.Controls.Remove(this);
                ui.Controls.Add(ui._addMovieControl);
                ui.Size = new Size(ui._addMovieControl.Width + 50, ui._addMovieControl.Height + 50);
            }
        }

        private void uxSelectButton_Click(object sender, EventArgs e)
        {
            if (this.FindForm() is UserInterface ui)
            {
                ui.Controls.Remove(this);
                ui._modifyMovieControl = new ModifySelectedMovie(_selectedMovie);
                ui.Controls.Add(ui._modifyMovieControl);
                ui.Size = new Size(ui._modifyMovieControl.Width + 50, ui._modifyMovieControl.Height + 50);
            }
        }
    }
}
