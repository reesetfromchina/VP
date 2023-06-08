﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallsInHolesI
{
    [Serializable]
    public class Hole
    {
        public static readonly int RADIUS = 30;
        public Point Center{ get; set; }

        public int Count { get; set; }

        public Hole(Point center)
        {
            Center = center;
            Count = 0;
        }

        public void Draw(Graphics g, Font font)
        {
            Brush b = new SolidBrush(Color.Bisque);
            Brush fb = new SolidBrush(Color.Magenta);
            g.FillEllipse(b, Center.X - RADIUS, Center.Y - RADIUS, RADIUS * 2, RADIUS * 2);
            g.DrawString(string.Format("{0}", Count), font, fb, Center.X-10, Center.Y-10);
            b.Dispose();
            fb.Dispose();
        }

        public bool Touches(int x, int y)
        {
            return (x-Center.X) * (x-Center.X) + (y -Center.Y) * (y-Center.Y) <= RADIUS * RADIUS;
        }
    }


}
