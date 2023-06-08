using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallsInHolesI
{
    public partial class Form1 : Form
    {
        BallsDoc ballsDoc;
        Color currentColor;
        Timer timer;
        int leftX;
        int topY;
        int width;
        int height;

        private string FileName;
        public Form1()
        {
            InitializeComponent();
            ballsDoc = new BallsDoc();
            currentColor = Color.Green;
            this.DoubleBuffered = true;
            timer = new Timer();
            timer.Interval = 50;
            //DeviceDpi TIMER TICK TIMER NEW EVENT HANDLER
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
            leftX = 20;
            topY = 60;
            width = this.Width - (3 * leftX);
            height = this.Height - (int)(2.5 * topY);
            ballsDoc.GenerateHoles(leftX, topY, width, height);
        }

        void timer_Tick(object sender, EventArgs e)
        {
            ballsDoc.MoveBalls(leftX, topY, width, height);
            ballsDoc.CheckCollision();
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.Aqua);
            Pen pen = new Pen(Color.Black, 4);
            e.Graphics.DrawRectangle(pen, leftX, topY, width, height);
            pen.Dispose();
            ballsDoc.Draw(e.Graphics);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            width = this.Width - (3 * leftX);
            height = this.Height - (int)(2.5 * topY);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            ballsDoc.AddBall(new Ball(e.Location, currentColor));
            Invalidate();
        }
    }
}
