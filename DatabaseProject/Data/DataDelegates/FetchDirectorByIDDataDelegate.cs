using DataAccess;
using Data.Models;
using System.Data;
using System.Data.SqlClient;

namespace Data.DataDelegates
{
    internal class FetchDirectorByIDDataDelegate : DataReaderDelegate<Director>
    {
        private int ID;

        public FetchDirectorByIDDataDelegate(int id)
           : base("Movie.FetchDirectorByID")
        {
            ID = id;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("DirectorID", ID);
        }

        public override Director Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
            {
                return new Director(-1, "Not Found");
            }
            else
            {
                return new Director(ID, reader.GetString("Name"));
            }



        }
    }
}