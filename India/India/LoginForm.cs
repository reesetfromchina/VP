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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string ID = txtUserID.Text;
            string password = txtPassword.Text;


            if(ID == "i25" && password == "123")
            {
                Form1 f = new Form1();
                f.Show();
            } else
            {
                MessageBox.Show("Ne e uspesno");
            }
        }
    }
}
