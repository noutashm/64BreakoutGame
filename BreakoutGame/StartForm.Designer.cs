
namespace BreakoutGame
{
    partial class StartForm
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
            this.Breakout = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Breakout
            // 
            this.Breakout.AutoSize = true;
            this.Breakout.BackColor = System.Drawing.Color.Transparent;
            this.Breakout.Font = new System.Drawing.Font("Segoe UI Symbol", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Breakout.ForeColor = System.Drawing.Color.White;
            this.Breakout.Location = new System.Drawing.Point(170, 67);
            this.Breakout.Name = "Breakout";
            this.Breakout.Size = new System.Drawing.Size(290, 86);
            this.Breakout.TabIndex = 0;
            this.Breakout.Text = "Breakout";
            // 
            // startBtn
            // 
            this.startBtn.Font = new System.Drawing.Font("Segoe UI Variable Display Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.Location = new System.Drawing.Point(275, 297);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(185, 63);
            this.startBtn.TabIndex = 1;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(354, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 86);
            this.label1.TabIndex = 2;
            this.label1.Text = "Game";
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.Breakout);
            this.Name = "StartForm";
            this.Text = "Welcome";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StartForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Breakout;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Label label1;
    }
}