using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BreakoutGame
{
    class Ball
    {
        /// <summary>
        /// Your Ball class must have following attributes 
        /// Add more attributes if required 
        /// </summary>
        private PictureBox picBall;
        private int verticalSpeed, horizontalSpeed;

        public Ball(PictureBox picBall, int verticalSpeed, int horizontalSpeed, Color color)
        {
            this.picBall = picBall;
            this.verticalSpeed = verticalSpeed;
            this.horizontalSpeed = horizontalSpeed;
            picBall.BackColor = color;

            roundBall();
        }

        //Add methods
        private void roundBall()
        {
            GraphicsPath p = new GraphicsPath();
            p.AddEllipse(0, 0, picBall.Width, picBall.Height);
            picBall.Region = new Region(p);
        }

        public void move()
        {
            picBall.Top += verticalSpeed;
            picBall.Left += horizontalSpeed;
        }

        public void formCollision(Form form)
        {
            // collision with sides of the form
            if (picBall.Top < 0)
                verticalSpeed = -verticalSpeed;

            if (picBall.Right > form.ClientSize.Width)
                horizontalSpeed = -horizontalSpeed;

            if (picBall.Left < 0)
                horizontalSpeed = -horizontalSpeed;
        }

        public void paddleCollsion(PictureBox paddle)
        {
            // collision between ball and paddle
            if (picBall.Bounds.IntersectsWith(paddle.Bounds) == true)
                verticalSpeed = -verticalSpeed;
        }

        public void brickCollsion(Game game)
        {
            foreach (Control c in game.Controls)
                if (c is PictureBox && (string)c.Tag == "brick")
                    if (picBall.Bounds.IntersectsWith(c.Bounds))
                    {
                        game.score += 10;
                        verticalSpeed = -verticalSpeed;

                        // remove collided brick
                        game.Controls.Remove(c);
                    }
        }

        public bool outOfBounds()
        {
            if (picBall.Top > 620)
            {
                return true;
            }
            return false;
        }

        public void resetBallPos()
        {
            picBall.Left = 500;
            picBall.Top = 300;
        }
    }
}
