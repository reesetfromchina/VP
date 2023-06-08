using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DKovaaks
{
    public class Ball
    {
        public Point Point { get; set; }
        public int Radius { get; set; } = 50;
        public Color Color { get; set; }
        public Random Random { get; set; } = new Random();
        public bool Clicked { get; set; } = false;

        public Ball(Point point)
        {
            Point = point;
            Color = generateRandomColor();
        }


        public void Draw(Graphics g) 
        {
            Brush brush = new SolidBrush(Color);
            g.FillEllipse(brush, Point.X - Radius, Point.Y - Radius, Radius*2, Radius *2);
            brush.Dispose();
        }

        public void Change()
        {
            Radius -= 10;
            Color = generateRandomColor();
        }

        private Color generateRandomColor()
        {
            int color = Random.Next(0, 3);
            if(color == 0)
            {
                return Color.Green;
            }else if(color == 1)
            {
                return Color.Blue;
            }else 
            {
                return Color.Yellow;
            }
        }

        public bool isClicked(Point point)
        {
            double distance = Math.Sqrt(Math.Pow(Point.X - point.X, 2) + Math.Pow(Point.Y - point.Y,2));
            return distance <= Radius;
        }


        public void TurnBallRed()
        {
            Color = Color.Red;
        }
    }
}
