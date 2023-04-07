using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportskaOblozuvalnica
{
    public class Team
    {
        public string Name { get; set; }
        public string Country { get; set; }

        public Team(string Name, string Country)
        {
            this.Name = Name;
            this.Country = Country;
        }

        public override string ToString()
        {
            return $"{Name} ({Country})";
        }
    }

   

}
