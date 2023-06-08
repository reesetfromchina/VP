using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticking_Piess
{
    public partial class Form1 : Form
    {
        Scene scene;
        Color color=Color.Green;
        public Form1()
        {
            InitializeComponent();
            scene = new Scene();
            DoubleBuffered = true;
            toolStripStatusLabel1.Text = "Balls: 0";
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();

            if(cd.ShowDialog() == DialogResult.OK)
            {
                //TODO
                color = cd.Color;
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            scene.AddCircle(new Circle(e.Location, color));
            toolStripStatusLabel1.Text = $"Balls: {scene.Circles.Count.ToString()}";

            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            scene.Draw(e.Graphics);
            


        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scene = new Scene();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            scene.Tick();
            toolStripStatusLabel1.Text = $"Balls: {scene.Circles.Count.ToString()}";
            Invalidate();
        }

        private void startTimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
