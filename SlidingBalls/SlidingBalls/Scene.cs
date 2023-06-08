using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlidingBalls
{
    [Serializable]
    public class Scene
    {
        public List<BlueOrGreen> BlueOrGreen { get; set; }
        public List<RedBall> RedBalls { get; set; }
        public Scene()
        {
            BlueOrGreen = new List<BlueOrGreen>();
            RedBalls = new List<RedBall>();
        }


        public void AddBlueOrGreen(BlueOrGreen blueOrGreen)
        {
            BlueOrGreen.Add(blueOrGreen);
        }

        public void Draw(Graphics g)
        {
            foreach (var blueOrGreen in BlueOrGreen) { blueOrGreen.Draw(g); }
        }


        public void AddRed(RedBall redBall)
        {
            RedBalls.Add(redBall);
        }

        public void DrawRed(Graphics g)
        {
            foreach(RedBall r in RedBalls)
            {
                r.Draw(g);
            }
        }


        public void MoveRed()
        {
            foreach (RedBall rb in RedBalls)
            {
                if (rb.Clicked)
                {
                    rb.Move();
                }
            }
        }
    }
}
