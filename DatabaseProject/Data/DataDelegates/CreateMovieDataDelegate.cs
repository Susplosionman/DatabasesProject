using Data.Models;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DataDelegates
{
    public class CreateMovieDataDelegate : NonQueryDataDelegate<Movie>
    {
        public string Name { get; set; }
        public DateTimeOffset ReleaseDate { get; set; }
        public string Genre { get; set; }
        public int DirectorID { get; set; }
        public CreateMovieDataDelegate(string name, DateTimeOffset releaseDate, string genre, int directorID) : base("Movie.CreateMovie")
        {
            Name = name;  
            ReleaseDate = releaseDate;
            Genre = genre;
            DirectorID = directorID;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("Name", Name);
            command.Parameters.AddWithValue("ReleaseDate", ReleaseDate);
            command.Parameters.AddWithValue("Genre", Genre);
            command.Parameters.AddWithValue("DirectorID", DirectorID);

            var p = command.Parameters.Add("MovieID", System.Data.SqlDbType.Int);
            p.Direction = System.Data.ParameterDirection.Output;
        }


        public override Movie Translate(SqlCommand command)
        {
            return new Movie((int)command.Parameters["MovieID"].Value, Name, ReleaseDate, Genre, DirectorID);
        }
    }
}
