namespace Aud_3_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lbStrings.SelectedIndex != -1)
            {
                String value = lbStrings.SelectedItem as String;
                clbStrings.Items.Add(value);
                lbStrings.Items.Remove(value);
            }
        }

        private void btnAddString_Click(object sender, EventArgs e)
        {
            if (inputTextBox.Text != "")
            {
                bool found = false;
                foreach (string s in lbStrings.Items)
                {
                    if (s.Equals(inputTextBox.Text))
                    {
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    lbStrings.Items.Add(inputTextBox.Text);
                    inputTextBox.Clear();
                }
            }
        }

        private void inputTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}