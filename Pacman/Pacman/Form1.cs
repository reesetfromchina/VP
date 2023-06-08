using Pacman.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pacman
{
    public partial class Form1 : Form
    {
        Timer timer;
        Pacman pacman;
        static readonly int TIMER_INTERVAL = 250;
        static readonly int WORLD_WIDTH = 15;
        static readonly int WORLD_HEIGHT = 10;
        Image foodImage;
        bool[][] foodWorld;


        public Form1()
        {
            InitializeComponent();
            // Vcituvanje na slika od resursi
            foodImage = Resources.bk;
            DoubleBuffered = true;
            newGame();
        }

        private void newGame()
        {
            pacman = new Pacman();
            this.Width = Pacman.RADIUS * 2 * (WORLD_WIDTH + 1);
            this.Height = Pacman.RADIUS * 2 * (WORLD_HEIGHT + 1);

            // Inicijalizacija na foodWorld matricata
            foodWorld = new bool[WORLD_HEIGHT][];
            for (int i = 0; i < foodWorld.Length; i++)
            {
                foodWorld[i] = new bool[WORLD_WIDTH];
                for (int j = 0; j < foodWorld[i].Length; j++)
                {
                    foodWorld[i][j] = true;
                }
            }

            // Startuvanje na timer
            timer = new Timer();
            timer.Interval = TIMER_INTERVAL;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();

            // Dodavanje na KeyUp event
            this.KeyUp += new KeyEventHandler(Form1_KeyUp);
        }

        void timer_Tick(object sender, EventArgs e)
        {
            int pacmanX = pacman.x / Pacman.RADIUS / 2;
            int pacmanY = pacman.y / Pacman.RADIUS / 2;

            if (foodWorld[pacmanY][pacmanX])
            {
                foodWorld[pacmanY][pacmanX] = false;
            }

            pacman.Move(WORLD_WIDTH, WORLD_HEIGHT);
            Invalidate();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    pacman.ChangeDirection(Pacman.DIRECTION.LEFT);
                    break;
                case Keys.Up:
                    pacman.ChangeDirection(Pacman.DIRECTION.UP);
                    break;
                case Keys.Right:
                    pacman.ChangeDirection(Pacman.DIRECTION.RIGHT);
                    break;
                case Keys.Down:
                    pacman.ChangeDirection(Pacman.DIRECTION.DOWN);
                    break;
            }

            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);
            for (int i = 0; i < foodWorld.Length; i++)
            {
                for (int j = 0; j < foodWorld[i].Length; j++)
                {
                    if (foodWorld[i][j])
                    {
                        g.DrawImage(foodImage, j * Pacman.RADIUS * 2, i * Pacman.RADIUS * 2);
                    }
                }
            }
            pacman.Draw(g);
        }
    }
}
