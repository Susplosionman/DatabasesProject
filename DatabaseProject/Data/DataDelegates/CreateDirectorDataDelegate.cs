using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;
using DataAccess;

namespace Data.DataDelegates
{

    
    public class CreateDirectorDataDelegate : NonQueryDataDelegate<Director>
    {
        public string Name { get; set; }

        public CreateDirectorDataDelegate(string name) : base("Movie.CreateDirector")
        {
            Name = name;
        }
        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("Name", Name);
            var p = command.Parameters.Add("DirectorID", System.Data.SqlDbType.Int);
            p.Direction = System.Data.ParameterDirection.Output;
        }

        public override Director Translate(SqlCommand command)
        {
            return new Director((int)command.Parameters["DirectorID"].Value, Name);
        }
    }
}
