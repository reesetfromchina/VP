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
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddAerodrom_Click(object sender, EventArgs e)
        {
            AddAirports addAirports = new AddAirports();
            if(addAirports.ShowDialog() == DialogResult.OK )
            {
                lbAirport.Items.Add(addAirports.airport);
            }
        }

      

        private void btnDeleteAerodrom_Click(object sender, EventArgs e)
        {
            if(lbAirport.SelectedIndex != -1)
            {
                DialogResult dialogResult = MessageBox.Show("Дали си сигурен", "Сигурен ли си", MessageBoxButtons.OKCancel);
                if(dialogResult.Equals(DialogResult.OK) )
                {
                    int selectedIndex = lbAirport.SelectedIndex;
                    lbAirport.Items.RemoveAt(selectedIndex);
                }
            }
        }

        private void btnAddDestination_Click(object sender, EventArgs e)
        {
            if(lbAirport.SelectedIndex != -1)
            {
                AddDestination addDestinationForm = new AddDestination();
                if(addDestinationForm.ShowDialog() == DialogResult.OK)
                {
                    Airport selectedAirport = lbAirport.Items[lbAirport.SelectedIndex] as Airport;
                    selectedAirport.Destinations.Add(addDestinationForm.CreatedDestination);
                    loadDestinations();
                }
            }
        }

        private void loadDestinations()
        {
            lbDestinations.Items.Clear();
            tbAverageDestination.Clear();
            tbMostExpensiveDestination.Clear();
            if (lbAirport.SelectedIndex != -1)
            {
                Airport selectedAirport = lbAirport.Items[lbAirport.SelectedIndex] as Airport;
                foreach (Destination destination in selectedAirport.Destinations)
                {
                    lbDestinations.Items.Add(destination);
                }

                double sum = 0;
                int max = 0;

                foreach (Destination destination in selectedAirport.Destinations)
                {
                    if (destination.Price > max)
                    {
                        max = destination.Price;

                    }
                    sum += destination.Distance;
                }

                if (selectedAirport.Destinations.Count > 0)
                {
                    double average = sum / selectedAirport.Destinations.Count;
                    tbMostExpensiveDestination.Text = max.ToString();

                    tbAverageDestination.Text = $"{average}";
                }
                else
                {
                    tbAverageDestination.Text = "Овој аеродром нема дестинации.";
                    tbMostExpensiveDestination.Text = "Овој аеродром нема дестинации.";

                }



            }
        }

        private void lbAirport_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadDestinations();
        }

        private void lbAirport_SelectedValueChanged(object sender, EventArgs e)
        {
            loadDestinations();
        }
    }
}
