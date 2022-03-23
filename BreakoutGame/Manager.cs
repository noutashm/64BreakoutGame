using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BreakoutGame
{
    class Manager
    {
        /// <summary>
        /// Your Manager class must have following attributes 
        /// Add more attributes if required 
        /// </summary>
        private Bricks bricks;
        private Ball ball;
        private Paddle paddle;
        public SoundPlayer gamePlayAudio, winningAudio, losingAudio;

        public Manager(Bricks bricks, Ball ball, Paddle paddle)
        {
            this.bricks = bricks;
            this.ball = ball;
            this.paddle = paddle;

            gamePlayAudio = new SoundPlayer(Properties.Resources.gameplay);
            losingAudio = new SoundPlayer(Properties.Resources.loose);
            winningAudio = new SoundPlayer(Properties.Resources.win);
        }

        public void startGame(Game game)
        {
            bricks.DrawBricks(game);
            gamePlayAudio.PlayLooping();
        }

        public void updateGame(Game game, PictureBox paddle)
        {
            ball.move();
            ball.formCollision(game);
            ball.paddleCollsion(paddle);
            ball.brickCollsion(game);
            game.lblScore.Text = "Score: " + game.score;

            if (ball.outOfBounds())
            {
                gameLost(game);
            }

            if (game.score >= 320)
            {
                gameWon(game);
            }
        }

        public void restartGame(Game game)
        {
            game.gameTimer.Stop();
            bricks.ClearBricks(game);
            bricks.DrawBricks(game);
            ball.resetBallPos();
            game.score = 0;
            game.menuPanel.Visible = false;
            game.endGamePanel.Visible = false;
            gamePlayAudio.PlayLooping();
            game.gameTimer.Start();
        }

        public void gameLost(Game game)
        {
            game.gameTimer.Stop();
            game.wonLossLabel.Text = "You Lost!";
            game.endGameScore.Text = "Score: " + game.score;
            game.endGamePanel.Visible = true;
            losingAudio.Play();
        }

        public void gameWon(Game game)
        {
            game.gameTimer.Stop();
            game.wonLossLabel.Text = "You Won!";
            game.endGameScore.Text = "Score: " + game.score;
            game.endGamePanel.Visible = true;
            winningAudio.Play();
        }
    }
}
