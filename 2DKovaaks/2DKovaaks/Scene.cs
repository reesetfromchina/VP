using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DKovaaks
{
    public class Scene
    {
        public List<Ball> Balls { get; set; }

        public Scene()
        {
            Balls = new List<Ball>();
        }

        public void AddBall(Ball ball)
        {
            Balls.Add(ball);
        }

        public void Draw(Graphics g)
        {
            foreach (Ball b in Balls)
            {
                b.Draw(g);
            }
        }



        public void Change()
        {
            foreach (Ball b in Balls)
            {
                b.Change();
            }


        }
    }
}
