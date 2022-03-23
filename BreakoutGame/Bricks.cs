using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BreakoutGame
{
    class Bricks
    {
        /// <summary>
        /// Your Brick class must have following attributes 
        /// Add more attributes if required 
        /// </summary>
        private PictureBox[,] bricks;
        private int rows;
        private int cols;

        public Bricks(int rows, int cols)
        {
            this.rows = rows;
            this.cols = cols;
            bricks = new PictureBox[rows, cols];
        }

        //Add methods
        public void DrawBricks(Form form)
        {
            Random rand = new Random();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    bricks[i, j] = new PictureBox();
                    bricks[i, j].Height = 28;
                    bricks[i, j].Width = 80;
                    bricks[i, j].Location = new Point(i * 100 + 20, j * 50 + 20);
                    bricks[i, j].Visible = true;
                    bricks[i, j].BorderStyle = BorderStyle.FixedSingle;
                    bricks[i, j].BringToFront();
                    bricks[i, j].BackColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
                    bricks[i, j].Tag = "brick";
                    form.Controls.Add(bricks[i, j]);
                }
            }
        }

        public void ClearBricks(Form form)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    form.Controls.Remove(bricks[i, j]);
                }
            }
        }
    }
}
