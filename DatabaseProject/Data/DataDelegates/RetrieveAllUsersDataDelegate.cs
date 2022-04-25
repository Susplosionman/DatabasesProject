using DataAccess;
using Data.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Data.DataDelegates
{
    internal class RetrieveAllUsersDataDelegate : DataReaderDelegate<IReadOnlyList<User>>
    {
        public RetrieveAllUsersDataDelegate()
           : base("Movie.RetrieveAllUsers")
        {
        }

        public override IReadOnlyList<User> Translate(SqlCommand command, IDataRowReader reader)
        {
            var users = new List<User>();

            while (reader.Read())
            {
                users.Add(new User(
                   reader.GetInt32("UserID"),
                   reader.GetString("Type"),
                   reader.GetString("Username"),
                   reader.GetString("Password")));
                   
            }

            return users;
        }
    }
}