using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aud_2
{
    public class Song
    {
        public string Name { get; set; }

        public double Rating { get; set; }

        public int Durration { get; set; }

        public string URL { get; set; }

        public Song()
        {

        }

        public Song(string name, double rating, int durration, string uRL)
        {
            Name = name;
            Rating = rating;
            Durration = durration;
            URL = uRL;
        }

        public override string ToString()
        {
            return string.Format("Name: {0}, Durration: {1}, Rating: {2}, URL: {3}\n", Name, Durration, Rating, URL);
        }
    }
}
