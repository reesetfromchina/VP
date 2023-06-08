using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlidingBalls
{
    [Serializable]
    public class Balls
    {
        public Point Point { get; set; }
        public int Radius { get; set; } = 30;
        public Color Color { get; set; }

        protected Balls(Point point)
        {
            Point = point;
        }


        public void Draw(Graphics g)
        {
            Brush b = new SolidBrush(Color);
            g.FillEllipse(b, Point.X - Radius, Point.Y - Radius, Radius*2, Radius*2);
            b.Dispose();
        }

        
    }
}
