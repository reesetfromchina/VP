using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlidingBalls
{
    [Serializable]
    public partial class Form1 : Form
    {
        Scene scene;
        Random random;
        Random randomDirection;
        public bool Selected { get; set; } = false;

        public Form1()
        {
            InitializeComponent();
            scene = new Scene();
            DoubleBuffered = true;
            random = new Random();
            randomDirection = new Random();
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            scene.AddBlueOrGreen(new BlueOrGreen(e.Location, random.Next(2)));
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            scene.Draw(e.Graphics);
            scene.DrawRed(e.Graphics);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right) 
            {
                RedBall redBall = new RedBall(e.Location);
                redBall.direction=random.Next(0,3);
                scene.AddRed(redBall);
                Invalidate();
            }

            if(e.Button == MouseButtons.Left)
            {
                    foreach (RedBall b in scene.RedBalls)
                    {
                        if (b.CalculateDistance(e.Location) && !Selected)
                        {
                            //label1.Text = "CLICKED";
                            b.Clicked = true;
                            timer1.Start();
                            Selected= true; 
                        }
                }
   
            }
            Invalidate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
                if(scene.RedBalls.Count > 0)
            {

                for (int i = scene.RedBalls.Count - 1; i >= 0; i--)
                {
                //label2.Text = $"Size of RedBalls {scene.RedBalls.Count}\nIndex{i}";

                    if (scene.RedBalls[i].Clicked)
                    {
                        scene.RedBalls[i].Move();
                        for (int j = 0; j < scene.BlueOrGreen.Count; j++)
                        {
                            BlueOrGreen blueorGreen = scene.BlueOrGreen[j];
                            if (scene.RedBalls[i].CalculateDistance(blueorGreen.Point))
                            {
                                if (blueorGreen.Number == 0)
                                {
                                    scene.BlueOrGreen.RemoveAt(j);
                                }
                            }
                        }
                        
                        if (CheckBoundary(scene.RedBalls[i].Point))
                        {
                            Selected = false;
                            label2.Text = $"X:{scene.RedBalls[i].Point.X} Y:{this.Width} {Selected.ToString()}";
                            scene.RedBalls.RemoveAt(i);
                        }
                    }

                }
                toolStripStatusLabel1.Text = $"Active dve tocki {scene.BlueOrGreen.Count + scene.RedBalls.Count}";
            }

            Invalidate();
        }

        private bool CheckBoundary(Point p)
        {
            return (p.X < 0 || p.X > this.Width || p.Y > Height || p.Y < 0);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void SaveScene(string path)
        {
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, scene);
            fs.Close();
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                SaveScene(saveFileDialog.FileName);
            }
        }

        private void OpenScene(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Open);
            IFormatter formatter = new BinaryFormatter();
            scene = (Scene)formatter.Deserialize(fs);
            fs.Close();
        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                OpenScene(openFileDialog.FileName);
            }
        }
    }
}
