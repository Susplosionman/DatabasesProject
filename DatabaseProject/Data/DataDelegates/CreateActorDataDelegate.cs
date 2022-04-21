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


    public class CreateActorDataDelegate : NonQueryDataDelegate<Actor>
    {
        public string Name { get; set; }

        public CreateActorDataDelegate(string name) : base("Movie.CreateActor")
        {
            Name = name;
        }
        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("Name", Name);
            var p = command.Parameters.Add("ActorID", System.Data.SqlDbType.Int);
            p.Direction = System.Data.ParameterDirection.Output;
        }

        public override Actor Translate(SqlCommand command)
        {
            return new Actor((int)command.Parameters["ActorID"].Value, Name);
        }
    }
}
