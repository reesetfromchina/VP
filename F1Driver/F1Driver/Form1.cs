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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDodadiVozac_Click(object sender, EventArgs e)
        {
            DodadiVozac dodadiVozacForm = new DodadiVozac();
            if(dodadiVozacForm.ShowDialog() == DialogResult.OK)
            {
                lbVozaci.Items.Add(dodadiVozacForm.vozac);
            }
        }

        private void btnIzbrisiVozac_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Siguren li si", "Da li si siguren", MessageBoxButtons.YesNo);
            if(dg == DialogResult.Yes)
            {
                Vozac vozac = lbVozaci.SelectedItem as Vozac;
                if(vozac != null)
                {
                    lbVozaci.Items.Remove(vozac);
                }
            }
        }

        private void btnAddKrug_Click(object sender, EventArgs e)
        {


            Vozac vozac = lbVozaci.SelectedItem as Vozac;
           
            int minuti = (int)nudMinuti.Value;
            int sekundi = (int)nudSekundi.Value;
             if ( sekundi> 59)
            {
                minuti++;
                sekundi = 0;
            }
            if (vozac != null)
                vozac.Krugovi.Add(new Krug(minuti, sekundi));


            lbKrugovi.Items.Clear();

            Krug najdobarKrug = new Krug(999, 999);
            foreach (Krug k in vozac.Krugovi)
            {
              
                lbKrugovi.Items.Add(k);
               
            }

            change();


        }

        private void change()
        {
            Vozac vozac = lbVozaci.SelectedItem as Vozac;
            lbKrugovi.Items.Clear();
            int min = 9999;

            lbKrugovi.Items.Clear();

            Krug najdobarKrug = new Krug(999, 999);
            foreach (Krug k in vozac.Krugovi)
            {
                if((k.Minuti / 60) + k.Sekundi > (int)nudVreme.Value)
                {
                    lbKrugovi.Items.Add(k);
                }
                lbKrugovi.Items.Add(k);
                if (min > (k.Minuti / 60) + k.Sekundi)
                {
                    najdobarKrug = k;
                }
            }

            tbNajdobarKrug.Text = najdobarKrug.ToString();
        }

        private void nudVreme_ValueChanged(object sender, EventArgs e)
        {
            change();
        }

        private void lbVozaci_SelectedIndexChanged(object sender, EventArgs e)
        {
            change();
        }
    }
}
