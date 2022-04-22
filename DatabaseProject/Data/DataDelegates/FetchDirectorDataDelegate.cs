using DataAccess;
using Data.Models;
using System.Data;
using System.Data.SqlClient;

namespace Data.DataDelegates
{
    internal class FetchDirectorDataDelegate : DataReaderDelegate<Director>
    {
        private string Name;

        public FetchDirectorDataDelegate(string name)
           : base("Movie.FetchDirector")
        {
            Name = name;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("Name", Name);
        }

        public override Director Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                throw new RecordNotFoundException(Name);

            return new Director(reader.GetInt32("DirectorID"),
               Name);
               
        }
    }
}