using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlidingBalls
{
    [Serializable]
    public class RedBall : Balls
    {
        public bool Moving { get; set; } = false;
        public bool Clicked { get; set; }
        Random random = new Random();
        public int direction { get; set; }
        public RedBall(Point point) : base(point)
        {
            Point = point;
        }


        public void Draw(Graphics g)
        {
            Brush b = new SolidBrush(Color.Red);
            g.FillEllipse(b, Point.X - Radius, Point.Y - Radius, Radius * 2, Radius * 2);
            b.Dispose();
        }


        public bool CalculateDistance(Point p)
        {
            double distance = Math.Sqrt(Math.Pow(p.X - Point.X, 2) + Math.Pow(p.Y - Point.Y, 2));
            return distance <= Radius;
        }
        //crveno ako udri zeleno zelenoto isceznuva

        public void Move()
        {
           if (direction == 0)
            {
                Point = new Point(Point.X + 10, Point.Y);

            }
            else if (direction == 1)
            {
                Point = new Point(Point.X - 10, Point.Y);
            }
            else if (direction == 2)
            {
                Point = new Point(Point.X, Point.Y + 10);

            }
            else if (direction == 3)
            {
                Point = new Point(Point.X, Point.Y - 10);

            }
        }
    }
}

