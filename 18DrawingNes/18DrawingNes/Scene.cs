using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18DrawingNes
{
    [Serializable]
    public class Scene
    {
        public List<Polygon> Polygons { get; set; } = new List<Polygon>();
        public Polygon CurrentPolygon { get; set; } = new Polygon();
        internal void addPoint(Point location)
        {
            // TODO make for multiple polygons
            CurrentPolygon.AddPoint(location);
            if (CurrentPolygon.IsClosed)
            {
                Polygons.Add(CurrentPolygon);
                CurrentPolygon = new Polygon(); 
            }

        }

        internal void Draw(Graphics graphics)
        {
            foreach (Polygon polygon in Polygons)
            {
                polygon.Draw(graphics);
            }
            CurrentPolygon.Draw(graphics);
        }

        internal void UpdateCursor(Point location)
        {
            CurrentPolygon.MoveCursor(location);
        }
    }
}
