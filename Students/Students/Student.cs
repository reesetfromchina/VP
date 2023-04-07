using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Students
{
    public class Student
    {
        public string NameAndSurname { get; set; }
        public string Index { get; set; }
        public List<int> Grades { get; set; } = new List<int>();
        public Student(string nameAndSurname, string index)
        {
            NameAndSurname = nameAndSurname;
            Index = index;

        }

        public override string ToString()
        {
            return $"{Index} - {NameAndSurname}";
        }
    }
}
