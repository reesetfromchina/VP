using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TvSerii
{
    public class Programi
    {
        public string Name { get; set; }
        public int LengthInMin { get; set; }

        public Programi(string name, int lengthInMin)
        {
            Name = name;
            LengthInMin = lengthInMin;
        }

        public Programi()
        {
        }

        public override string ToString()
        {
            return $"{Name} - {LengthInMin}";
        }


    }
}
