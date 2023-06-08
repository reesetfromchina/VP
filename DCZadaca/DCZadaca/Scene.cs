using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DCZadaca
{
    public class Scene
    {
        public List<Ball> Balls { get; set; }

        public Scene()
        {
            Balls = new List<Ball>();
        }

        public void AddBall(Ball b)
        {
            Balls.Add(b);
        }


        public void Draw(Graphics g)
        {
            foreach (Ball b in Balls)
            {
                b.Draw(g);
            }
        }

        public void Move(int Width, int Height)
        {
            foreach(Ball b in Balls)
            {
                b.Move(Width,Height);
            }
        }

        public void collision()
        {
           for(int i =0; i < Balls.Count; i++)
            {
                for(int j = i+1; j < Balls.Count; j++)
                {
                    if (Balls[i].Collision(Balls[j]))
                    {
                        
                        Balls[i].Radius = (Balls[i].Radius + Balls[j].Radius)/2;
                        Balls[i].Point = new Point((Balls[i].Point.X + Balls[j].Point.X) / 2, (Balls[i].Point.Y + Balls[j].Point.Y) / 2);
                        Balls[i].Directoin = 1;
                        Balls.RemoveAt(j);

                    }
                }
            }
        }
    }
}
