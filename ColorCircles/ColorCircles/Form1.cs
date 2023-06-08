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

namespace ColorCircles
{
    [Serializable]
    public partial class Form1 : Form
    {
        private Color currentColor;
        Scene scene;
        private string FileName;
        private int radius;
        Point previousPoint=Point.Empty;
        Point currentPoint=Point.Empty;
        public Form1()
        {
            InitializeComponent();
            currentColor = Color.Green;
            scene = new Scene();
            DoubleBuffered=true;
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                currentColor = cd.Color;
            }
        }

        private void fiileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (previousPoint.IsEmpty)
                {
                    previousPoint = e.Location;
                }
                else
                {
                    scene.AddCircle(previousPoint, radius, currentColor);
                    previousPoint = Point.Empty;
                    currentPoint = Point.Empty;
                }
                Invalidate(true);
            }

            if(e.Button == MouseButtons.Right)
            {
                scene.Select(e.Location);
                Invalidate();
            }
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
            scene.Draw(e.Graphics);
            if (!previousPoint.IsEmpty)
            {
                Pen linePen = new Pen(Color.Black, 3);
                linePen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
                e.Graphics.DrawEllipse(linePen, previousPoint.X - radius, previousPoint.Y - radius, radius * 2, radius * 2);
                linePen.Dispose();
            }
            lblRadius.Text = "Radius: ";

            toolStripStatusLabel1.Text = $"Balls {scene.Circles.Count.ToString()}";


            Invalidate();


        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            currentPoint = e.Location;
            radius = (int)Math.Sqrt(Circle.Distance(currentPoint, previousPoint));
            Invalidate();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                previousPoint = Point.Empty;
            }
            if(e.KeyCode == Keys.Delete)
            {
                scene.DeleteSelected();
            }
            Invalidate();


        }
        private void SaveScene(string path)
        {
            
            //SaveFileDialog saveFileDialog = new SaveFileDialog();

            //saveFileDialog.Filter = "Circles doc file (*.clr)|*.clr";
            
            //if(saveFileDialog.ShowDialog() == DialogResult.OK)
            //{
            //    saveFileDialog.FileName = path;
            //}


            FileStream fs = new FileStream(path, FileMode.OpenOrCreate);

            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, scene);
            fs.Close();


        }


        private void OpenScene(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Open);
            IFormatter formatter = new BinaryFormatter();
            scene = (Scene)formatter.Deserialize(fs);
            fs.Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                SaveScene(saveFileDialog.FileName);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                OpenScene(openFileDialog.FileName);
            }
        }
    }
}
