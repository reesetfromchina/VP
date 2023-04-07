using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace av3
{
    internal class Song
    {
        public string Name { get; set; }
        public int Length { get; set; }
        public decimal Rating { get; set; }

        public Song(string name, int length, decimal rating)
        {
            Name = name;
            Length = length;
            Rating = rating;
        }

        public override string ToString()
        {
            return $"Song name: {Name} with durration: {Length} and rating: {Rating}";
        }
    }
}
