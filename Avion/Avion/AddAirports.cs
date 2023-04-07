using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avion
{
    public partial class AddAirports : Form
    {
        public Airport airport {  get; set; }
        public AddAirports()
        {
            InitializeComponent();
        }

        private void tbCity_Validated(object sender, EventArgs e)
        {
            if(tbCity.Text == "")
            {
                errorProvider1.SetError(tbCity, "Полето за град не смее да биде празно!");
            }
            else
            {
                errorProvider1.SetError(tbCity, null);
            }
        }

        private void tbCode_Validated(object sender, EventArgs e)
        {
            
        }

        private void btnSaveAddAirport_Click(object sender, EventArgs e)
        {
            this.airport = new Airport(tbCity.Text, tbName.Text, tbCode.Text);
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelAirportAdd_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void tbCode_Validating(object sender, CancelEventArgs e)
        {
            if (tbCode.Text.Length == 3)
            {
                bool allUpperLetter = true;
                foreach (char c in tbCode.Text)
                {
                    if (Char.IsLetter(c) || Char.IsLower(c))
                    {
                        allUpperLetter = false;
                        break;
                    }
                }
                if (allUpperLetter)
                {
                    errorProvider1.SetError(tbCode, null);
                }
                else
                {
                    errorProvider1.SetError(tbCode, "Сите карактери мора да се големи букви!");
                    

                }
            }
            else
            {
                errorProvider1.SetError(tbCode, "Кодот мора да биде точно 3 карактери!");
                
            }
        }
    }
}
