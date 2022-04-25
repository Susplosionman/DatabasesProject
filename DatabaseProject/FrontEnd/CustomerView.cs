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
            List<Movie> movies = (List<Movie>)smr.RetrieveMovies();
            for (int i = 0; i < movies.Count; i++)
            {
                Movies.Add(movies[i]);
            }
            for (int i = 0; i < )
            List<Showing> showings = (List<Showing>)smr.RetrieveShowingsForMovie();
            for (int i = 0; i < movies.Count; i++)
            {
                Showings.Add(movies[i]);
            }

            InitializeComponent();
        }
    }
}
