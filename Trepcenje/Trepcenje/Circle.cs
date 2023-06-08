using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trepcenje
{
    public class Circle
    {
        public int Radius { get; set; } = 25;
        public Point Point { get; set; }
        public Color PrimaryColor { get; set; }
        public Color SecondaryColor { get; set; }

        public Circle(Point point)
        {
            Point = point;
        }

        public void Draw(Graphics g)
        {
            Brush Primary = new SolidBrush(PrimaryColor);
            Brush Secondary = new SolidBrush(SecondaryColor);

            g.FillPie(Secondary, Point.X - Radius, Point.Y - Radius, Radius * 2, Radius * 2, 0, 180);
            g.FillPie(Primary, Point.X - Radius, Point.Y - Radius, Radius * 2, Radius * 2, 180, 180);
            Primary.Dispose();
            Secondary.Dispose();

        }

        public void Pulse()
        {
            Color temp = 
        }
    }
}
