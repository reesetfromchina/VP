using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallsInHolesI
{
    public class Ball
    {
        public int Radius { get; set; } = 25;
        public Point Center { get; set; }
        public Color Color { get; set; }
        public bool IsInHole { get; set; }
        public double Velocity { get; set; }
        public double Angle { get; set; }
        private float velocityX;
        private float velocityY;

        public Ball(Point center, Color color)
        {
            Center = center;
            Color = color;
            IsInHole = false;
             //10 pixels to move 
            Velocity = 10;
            Random r = new Random();
            Angle = r.NextDouble() * 2 * Math.PI;
            velocityX = (float)(Math.Cos(Angle) * Velocity);
            velocityY = (float)(Math.Cos(Angle) * Velocity);
        }

        public void Draw(Graphics g)
        {
            Brush b = new SolidBrush(Color);
            g.FillEllipse(b, Center.X - Radius, Center.Y - Radius,Radius *2, Radius *2);
            b.Dispose();
        }

        public void Move(int left, int top, int width, int height)
        {
            int nextX = (int)(Center.X + velocityX);
            int nextY = (int)(Center.Y + velocityY);
            int lft = left + Radius;
            int rgt = left + width - Radius;
            int tp = top + Radius;
            int btm = top + height - Radius;

            if(nextX <= lft)
            {
                nextX = lft + (lft - nextX);
                velocityX = -velocityX;
            }
            if(nextX >= rgt)
            {
                nextX = rgt - (nextX - rgt);
                velocityX = -velocityX;
            }
            if (nextY <= tp)
            {
                nextY = tp + (tp - nextY);
            }
            if(nextY >= btm)
            {
                nextY = btm - (nextY - btm);
                velocityY = -velocityY;
            }
            Center = new Point(nextX, nextY);
          
        }

        public bool InHole(Hole hole)
        {
            float d = (Center.X - hole.Center.X) * (Center.X - hole.Center.X) +
                (Center.Y - hole.Center.Y) * (Center.Y - hole.Center.Y);
            return d <= Radius * Radius;
        }
    }




}
