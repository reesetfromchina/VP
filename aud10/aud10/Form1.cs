using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aud10
{
    public partial class Form1 : Form
    {
        Scene scene;
        int timerTicks = 0;
        Random random = new Random();
        public Form1()
        {

            InitializeComponent();
            scene = new Scene(this.Width);

            timer1.Start();
            this.DoubleBuffered = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            scene.Move();
            if(timerTicks % 7 == 0)
            {
                scene.AddBall(new Ball(new Point(-Ball.Radius,random.Next(2*Ball.Radius, this.Height - 2*Ball.Radius)), random.Next(3)));
            }
            ++timerTicks;
            updateStatusStripLabel();            
            Invalidate();

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            scene.Draw(e.Graphics);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            scene.Click(e.Location);
            updateStatusStripLabel();
            Invalidate();
        }

        private void updateStatusStripLabel()
        {
            toolStripStatusLabel1.Text = $"Hits: {scene.Hits} Misses: {scene.Misses}";
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            scene.Width = this.Width;
        }
    }
}
