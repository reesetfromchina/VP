using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poligoni
{
    [Serializable]
    public class Scene
    {
        public List<Polygon> Polygons { get; set; } = new List<Polygon>();
        public Polygon CurrentPolygon { get; set; } = new Polygon();

        public void AddPoint(Point location)
        {
            CurrentPolygon.AddPoint(location);
            if (CurrentPolygon.IsClosed)
            {
                Polygons.Add(CurrentPolygon);
                CurrentPolygon = new Polygon();
            }
        }

        public void UpdateCursor(Point location)
        {
            CurrentPolygon.MoveCursor(location);
        }

        public void Draw(Graphics graphics)
        {
            foreach (Polygon polygon in Polygons)
            {
                polygon.Draw(graphics);
            }
            CurrentPolygon.Draw(graphics);
        }
    }
}
