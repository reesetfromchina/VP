using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaMan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        StringBuilder sb = new StringBuilder();
        public void calculateTotal()
        {
            string pizzaSize = "";
            sb.Clear();
            int price = 0;
            int ifItsNothing = 0;
            if (rbSmall.Checked)
            {
                price += Convert.ToInt32(tbSmall.Text);
                sb.Append("Small pizza\n");
            }
            else if (rbLarge.Checked)
            {
                price += Convert.ToInt32(tbLarge.Text);
                sb.Append("Large pizza\n");
            }
            else
            {
                price += Convert.ToInt32(tbMid.Text);
                sb.Append("Mid pizza\n");

            }
            // ... vasiot kod ovde ...
            sb.Append("Dodatoci:\n");
            if (cbHotPeppers.Checked)
            {
                price += Int32.Parse(tbHotPeppers.Text);
                sb.Append("Hot peppers\n");
            }
            if (cbExtraCheese.Checked)
            {
                price += Int32.Parse(tbExtraCheese.Text);
                sb.Append("Extra cheese\n");
            }
            if (cbKetchup.Checked)
            {
                price += Int32.Parse(tbKetchup.Text);
                sb.Append("Ketchup\n");
            }



            int sodaPrice = Int32.Parse(tbSodaPrice.Text) * Int32.Parse(tbQuantitySoda.Text);
            int appleJuice = Int32.Parse(tbAppleJuiceQuantity.Text) * Int32.Parse(tbAppleJuicePrice.Text);
            int beerPrice = Int32.Parse(tbBeerQuantity.Text) * Int32.Parse(tbBeerPrice.Text);

            tbTotalSoda.Text = sodaPrice.ToString();
            tbAppleTotal.Text = appleJuice.ToString();
            tbBeerTotal.Text = beerPrice.ToString();



            sb.Append("Drink:\n");
            sb.AppendLine(tbQuantitySoda.Text + " " + "Coca cola / Fanta / Sprite Clean");
            sb.AppendLine(tbAppleJuiceQuantity.Text + " " + "Apple juice ");
            sb.AppendLine(tbBeerQuantity.Text + " " + "Beer");
            sb.AppendLine("Dessert");
            //sb.AppendLine("Nekkoj desert tuka lol");

            if (lbDessert.SelectedIndex == 0)
            {
                tbPriceOfDesert.Text = "40";
            } else if(lbDessert.SelectedIndex == 1)
            {
                tbPriceOfDesert.Text = "10";
            }
            else if(lbDessert.SelectedIndex == 2)
            {
                tbPriceOfDesert.Text = "300";
            }
            sb.AppendLine(lbDessert.SelectedItem.ToString());

            price += Int32.Parse(tbPriceOfDesert.Text);

            price += sodaPrice + appleJuice + beerPrice;
            if (!int.TryParse(tbTotalToPlay.Text, out ifItsNothing))
            {
                tbTotalToPlay.Text = "0";
            }
            else
            {
                tbTotalToPlay.Text = price.ToString();

            }
            if(Int32.Parse(tbPaid.Text) != 0)
            {
                int change = Int32.Parse(tbPaid.Text) - price;
                tbChange.Text = change.ToString();

            }


        }

          

            private void rbSmall_CheckedChanged(object sender, EventArgs e)
            {
                calculateTotal();

            }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            
            DialogResult dialog = MessageBox.Show(sb.ToString(), "Order");
        }
    }
    }

