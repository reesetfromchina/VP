using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportskaOblozuvalnica
{
    public partial class Form1 : Form
    {
        TeamForm input;
        Team t1 = new Team("AC Milan", "Italy");
        Team t2 = new Team("Juventus", "Italy");
        Team t3 = new Team("Napoli", "Italy");
        
        private void recalculateTicket()
        {
            decimal totalCoef = 1.0M;
            foreach(var item in lbTickets.Items)
            {
                GameForTicket gameForTicket = item as GameForTicket;
                totalCoef *= gameForTicket.getCoef();
                tbTotalCoef.Text = totalCoef.ToString();
                tbDobivka.Text = ($"{totalCoef * nudPayment.Value}");
            }
        }
        public Form1()
        {
            InitializeComponent();
            lbTeams.Items.Add(t1);
            lbTeams.Items.Add(t2);
            lbTeams.Items.Add(t3);
        }

        private void btnDodadiNovTim_Click(object sender, EventArgs e)
        {
            input = new TeamForm();

            if (input.ShowDialog() == DialogResult.OK)
            {
                lbTeams.Items.Add(input.createdTeam);
            }
        }

        public void resetLeftMenu()
        {
            lbGames.SelectedItems.Clear();
            numericUpDown1.Value = 1.0M;
            numericUpDown2.Value = 1.0M;
            numericUpDown3.Value = 1.0M;
            maskedTextBox.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(lbTeams.SelectedItems.Count == 2 && maskedTextBox.Text.Length == 4)
            {
                Team home = lbTeams.SelectedItems[0] as Team;
                Team away = lbTeams.SelectedItems[1] as Team;
                decimal coef1 = numericUpDown1.Value;
                decimal coefX = numericUpDown2.Value;
                decimal coef2 = numericUpDown3.Value;
                string code = maskedTextBox.Text;

                Game game = new Game(home, away, code, coef1, coefX, coef2);
                lbGames.Items.Add(game);

                resetLeftMenu();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Object itemToSelect = null;
            lbGames.SelectedItems.Clear();
            string searchCode = textBoxSifraSearch.Text;
            foreach (var item in  lbGames.Items)
            {
                Game game = item as Game;
                if(game.Code.Equals(searchCode))
                {
                    itemToSelect = item;
                }
            }

            if(itemToSelect != null)
            {
                lbGames.SelectedItem = itemToSelect;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (lbGames.SelectedIndex != -1 && cbTip.SelectedIndex !=-1)
            {
                Game game = lbGames.SelectedItem as Game;
                string tip = cbTip.Text;
                lbTickets.Items.Add(new GameForTicket(game, tip));

                textBoxSifraSearch.Clear();
                cbTip.SelectedIndex = -1;
                lbGames.ClearSelected();

                recalculateTicket();
            }
        }

        private void nudPayment_ValueChanged(object sender, EventArgs e)
        {
            recalculateTicket();
        }
    }
}
