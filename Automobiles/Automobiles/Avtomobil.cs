using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobiles
{
    public class Avtomobil
    {
        public string Name { get; set; }
        public string Brand { get; set; }

        public Avtomobil(string name, string brand)
        {
            Name = name;
            Brand = brand;
        }

        public override string ToString()
        {
            return $"{Name} - {Brand}";
        }
    }
}
