using DataAccess;
using Data.Models;
using System.Data;
using System.Data.SqlClient;

namespace Data.DataDelegates
{
    internal class FetchUserDataDelegate : DataReaderDelegate<User>
    {
        private string Username;

        public FetchUserDataDelegate(string username) : base("Movie.FetchUser")
        {
            Username = username;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("Username", Username);
        }

        public override User Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
            {
                return new User(-1, "Not Found", "Not Found", "Not Found");
            }
            else
            {
                return new User(reader.GetInt32("UserID"), reader.GetString("Type"), Username, reader.GetString("Password"));
            }
        }
    }
}
