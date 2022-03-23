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
    /// <summary>
    /// Welcome form (The first page that runs when the game starts)
    /// Home Page of the Breakout Game
    /// </summary>
    /// 
    public partial class StartForm : Form
    {
        private Game gameForm;

        public StartForm()
        {
            InitializeComponent();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            if (gameForm == null)
            {
                gameForm = new Game();
            }
            gameForm.Show();
            Hide();
        }

        private void StartForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
