using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TvSerii
{
    public partial class AddTv : Form
    {
        public Televizii Tv { get; set; }
        public Form1 Form1 { get; set; }
        public AddTv()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
           
            if(tbName.Text != "" && tbNumber.Text !="")
            {
                Tv = new Televizii(tbName.Text, Int32.Parse(tbNumber.Text));
                this.DialogResult = DialogResult.OK;
            }
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if(tbName.Text == "")
            {
                errorProvider1.SetError(tbName, "Name should not be empty!");
                SystemSounds.Beep.Play();
            }
            else
            {
                errorProvider1.SetError(tbName, null);
            }
           


             
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
