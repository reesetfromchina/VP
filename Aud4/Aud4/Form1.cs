using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Aud4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAddCourseToAvalablelb_Click(object sender, EventArgs e)
        {
            if (tbCourse.Text.Length > 0)
            {
                lbAvalableCourse.Items.Add(tbCourse.Text);
                tbCourse.Text = "";
            }
        }

     

        private void btnPomestiDesno_Click(object sender, EventArgs e)
        {
            if (lbAvalableCourse.SelectedItems.Count > 0)
            {
                List<String> itemsToDelete = new List<String>();

                foreach (var item in lbAvalableCourse.SelectedItems)
                {
                    clbSelectedCourses.Items.Add(item);
                    itemsToDelete.Add(item.ToString());
                }

                itemsToDelete.ForEach(item => { lbAvalableCourse.Items.Remove(item); });
                

            }
        }

        private void btnMoveLeft_Click(object sender, EventArgs e)
        {
            List<string> itemsToDelete = new List<string>();
            if (clbSelectedCourses.CheckedItems.Count > 0)
            {

                foreach (var item in clbSelectedCourses.CheckedItems)
            {
                lbAvalableCourse.Items.Add(item);
                itemsToDelete.Add(item.ToString());
            }

            itemsToDelete.ForEach(item => { clbSelectedCourses.Items.Remove(item); });
            }

        }
    }
}
