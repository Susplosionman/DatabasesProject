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
            CurMovie = movie;
            InitializeComponent();

            Director d = smr.FetchDirectorByID(movie.DirectorID);

            uxMovieLabel.Text = CurMovie.Name;
            uxDirectorLabel.Text = d.Name;
            //List<Actor> actors = smr.GetActorsForMovie(CurMovie.MovieID);
            //uxActorsLabel1.Text = actors[0];
            //uxActorsLabel2.Text = actors[1];
            //uxActorsLabel3.Text = actors[2];
            //uxRatingLabel.Text = smr.GetAvgReviewForMovie(CurMovie.MovieID);
        }
    }
}
