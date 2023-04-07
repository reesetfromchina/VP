using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamQuestions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDodadiIspit_Click(object sender, EventArgs e)
        {
            Ispit ispitForm = new Ispit();
            if(ispitForm.ShowDialog()  == DialogResult.OK )
            {
                lbIspit.Items.Add(ispitForm.ispit);
            }
        }

        private void btnDeleteIspit_Click(object sender, EventArgs e)
        {
            IspitClass ispitToDelete = lbIspit.SelectedItem as IspitClass;
            if(ispitToDelete != null)
            {
                lbIspit.Items.Remove(ispitToDelete);
            }
        }
    }
}
