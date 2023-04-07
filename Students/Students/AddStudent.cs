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
    public partial class AddStudent : Form
    {
        public Student student { get; set; }
        public AddStudent()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.student = new Student(tbNameAndSurname.Text, tbIndex.Text);
            DialogResult = DialogResult.OK;
        }

        private void tbNameAndSurname_Validating(object sender, CancelEventArgs e)
        {
            Student student = new Student(tbNameAndSurname.Text, tbIndex.Text);
            if (student.NameAndSurname.Length == 0)
            {
                errorProvider1.SetError(tbNameAndSurname, "Ова поле не смее да бида празно шефе!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbNameAndSurname, null);
            }

            foreach(char c in student.Index)
            {
                if (!(c == 'c' || c == '1' || c=='2'|| c== '3'|| c=='4' || c=='5'|| c=='6' || c=='7' || c =='8' || c=='9' || c == '0') || student.Index.Length != 6)
                {
                    errorProvider1.SetError(tbIndex, "Индексот мора да биде од 6 цифри");
                    e.Cancel = true;
                }
                else
                {
                    errorProvider1.SetError(tbIndex, null);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void tbNameAndSurname_Validating(object sender, EventArgs e)
        {

        }
    }
}
