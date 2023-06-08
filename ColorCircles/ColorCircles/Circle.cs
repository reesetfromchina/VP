using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ColorCircles
{
    [Serializable]
    public class Circle
    {
        public int Radius { get; set; }
        public Color Color { get; set; }
        public Point Point { get; set; }
        public bool IsSelected { get; set; }

        public Circle(Color color, Point circlePoint, int radius)
        {
            Color = color;
            Point = circlePoint;
            Radius = radius;
        }



        public void Draw(Graphics g)
        {
            Brush brush = new SolidBrush(Color);
            if(IsSelected)
            {
                Pen pen = new Pen(Brushes.Red, 5);
                g.DrawEllipse(pen, Point.X - Radius, Point.Y - Radius, Radius * 2, Radius * 2);
                pen.Dispose();
            }
            g.FillEllipse(brush, Point.X - Radius, Point.Y - Radius, Radius * 2, Radius * 2);
            brush.Dispose();
        }

        public static float Distance(Point p1, Point p2)
        {
            return (p1.X - p2.X) * (p1.X - p2.X) + (p1.Y - p2.Y) * (p1.Y - p2.Y);
        }

        public void Select(Point point)
        {
            if (Distance(point, Point) <= Radius * Radius)
            {
                IsSelected = !IsSelected;
            }
        }
    }
}
