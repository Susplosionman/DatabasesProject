using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class User
    {
        public int UserID { get; set; }
        public UserType Type { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public User(int id, UserType type, string username, string pw)
        {
            UserID = id;
            Type = type;
            Username = username;
            Password = pw;
        }
    }
}
