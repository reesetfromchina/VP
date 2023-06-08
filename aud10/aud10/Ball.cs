using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace aud10
{
    public class Ball
    {
        public Point Center { get; set; }
        //0 crveno, 1 zolto, 2 zeleno, 3 za prisenje, -1 izleglo od prostor
        public int Status { get; set; }

        public static int Radius { get; set; } = 20;

        public Ball(Point center, int status)
        {
            Center = center;
            Status = status;
        }


        public void Draw(Graphics g)
        {
            Brush b;
            switch (Status)
            {
                case 0: b = new SolidBrush(Color.Red); break;
                case 1: b = new SolidBrush(Color.Yellow); break;
                default: b = new SolidBrush(Color.Green); break;
            }


            g.FillEllipse(b, Center.X - Radius, Center.Y - Radius, 2 * Radius, 2 * Radius);
            b.Dispose();

        }

        public bool IsHit(Point point)
        {
            bool result = Math.Sqrt(Math.Pow(Center.X - point.X, 2) + Math.Pow(Center.Y - point.Y, 2)) <= Radius;
            if(result)
            {
                ++Status;
                if (Status != 3)
                {
                    result = false;
                }
            }

           

            return result;
        }

        public void Move()
        {
            Center = new Point(Center.X + 10, Center.Y);
            
        }
    }
}
