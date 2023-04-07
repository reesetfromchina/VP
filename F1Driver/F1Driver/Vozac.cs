using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1Driver
{
    public class Vozac
    {
        public string Ime { get; set; }
        public int Vozrast { get; set; }
        public bool Prv { get; set; }
        public List<Krug> Krugovi { get; set; } = new List<Krug>();

        public Vozac(string ime, int vozrast, bool prv)
        {
            Ime = ime;
            Vozrast = vozrast;
            Prv = prv;
        }

        public override string ToString()
        {
            return $"{Ime} - {Vozrast} - {Prv}";
        }
    }
}
