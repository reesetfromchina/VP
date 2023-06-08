using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Ticking_Piess
{
    public class Circle
    {
        public int Radius { get; set; } = 25;
        public Point Point { get; set; }
        Color Color { get; set; }
        public int Tick { get; set; }

        public Circle(Point point, Color color)
        {
            Point = point;
            Color = color;
            Tick = 0;
        }


        public void Draw(Graphics g)
        {
            Brush b = new SolidBrush(Color);

            g.FillPie(b, Point.X - Radius, Point.Y - Radius, Radius * 2, Radius * 2, 0, (int)((4 - Tick) * 90));
            b.Dispose();
        }




    }
}
