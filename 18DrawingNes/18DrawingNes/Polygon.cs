using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18DrawingNes
{
    [Serializable]
    public class Polygon
    {
        public List<Point> Points { get; set; }
        public bool IsClosed { get; set; } = false;
        public bool CloseToStart { get; set; } = false;
        public Point Cursor { get; set; }

        public Polygon()
        {
            Points = new List<Point>();
        }

        public void AddPoint(Point point)
        {
            if(CloseToStart)
            {
                Points.Add(Points[0]);
                IsClosed = true;
                CloseToStart = false;
            }
            else
            {
                Points.Add(point);

            }
        }

        public void MoveCursor(Point cursor)
        {
            if (Points.Count >= 3)
            {
                Point startPoint = Points[0];
                var distance = Math.Sqrt(Math.Pow(startPoint.X - cursor.X, 2) + Math.Pow(startPoint.Y - cursor.Y, 2));

                CloseToStart = (distance < 5);
            }

            Cursor = cursor;
        }

        public void Draw(Graphics graphics)
        {
            Pen pen = new Pen(Color.Red, 5);
            if(Points.Count > 1)
            {
                graphics.DrawLines(pen, Points.ToArray());

            }

            if (CloseToStart)
            {
                Point startPoint = Points[0];
                graphics.DrawEllipse(pen, startPoint.X - 5, startPoint.Y - 5, 10,10);

            }


            //pen.Dispose();

            pen = new Pen(Color.DarkSlateGray, 5);
            pen.DashStyle = (DashStyle.Dot);

            if(Points.Count > 0)
            {
                graphics.DrawLine(pen, Points[Points.Count - 1], Cursor);

            }
            pen.Dispose();

            if (IsClosed && Points.Count > 1)
            {
                Brush b = new SolidBrush(Color.Red);
                graphics.FillPolygon(b, Points.ToArray());
            }
        }
    }
}
