﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallsInHolesI
{
    public class BallsDoc
    {
        public List<Ball> Balls { get; set; }
        public List<Hole> Holes { get; set; }
        Random random;
        Font font;

        public BallsDoc()
        {
            Balls = new List<Ball>();
            Holes = new List<Hole>();
            font = new Font("Arial", 20);
            random = new Random(); 
        }

        public void GenerateHoles(int left, int top, int widht, int height)
        {
            Holes = new List<Hole>();
            GenerateHolesR(left, top, widht, height);
        }

        private void GenerateHolesR(int left, int top, int widht, int height)
        {
            if(Holes.Count == 5)
            {
                return;
            }
            int x = random.Next(left + Hole.RADIUS, (left+widht) - Hole.RADIUS);
            int y = random.Next(top + Hole.RADIUS, (top + height) - Hole.RADIUS);
            bool touches = false;
            foreach(Hole h in Holes)
            {
                touches = h.Touches(x, y);
                if (touches) break;
            }
            if (!touches)
            {
                Hole h = new Hole(new Point(x,y));
                Holes.Add(h);
            }
            GenerateHolesR(left, top, widht, height);
        }

        public void Draw(Graphics g)
        {
            foreach(Hole h in Holes)
            {
                h.Draw(g, font);
            }
            foreach(Ball ball in Balls)
            {
                ball.Draw(g);
            }
        }

        public void AddBall(Ball ball)
        {
            Balls.Add(ball);
        }

        public void MoveBalls(int left, int top, int widht, int height)
        {
            foreach (Ball ball in Balls)
            {
                ball.Move(left, top, widht, height);
            }
        }

        public void CheckCollision()
        {
            for(int i = 0; i < Balls.Count; i++)
            {
                for(int j = 0; j < Holes.Count; j++)
                {
                    if (Balls[i].InHole(Holes[j]))
                    {
                        Balls[i].IsInHole = true;
                        Holes[j].Count++;
                    }
                }
            }
            for(int i = Balls.Count - 1; i>=0; i--)
            {
                if (Balls[i].IsInHole)
                {
                    Balls.RemoveAt(i);
                }
            }
        }
    }
}
