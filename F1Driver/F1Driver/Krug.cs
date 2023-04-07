
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1Driver
{
    public class Krug
    {
        public int Minuti { get; set; }
        public int Sekundi { get; set; }

        public Krug(int minuti, int sekundi)
        {
            Minuti = minuti;
            Sekundi = sekundi;
        }

        public override string ToString()
        {
            return $"{Minuti}:{Sekundi}";
        }
    }
}
