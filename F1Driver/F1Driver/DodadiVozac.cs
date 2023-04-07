using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F1Driver
{
    
    public partial class DodadiVozac : Form
    {
        public Vozac vozac { get; set; }
        public DodadiVozac()
        {
            InitializeComponent();
        }

        private void btnDodadi_Click(object sender, EventArgs e)
        {
            vozac = new Vozac(tbIme.Text, (int)nudVozrast.Value, cbPrvVozac.Checked);
            this.DialogResult=DialogResult.OK;
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void tbIme_Validated(object sender, EventArgs e)
        {
            if(tbIme.Text == "")
            {
                errorProvider1.SetError(tbIme, "Imeto ne smee da bide prazno");
            }
            else
            {
                errorProvider1.SetError(tbIme, null);
            }
        }
    }
}
