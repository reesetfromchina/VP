using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamQuestions
{
    public class IspitClass
    {
        public string Mesec { get; set; }
        public int Godina { get; set; }
        public List<Ispit> Ispiti { get; set; } = new List<Ispit>();

        public IspitClass(string mesec, int godina)
        {
            Mesec = mesec;
            Godina = godina;
        }

        public override string ToString()
        {
            return $"{Godina} - {Mesec}";
        }
    }
}
