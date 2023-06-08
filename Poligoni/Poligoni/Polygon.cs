using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Poligoni
{
    [Serializable]
    public class Polygon
    {
        public List<Point> Points { get; set; }
        public bool IsClosed { get; set; } = false;
        public bool CloseToStart { get; set; }=false;
        public Point Cursor { get; set; }

        public Polygon()
        {
            Points = new List<Point>();
        }


        public void AddPoint(Point p) 
        {

            if(CloseToStart)
            {
                Points.Add(Points[0]);
                IsClosed = true;
                CloseToStart = false;
            }
            else
            {
                Points.Add(p);

            }


        }


        public void Draw(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            if(Points.Count > 1)
            {
                g.DrawLines(pen, Points.ToArray());
            }
            if (CloseToStart)
            {
                Point startPoint = Points[0];
                g.DrawEllipse(pen, startPoint.X - 5, startPoint.Y - 5, 10, 10);
               
            }

            pen.Dispose();



            if(IsClosed && Points.Count > 1)
            {
                Brush brush = new SolidBrush(Color.Green);

                g.FillPolygon(brush, Points.ToArray());
            }

            if (Points.Count > 0)
            {
                float[] dashValues = { 5, 2, 15, 4 };
                //Pen blackPen = new Pen(Color.Black, 5);
                pen = new Pen(Color.YellowGreen);
                pen.DashStyle = DashStyle.DashDot;
                Point getLastPoint = Points[Points.Count - 1];
                g.DrawLine(pen, getLastPoint, Cursor);


            }
            pen.Dispose();



        }

        public void MoveCursor(Point cursor)
        {
            if (Points.Count >= 3)
            {
                Point startPoint = Points[0];
                var distance = Math.Sqrt(Math.Pow(startPoint.X - cursor.X, 2) + Math.Pow(startPoint.Y - cursor.Y, 2));
                CloseToStart = distance <= 5;
            }
           

            Cursor = cursor;
        }
    }
}
