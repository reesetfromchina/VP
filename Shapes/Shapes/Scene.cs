using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Scene
    {
        public List<Shape> Shapes { get; set; } = new List<Shape>();

        public void DrawShape(Graphics g)
        {
            foreach(Shape  s in  Shapes)
            {
                s.Draw(g);
            }
        }

        public void AddShape(Shape s)
        {
            Shapes.Add(s);
        }

        public bool Hit(Point location)
        {
            foreach (Shape s in Shapes)
            {
                if (s.Hit(location))
                {
                    return true;
                }
            }
            return false;
        }

        internal void Pulse()
        {
            foreach(Shape shape in Shapes)
            {
                shape.Pulse();
            }
        }

        internal void MoveUp()
        {
            foreach(Shape shape in Shapes)
            {
                shape.MoveUp();
            }
        }

        internal void MoveDown()
        {
            foreach (Shape shape in Shapes)
            {
                shape.MoveDown();
            }
        }

        internal void MoveLeft()
        {
            foreach (Shape shape in Shapes)
            {
                shape.MoveLeft();
            }
           
        }

        internal void MoveRight()
        {
            foreach (Shape shape in Shapes)
            {
                shape.MoveRight();
            }
        }
    }
}
