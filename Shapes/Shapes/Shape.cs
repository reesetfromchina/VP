using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class Shape
    {
        public bool IsSelected { get; set; } = false;
        public static double Distance(Point left, Point right)
        {
            return Math.Sqrt( Math.Pow(left.X - right.X,2) + Math.Pow(left.Y - right.Y,2));
        }
        public abstract void Draw(Graphics g);
        public abstract bool Hit(Point location);
        internal abstract void Pulse();

        public abstract void MoveLeft();
        public abstract void MoveRight();
        public abstract void MoveUp();
        public abstract void MoveDown();
    }
}
