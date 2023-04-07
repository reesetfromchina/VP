﻿using System;
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
    public partial class TeamForm : Form
    {
        public Team createdTeam { get; set; }
        public TeamForm()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if(tbName.Text.Length > 0 && tbCountry.Text.Length > 0)
            {
                createdTeam =  new Team(tbName.Text, tbCountry.Text);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
            }

        }

        private void bntClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
