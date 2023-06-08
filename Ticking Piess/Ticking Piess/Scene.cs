using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticking_Piess
{
    public class Scene
    {
        public List<Circle> Circles{ get; set; }
        public Scene() {
            Circles = new List<Circle>();
        }



        public void AddCircle(Circle circle)
        {
            Circles.Add(circle);
        }

        public void Draw(Graphics g)
        {
            foreach(Circle c in Circles)
            {
                c.Draw(g);
            }
        }


        public void Tick()
        {
            for (int i = Circles.Count - 1; i >= 0; i--)
            {
                Circles[i].Tick++;
                if (Circles[i].Tick == 4)
                {
                    Circles.RemoveAt(i);
                }
            }
        }
    }
}
