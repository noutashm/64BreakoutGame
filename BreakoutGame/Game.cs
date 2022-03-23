using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BreakoutGame
{
    public partial class Game : Form
    {
        /// <summary>
        /// 
        /// </summary>
        /// 

        private Bricks bricks;
        private Ball ball;
        private Paddle paddle;
        private Manager manager;
        private StartForm startForm;

        private int verticalSpeed;
        private int horizontalSpeed;
        private int bricksRows;
        private int bricksCols;
        private int paddleSpeed;
        public int score;

        public Game()
        {
            InitializeComponent();

            //Adjust these numbers 
            verticalSpeed = 5;
            horizontalSpeed = 5;
            bricksRows = 8;
            bricksCols = 4;
            paddleSpeed = 5;

            //Create objects 
            ball = new Ball(picBall, verticalSpeed, horizontalSpeed, Color.Red);
            paddle = new Paddle(picPaddle, paddleSpeed);
            bricks = new Bricks(bricksRows, bricksCols);
            manager = new Manager(bricks, ball, paddle);

            //Start the game
            manager.startGame(this);
        }

        // paddle mouse movement
        private void Game_MouseMove(object sender, MouseEventArgs e)
        {
            picPaddle.Left = e.X - (picPaddle.Width / 2);
        }

        private void mainGameTick(object sender, EventArgs e)
        {
            manager.updateGame(this, picPaddle);
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            if (gameTimer.Enabled == true)
            {
                gameTimer.Enabled = false;
            } else
            {
                gameTimer.Enabled = true;
            }

            if (menuPanel.Visible == false)
            {
                menuPanel.Visible = true;
            } else
            {
                menuPanel.Visible = false;
            }
        }

        private void resumeBtn_Click(object sender, EventArgs e)
        {
            gameTimer.Enabled = true;
            menuPanel.Visible = false;
        }

        private void restartBtn_Click(object sender, EventArgs e)
        {
            manager.restartGame(this);
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            if (startForm == null)
            {
                startForm = new StartForm();
            }

            startForm.Show();
            Dispose();

            score = 0;
        }

        private void Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void endGameRestartBtn_Click(object sender, EventArgs e)
        {
            manager.restartGame(this);
        }

        private void endGameBackBtn_Click(object sender, EventArgs e)
        {
            if (startForm == null)
            {
                startForm = new StartForm();
            }

            startForm.Show();
            Dispose();

            score = 0;
        }
    }
}
