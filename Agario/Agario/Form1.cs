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

namespace Agario
{
    public partial class Form1 : Form
    {
        Scene scene;
        //Random random;
        public bool Playing { get; set; } = false;
        public Form1()
        {
            InitializeComponent();
            scene = new Scene();
            timer1.Start();
            Height = this.Height;
            Width = this.Width;
            


            scene.Height = Height;
            scene.Width = Width;

            //random = new Random();
            DoubleBuffered = true;
            timer2.Start();
            
            scene.AddBall(new Ball(new Point(scene.random.Next(Height), scene.random.Next(Width))));
            scene.AddBall(new Ball(new Point(scene.random.Next(Height), scene.random.Next(Width))));
            scene.AddBall(new Ball(new Point(scene.random.Next(Height), scene.random.Next(Width))));
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
          
           
            scene.Draw(e.Graphics);
            if (scene.Playing)
            {
                scene.PlayerBall.DrawPlayer(e.Graphics);
            }
          

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            scene.generateRandomBall(Height,Width);
            Invalidate();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            scene.Move();
           //# positionLabel.Text = scene.Balls[0].Center.X.ToString();
            Invalidate();
        }

    

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
          
                scene.PlayerBall.PlayerMove(e.X, e.Y);
              
            

            Invalidate();
            playing.Text = scene.Playing.ToString();


        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {

            scene.Playing= true;

           
        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ToolStripDropDownItemAccessibleObject TODO PAUSE 
            scene.Paused = !scene.Paused;
            if (scene.Paused)
            {
                pauseToolStripMenuItem.Text = "Старт";
            }
            else
            {
                pauseToolStripMenuItem.Text = "Пауза";
            }
        }


        private void SaveScene(string path)
        {
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
            
            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, scene);
            fs.Close();
        }

        private void OpenScene(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Open);
            IFormatter formatter = new BinaryFormatter();
            scene = (Scene) formatter.Deserialize(fs);
            fs.Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                SaveScene(saveFileDialog.FileName);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                OpenScene(openFileDialog.FileName);
            }
        }

        private void akciiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }


    
}
