using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DCZadaca
{
    public class Ball
    {
        public int Radius { get; set; }
        public Random Random { get; set; } = new Random();
        public Point Point { get; set; }
        public int Directoin { get; set; }

        public Ball(Point point)
        {
            Point = point;
            Radius = Random.Next(20, 40);
            Directoin = Random.Next(2);
        }

        public void Draw(Graphics g)
        {
            Brush b = new SolidBrush(Color.Red);

            g.FillEllipse(b, Point.X - Radius, Point.Y - Radius, Radius *2, Radius *2);


            b.Dispose();
        }

        bool moveRightFlag=true;
        bool moveUpFlag=true;
        public void Move(int width, int height)
        {
            if(Directoin == 0)
            {
                    if(moveRightFlag)
                {
                    Point = new Point(Point.X + 10, Point.Y);
                    if (Point.X > width- 30)
                    {
                        Point = new Point(Point.X - 10, Point.Y);
                        moveRightFlag = false;
                    }
                }
                else
                {
                    Point = new Point(Point.X - 10, Point.Y);
                    if(Point.X < 30)
                    {
                        moveRightFlag=true;
                    }
                }
                
              
            }
            else
            {
                //Point = new Point(Point.X, Point.Y - 10);

                if (moveUpFlag)
                {
                    Point = new Point(Point.X, Point.Y - 10);
                    if (Point.Y < 30)
                    {
                        Point = new Point(Point.X, Point.Y-10);
                        moveUpFlag = false;
                    }
                }
                else
                {
                    Point = new Point(Point.X, Point.Y+10);
                    if (Point.Y > height - 30)
                    {
                        moveUpFlag = true;
                    }
                }
            }
        }

        public bool Collision(Ball b)
        {
            double distance = Math.Sqrt(Math.Pow(b.Point.X - Point.X, 2) + Math.Pow(b.Point.Y - Point.Y, 2));
            return distance <= b.Radius + Radius;
        }

        public void MoveUp()
        {
            if (moveUpFlag) {

            }
        }
    }
}
