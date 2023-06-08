using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2DKovaaks
{
    public partial class Form1 : Form
    {   
        Scene scene;
        int Points = 0;
        Random random;
        public Form1()
        {

            scene = new Scene();
            InitializeComponent();
            random = new Random();
            DoubleBuffered = true;
            timer1.Start();
            timer2.Start();

            toolStripStatusLabel1.Text = $"Points: {Points}";
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            scene.Draw(e.Graphics);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            Ball b = new Ball(new Point(random.Next(Width), random.Next(Height)));

            scene.AddBall(b);
            Invalidate();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
           
            for(int i = scene.Balls.Count - 1; i >= 0; i--)
            {
                if (!scene.Balls[i].Clicked)
                {
                    scene.Balls[i].Change();
                }



      
                if (scene.Balls[i].Clicked || scene.Balls[i].Radius < 5)
                {
                    
                    scene.Balls.RemoveAt(i);

                }
            }
            Invalidate();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {

                toolStripStatusLabel1.Text = $"Points: {Points}";

                foreach (Ball b in scene.Balls)
                {
                    if (b.isClicked(e.Location))
                    {
                        b.Clicked = true;
                        b.TurnBallRed();
                        label1.Text = "clicked";
                        Points += 5;

                        toolStripStatusLabel1.Text = $"Points: {Points}";
                    }
                }
            }

            if(e.Button == MouseButtons.Right)
            {
                label1.Text = "reset";
            }
        }
    }
}
