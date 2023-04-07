using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TvSerii
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddProgram_Click(object sender, EventArgs e)
        {
            Televizii tv = cbTV.SelectedItem as Televizii;

            Programi programa = new Programi(tbName.Text,(int)nudTimeLength.Value );
            tv.Programs.Add(programa);
            change();

        }

        private void btnAddTv_Click(object sender, EventArgs e)
        {
            AddTv addTvForm = new AddTv();
            if (addTvForm.ShowDialog() == DialogResult.OK)
            {
                cbTV.Items.Add(addTvForm.Tv);
            }
        }
        private void change()
        {
            lbTV.Text = cbTV.SelectedItem.ToString();

            Televizii tv = cbTV.SelectedItem as Televizii;
            lbProgrami.Items.Clear();
            int sum = 0;
            foreach (Programi p in tv.Programs)
            {
                lbProgrami.Items.Add(p);
                sum += p.LengthInMin;

            }
            if(lbProgrami.Items.Count != 0)
            {
                float average = sum / lbProgrami.Items.Count;
                tbAverage.Text = average.ToString();

            }
        }
        private void cbTV_SelectedIndexChanged(object sender, EventArgs e)
        {
            change();
            //Televizii televizija = cbTV.SelectedItem as Televizii;
            //string test = cbTV.SelectedItem.ToString();
            //lbProgrami.Items.Add(televizija.Programs);
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            if(tbName.Text.Length == 0)
            {
                btnAddProgram.Enabled = false;  
            }
            else
            {
                btnAddProgram.Enabled = true;

            }
        }

        private void btnDeleteProgram_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Dali si siguren", "Siguren li si", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {

                Televizii tv = cbTV.SelectedItem as Televizii;
                //Programi programi = lbProgrami.SelectedItem as Programi;
                //tv.Programs.Clear();
                Programi programa = new Programi();
                foreach (Programi p in tv.Programs)
                {
                    if (p.Equals(lbProgrami.SelectedItem))
                    {
                        //lbProgrami.Items.Remove(p);
                        //tv.Programs.Remove(p);
                        programa = p; break;
                    }
                }

                tv.Programs.Remove(programa);
                change();
            }
            //lbProgrami.Items.Remove(programi);
        }
    }
}
