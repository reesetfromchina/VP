using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace India
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblHello.Text = "Hello World!";
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            lblHello.Text = "Change the text";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            lblHello.Text = "Text has been canceled :D";
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
