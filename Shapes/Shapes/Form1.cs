using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shapes
{
    
    public partial class Form1 : Form
    {
        Scene scene;
        Random random;
        public Form1()
        {
            InitializeComponent();
            scene = new Scene();
            random = new Random();
            timer1.Start();
            DoubleBuffered = true;
        }


        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {

                if (!scene.Hit(e.Location))
                {
                    scene.AddShape(new Circle(e.Location, random.Next(20, 50), Color.Red));

                }
            }

            if(e.Button == MouseButtons.Right)
            {
                scene.AddShape(new Square(e.Location, random.Next(50, 50), Color.Red));
            }
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            scene.DrawShape(e.Graphics);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            scene.Pulse();
            Invalidate();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Up) 
            {
                scene.MoveUp();
            } else if(e.KeyCode == Keys.Down)
            {
                scene.MoveDown();
            }else if(e.KeyCode == Keys.Left)
            {
                scene.MoveLeft();
            }else if (e.KeyCode == Keys.Right)
            {
                scene.MoveRight();
            }
        }
    }
}
