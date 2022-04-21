using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Director
    {
        public int DirectorID { get; set; }
        public string Name { get; set; }

        public Director(int id, string name)
        {
            DirectorID = id;
            Name = name;
        }
    }
}
