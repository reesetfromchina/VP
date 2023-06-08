using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agario
{
    [Serializable]
    public class Scene
    {
        public List<Ball> Balls { get; set; }
        public Random random { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public bool Clicked { get; set; } = false;
        public bool Playing { get; set; } = false;

        public bool Paused { get; set; } = false;

        public Ball PlayerBall { get; set; } = new Ball(new Point(0, 0));


        public Scene()
        {
            Balls = new List<Ball>();
            random = new Random();
         

        }

        public void AddBall(Ball ball)
        {
            Balls.Add(ball);
            // Check if the ball position is within the bounds of the form
            if (ball.Center.X < 0 || ball.Center.X > Width || ball.Center.Y < 0 || ball.Center.Y > Height)
            {
                // Adjust the ball position to be within the bounds of the form
                ball.Center = new Point(random.Next(Width), random.Next(Height));
            }

            Balls.Add(ball);

        }

        public void Draw(Graphics g)
        {
            foreach (Ball b in Balls)
            {
                b.Draw(g);
            }


        }


        public void DrawPlayer(Graphics g)
        {
            if (Playing)
            {
               

                PlayerBall.DrawPlayer(g);

            }
        }

        public void generateRandomBall(int height, int widht)
        {
            if (!Paused)
            {
                int randomX = random.Next(0, height);
                int randomY = random.Next(0, widht);

                AddBall(new Ball(new Point(randomX, randomY)));
            }


        }

        public void Move()
        {
            if (!Paused)
            {
                foreach (Ball b in Balls)
                {
                    b.Move();
                }
            }
            if (Playing)
            {

                if (Balls.Count > 0)
                {
                    for (int i = 0; i < Balls.Count; i++)
                    {
                        if (CircleCollision(Balls[i].Center, 15, PlayerBall.Center, PlayerBall.RADIUS_PLAYER))
                        {
                            Balls.RemoveAt(i);
                            PlayerBall.RADIUS_PLAYER += 5;
                            if (PlayerBall.RADIUS_PLAYER > 70)
                            {
                                Playing = !Playing;
                                PlayerBall.RADIUS_PLAYER = 25;
                            }
                        }
                    }
                }
            }  
    }
           


        

        public static bool CircleCollision(Point center1, int radius1, Point center2, int radius2)
        {
            int dx = center2.X - center1.X;
            int dy = center2.Y - center1.Y;

            int distanceSquared = (dx * dx) + (dy * dy);
            int radiusSum = radius1 + radius2;

            return distanceSquared <= (radiusSum * radiusSum);
        }



    }
}
