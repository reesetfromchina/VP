using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DCZadaca
{
    public partial class Form1 : Form
    {
        Scene scene;
        public Form1()
        {
            InitializeComponent();

            scene = new Scene();
            DoubleBuffered = true;
            timer1.Start();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            scene.Draw(e.Graphics);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Ball b = new Ball(e.Location);

            scene.AddBall(b);
            Invalidate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            scene.Move(this.Width, this.Height);
            scene.collision();
            Invalidate();
        }
    }
}
