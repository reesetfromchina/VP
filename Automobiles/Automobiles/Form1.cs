using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automobiles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddBrand_Click(object sender, EventArgs e)
        {
            NovaMarka novaMarkaForm = new NovaMarka();

            if(novaMarkaForm.ShowDialog() == DialogResult.OK)
            {
                lbBrandCars.Items.Add(novaMarkaForm.car);  
            }
        }
    }
}
