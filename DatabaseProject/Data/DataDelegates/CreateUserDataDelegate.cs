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
    public class CreateUserDataDelegate : NonQueryDataDelegate<User>
    {
        public string Type { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public CreateUserDataDelegate(string type, string username, string pw) : base("Movie.CreateUser")
        {
            
            Type = type;
            Username = username;
            Password = pw;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("Type", Type);
            command.Parameters.AddWithValue("Username", Username);
            command.Parameters.AddWithValue("Password", Password);


            var p = command.Parameters.Add("UserID", System.Data.SqlDbType.Int);
            p.Direction = System.Data.ParameterDirection.Output;
        }


        public override User Translate(SqlCommand command)
        {
            return new User((int)command.Parameters["UserID"].Value, Type, Username, Password);
        }
    }
}
