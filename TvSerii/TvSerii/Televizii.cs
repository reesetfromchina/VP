using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TvSerii
{
    public class Televizii
    {
        //public Programi Programs { get; set; }
        public List<Programi> Programs { get; set; } = new List<Programi>();
        public string Name { get; set; }
        public int Number { get; set; }

        public Televizii(string name, int number)
        {
            Name = name;
            Number = number;
        }

        public Televizii()
        {
        }

        public override string ToString()
        {
            return $"{Name} - {Number}";
        }
    }
}
