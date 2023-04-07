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
    public partial class Ispit : Form
    {
        public IspitClass ispit { get; set; }
        public Ispit()
        {
            InitializeComponent();
        }

        private void btnDodadi_Click(object sender, EventArgs e)
        {
            ispit = new IspitClass(cbMesec.Text, (int)nudGodina.Value);
            this.DialogResult = DialogResult.OK; 
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
