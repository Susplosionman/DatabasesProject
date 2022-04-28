using DataAccess;
using Data.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Data.DataDelegates
{
    internal class GetDistinctGenresDataDelegate : DataReaderDelegate<IReadOnlyList<string>>
    {
        
        public GetDistinctGenresDataDelegate()
           : base("Movie.GetDistinctGenres")
        {
        }

      

        public override IReadOnlyList<string> Translate(SqlCommand command, IDataRowReader reader)
        {
            var genres = new List<string>();

            while (reader.Read())
            {
                genres.Add(reader.GetString("Genre"));
            }

            return genres;
        }
    }
}