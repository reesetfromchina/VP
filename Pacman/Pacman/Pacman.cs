using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Pacman.Pacman;

namespace Pacman
{
    public class Pacman
    {
        public enum DIRECTION { LEFT, UP, RIGHT, DOWN }

        public float XPosition { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public const int RADIUS = 20;


        private DIRECTION direction;
        public Brush brush {get; set; }
        public int velocity {get; set; }
        public  bool isMouthOpen { get; set; }

       
        public Brush Brush { get; set; } = new SolidBrush(Color.Yellow);

        public Pacman()
        {
            //Speed = Radius;
            //Position = new Point(7,5);
            //Direction = "right";

            x = 7 * RADIUS;
            y = 5 * RADIUS;
            direction = DIRECTION.RIGHT;
            velocity = RADIUS;
            isMouthOpen = false;
            brush = new SolidBrush(Color.Yellow);
        }


        public void ChangeDirection(DIRECTION newDirection)
        {
            direction = newDirection;
        }
        //        Во овој метод се придвижува херојот според насоката се со додавање/одземање 1 на X или Y компонентата од позицијата на херојот.
        //     Ако излезе од граници се поставува циркуларно на почетната позиција од спротивната страна
        //            (пр.доколку десната граница е 15, кога Y ќе ја надмине оваа граница се поставува на 1 односно на левата граница).
        //    Исто така при секое едно придвижување се менува состојбата на устата на херојот во отворена, односно затворена.
        public void Move(int worldWidth, int worldHeight)
        {
            isMouthOpen = !isMouthOpen;
            switch (direction)
            {
                case DIRECTION.LEFT:
                    x -= velocity;
                    if (x < 0) x = worldWidth * RADIUS * 2;
                    break;
                case DIRECTION.UP:
                    y -= velocity;
                    if (y < 0) y = worldHeight * RADIUS * 2;
                    break;
                case DIRECTION.RIGHT:
                    x += velocity;
                    if (x > worldWidth * RADIUS * 2) x = 0;
                    break;
                case DIRECTION.DOWN:
                    y += velocity;
                    if (y > worldHeight * RADIUS * 2) y = 0;
                    break;
            }
        }

        //TODO GRANICA

        public void Draw(Graphics g)
        {

            if (isMouthOpen)
            {
                g.FillPie(brush, x - RADIUS, y - RADIUS, RADIUS * 2, RADIUS * 2, (int)direction * 90 + 30, 300);
            }
            else
            {
                g.FillEllipse(brush, x - RADIUS, y - RADIUS, RADIUS * 2, RADIUS * 2);
            }
        }
    }
  

  }
    

