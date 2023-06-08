using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Agario
{
    [Serializable]
    public class Ball
    {
        public static readonly int RADIUS_RED_BALLS = 15;
        public int RADIUS_PLAYER = 25;
        public Point Center { get; set; }

        public Ball(Point center)
        {
            Center = center;
        }


        public void Draw(Graphics g)
        {
            Brush redBrush = new SolidBrush(Color.Red);
            g.FillEllipse(redBrush, Center.X - RADIUS_RED_BALLS, Center.Y - RADIUS_RED_BALLS, RADIUS_RED_BALLS * 2, RADIUS_RED_BALLS * 2);

            redBrush.Dispose();
        }

        public void DrawPlayer(Graphics g)
        {
            Brush BlackBrush = new SolidBrush(Color.Black);
            g.FillEllipse(BlackBrush, Center.X - RADIUS_PLAYER, Center.Y - RADIUS_PLAYER, RADIUS_PLAYER * 2, RADIUS_PLAYER* 2);

            BlackBrush.Dispose();
        }

        public void MoveDirection(string direction)
        {
            if (direction == "up")
            {
                Center = new Point(Center.X, Center.Y - 15);
            }
            else if (direction == "down")
            {
                Center = new Point(Center.X, Center.Y + 15);
            }
            else if (direction == "right")
            {
                Center = new Point(Center.X + 15, Center.Y);

            }
            else
            {
                Center = new Point(Center.X - 15, Center.Y);
            }
        }

        public bool hitXPositive { get; set; } = false;
        public bool hitYPositive { get; set; } = false;
        public bool hitY { get; set; } = false;
        public void Move()
        {

            if (hitXPositive)
            {
                MoveDirection("left");
                if (Center.X < 0)
                {
                    hitXPositive = false;
                }
            }
            else
            {
                MoveDirection("right");
                if (Center.X > 800)
                {
                    hitXPositive = true;
                }

            }

            if (hitYPositive)
            {
                MoveDirection("up");
                if (Center.Y < 0)
                {
                    hitYPositive = false;
                }

            }
            else
            {

                MoveDirection("down");
                if (Center.Y > 460)
                {
                    hitYPositive = true;
                }


            }
        }

        public void PlayerMove(int x, int y)
        {
            Center = new Point(x, y);
        }
    }


}
