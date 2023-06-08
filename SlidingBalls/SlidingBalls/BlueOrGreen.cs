using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlidingBalls
{
    [Serializable]
    public class BlueOrGreen : Balls
    {
        public int Number { get; set; }
        public BlueOrGreen(Point point, int number) : base(point)
        {
      
            Point = point;
            Number = number;
        }

        public void Draw(Graphics g)
        {
            if (Number == 1)
            {
                Brush b = new SolidBrush(Color.Blue);
                g.FillEllipse(b, Point.X - Radius, Point.Y - Radius, Radius * 2, Radius * 2);
                b.Dispose();
            }
            else
            {
                Brush b = new SolidBrush(Color.Green);
                g.FillEllipse(b, Point.X - Radius, Point.Y - Radius, Radius * 2, Radius * 2);
                b.Dispose();
            }

        }
    }
}
