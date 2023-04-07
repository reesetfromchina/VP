using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Students
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            AddStudent addStudentForm = new AddStudent();
            if(addStudentForm.ShowDialog() == DialogResult.OK)
            {
                lbStudents.Items.Add(addStudentForm.student);
            }
            
        }

        private void btnAddGrade_Click(object sender, EventArgs e)
        {
            Student selectedStudent = lbStudents.SelectedItem as Student;
            if((int)nudGrade.Value == 5)
            {
                return;
            }
            selectedStudent.Grades.Add((int)nudGrade.Value);
            change();
        }

        private void lbStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            change();
        }

        private void change()
        {
            Student selectedStudent = lbStudents.SelectedItem as Student;
            // average grade
            if(selectedStudent.Grades.Count > 10)
            {
                return;
            }
            int sum = 0;
            double average = 0;
            int maxGrade = 0;
            if(selectedStudent.Grades.Count != 0)
            {
                foreach(int grade in selectedStudent.Grades)
                {
                    sum += grade;
                    if (grade > maxGrade)
                    {
                        maxGrade = grade;
                    }
                }

                average = (sum + 0.0) / selectedStudent.Grades.Count;
            }
            else
            {
                average = 5;
            }
            
            StringBuilder sb = new StringBuilder();
            sb.Clear();
            sb.AppendLine($"Име: {selectedStudent.NameAndSurname}");
            sb.AppendLine($"Индекс: {selectedStudent.Index}");
            sb.AppendLine($"Број на оценки: {selectedStudent.Grades.Count}");
            sb.AppendLine($"Просечна оценка: {average}");
            sb.AppendLine($"Максимална оценка: {maxGrade}");
            lbInformations.Text = sb.ToString();
        }

        private void btnDeleteGrades_Click(object sender, EventArgs e)
        {
            Student selectedStudent = lbStudents.SelectedItem as Student;
            DialogResult dialogResult = MessageBox.Show("Сигурен ли си", "Дали си сугуреен", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                selectedStudent.Grades.Clear();
                change();
            }
        }

        private void najvisokProsek()
        {
            foreach(Student student in lbStudents.Items)
            {
                //student.Grades;
            }
        }
    }
}
