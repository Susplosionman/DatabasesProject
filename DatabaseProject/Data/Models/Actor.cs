using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Actor
    {
        public int ActorID { get; set; }
        public string Name { get; set; }

        public Actor(int id, string name)
        {
            ActorID = id;
            Name = name;
        }
    }
}
