using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Movie
    {
        public int MovieID { get; set; }

        public string Name { get; set; }
        public DateTimeOffset ReleaseDate { get; set; }
        public string Genre { get; set; }
        public int DirectorID { get; set; }

        public Movie(int movieID, string name, DateTimeOffset release, string genre, int directorID)
        {
            MovieID = movieID;
            Name = name;
            ReleaseDate = release;
            Genre = genre;
            DirectorID = directorID;
        }
    }
}
