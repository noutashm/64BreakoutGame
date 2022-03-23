namespace BreakoutGame
{
    partial class Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.picBall = new System.Windows.Forms.PictureBox();
            this.picPaddle = new System.Windows.Forms.PictureBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.menuBtn = new System.Windows.Forms.Button();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.restartBtn = new System.Windows.Forms.Button();
            this.resumeBtn = new System.Windows.Forms.Button();
            this.endGamePanel = new System.Windows.Forms.Panel();
            this.endGameScore = new System.Windows.Forms.Label();
            this.wonLossLabel = new System.Windows.Forms.Label();
            this.endGameBackBtn = new System.Windows.Forms.Button();
            this.endGameRestartBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPaddle)).BeginInit();
            this.menuPanel.SuspendLayout();
            this.endGamePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.mainGameTick);
            // 
            // picBall
            // 
            this.picBall.BackColor = System.Drawing.Color.White;
            this.picBall.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBall.Location = new System.Drawing.Point(387, 361);
            this.picBall.Name = "picBall";
            this.picBall.Size = new System.Drawing.Size(17, 18);
            this.picBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBall.TabIndex = 1;
            this.picBall.TabStop = false;
            // 
            // picPaddle
            // 
            this.picPaddle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.picPaddle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPaddle.Location = new System.Drawing.Point(346, 484);
            this.picPaddle.Name = "picPaddle";
            this.picPaddle.Size = new System.Drawing.Size(109, 20);
            this.picPaddle.TabIndex = 2;
            this.picPaddle.TabStop = false;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Segoe UI Variable Display Light", 16F);
            this.lblScore.Location = new System.Drawing.Point(12, 541);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(85, 30);
            this.lblScore.TabIndex = 3;
            this.lblScore.Text = "Score: 0";
            // 
            // menuBtn
            // 
            this.menuBtn.Font = new System.Drawing.Font("Segoe UI Variable Display Light", 14F);
            this.menuBtn.Location = new System.Drawing.Point(661, 532);
            this.menuBtn.Name = "menuBtn";
            this.menuBtn.Size = new System.Drawing.Size(152, 35);
            this.menuBtn.TabIndex = 4;
            this.menuBtn.Text = "Menu";
            this.menuBtn.UseVisualStyleBackColor = true;
            this.menuBtn.Click += new System.EventHandler(this.menuBtn_Click);
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuPanel.Controls.Add(this.label1);
            this.menuPanel.Controls.Add(this.backBtn);
            this.menuPanel.Controls.Add(this.restartBtn);
            this.menuPanel.Controls.Add(this.resumeBtn);
            this.menuPanel.Location = new System.Drawing.Point(203, 112);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(381, 344);
            this.menuPanel.TabIndex = 5;
            this.menuPanel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 26F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(119, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 47);
            this.label1.TabIndex = 3;
            this.label1.Text = "Paused";
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Segoe UI Variable Display Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(91, 255);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(185, 63);
            this.backBtn.TabIndex = 2;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // restartBtn
            // 
            this.restartBtn.Font = new System.Drawing.Font("Segoe UI Variable Display Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartBtn.Location = new System.Drawing.Point(91, 171);
            this.restartBtn.Name = "restartBtn";
            this.restartBtn.Size = new System.Drawing.Size(185, 63);
            this.restartBtn.TabIndex = 1;
            this.restartBtn.Text = "Restart";
            this.restartBtn.UseVisualStyleBackColor = true;
            this.restartBtn.Click += new System.EventHandler(this.restartBtn_Click);
            // 
            // resumeBtn
            // 
            this.resumeBtn.Font = new System.Drawing.Font("Segoe UI Variable Display Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resumeBtn.Location = new System.Drawing.Point(91, 89);
            this.resumeBtn.Name = "resumeBtn";
            this.resumeBtn.Size = new System.Drawing.Size(185, 63);
            this.resumeBtn.TabIndex = 0;
            this.resumeBtn.Text = "Resume";
            this.resumeBtn.UseVisualStyleBackColor = true;
            this.resumeBtn.Click += new System.EventHandler(this.resumeBtn_Click);
            // 
            // endGamePanel
            // 
            this.endGamePanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.endGamePanel.Controls.Add(this.endGameScore);
            this.endGamePanel.Controls.Add(this.wonLossLabel);
            this.endGamePanel.Controls.Add(this.endGameBackBtn);
            this.endGamePanel.Controls.Add(this.endGameRestartBtn);
            this.endGamePanel.Location = new System.Drawing.Point(203, 112);
            this.endGamePanel.Name = "endGamePanel";
            this.endGamePanel.Size = new System.Drawing.Size(381, 344);
            this.endGamePanel.TabIndex = 6;
            this.endGamePanel.Visible = false;
            // 
            // endGameScore
            // 
            this.endGameScore.AutoSize = true;
            this.endGameScore.Font = new System.Drawing.Font("Segoe UI Variable Display Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endGameScore.ForeColor = System.Drawing.Color.White;
            this.endGameScore.Location = new System.Drawing.Point(138, 89);
            this.endGameScore.Name = "endGameScore";
            this.endGameScore.Size = new System.Drawing.Size(64, 26);
            this.endGameScore.TabIndex = 4;
            this.endGameScore.Text = "Score: ";
            // 
            // wonLossLabel
            // 
            this.wonLossLabel.AutoSize = true;
            this.wonLossLabel.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 26F, System.Drawing.FontStyle.Bold);
            this.wonLossLabel.ForeColor = System.Drawing.Color.White;
            this.wonLossLabel.Location = new System.Drawing.Point(119, 25);
            this.wonLossLabel.Name = "wonLossLabel";
            this.wonLossLabel.Size = new System.Drawing.Size(138, 47);
            this.wonLossLabel.TabIndex = 3;
            this.wonLossLabel.Text = "Sample";
            // 
            // endGameBackBtn
            // 
            this.endGameBackBtn.Font = new System.Drawing.Font("Segoe UI Variable Display Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endGameBackBtn.Location = new System.Drawing.Point(91, 242);
            this.endGameBackBtn.Name = "endGameBackBtn";
            this.endGameBackBtn.Size = new System.Drawing.Size(185, 63);
            this.endGameBackBtn.TabIndex = 2;
            this.endGameBackBtn.Text = "Back";
            this.endGameBackBtn.UseVisualStyleBackColor = true;
            this.endGameBackBtn.Click += new System.EventHandler(this.endGameBackBtn_Click);
            // 
            // endGameRestartBtn
            // 
            this.endGameRestartBtn.Font = new System.Drawing.Font("Segoe UI Variable Display Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endGameRestartBtn.Location = new System.Drawing.Point(91, 158);
            this.endGameRestartBtn.Name = "endGameRestartBtn";
            this.endGameRestartBtn.Size = new System.Drawing.Size(185, 63);
            this.endGameRestartBtn.TabIndex = 1;
            this.endGameRestartBtn.Text = "Restart";
            this.endGameRestartBtn.UseVisualStyleBackColor = true;
            this.endGameRestartBtn.Click += new System.EventHandler(this.endGameRestartBtn_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(825, 581);
            this.Controls.Add(this.endGamePanel);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.menuBtn);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.picPaddle);
            this.Controls.Add(this.picBall);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Game";
            this.Text = "Breakout";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Game_FormClosed);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Game_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPaddle)).EndInit();
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            this.endGamePanel.ResumeLayout(false);
            this.endGamePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox picBall;
        private System.Windows.Forms.PictureBox picPaddle;
        public System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button menuBtn;
        public System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Button resumeBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button restartBtn;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel endGamePanel;
        public System.Windows.Forms.Label endGameScore;
        public System.Windows.Forms.Label wonLossLabel;
        private System.Windows.Forms.Button endGameBackBtn;
        private System.Windows.Forms.Button endGameRestartBtn;
    }
}

