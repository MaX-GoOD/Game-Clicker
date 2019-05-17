using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Clicker
{
    public partial class LastScore : Form
    {
        public LastScore()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void NicknameLabel_MouseMove(object sender, MouseEventArgs e)
        {
            NicknameLabel.BackColor = Color.White;
            NicknameLabel.ForeColor = Color.Black;
        }

        private void NicknameLabel_MouseLeave(object sender, EventArgs e)
        {
            NicknameLabel.BackColor = Color.Transparent;
            NicknameLabel.ForeColor = Color.White;
        }

        private void ClickScoreLabel_MouseMove(object sender, MouseEventArgs e)
        {
            ClickScoreLabel.BackColor = Color.White;
            ClickScoreLabel.ForeColor = Color.Black;
        }

        private void ClickScoreLabel_MouseLeave(object sender, EventArgs e)
        {
            ClickScoreLabel.BackColor = Color.Transparent;
            ClickScoreLabel.ForeColor = Color.White;
        }

        private void HitScoreLabel_MouseMove(object sender, MouseEventArgs e)
        {
            HitScoreLabel.BackColor = Color.White;
            HitScoreLabel.ForeColor = Color.Black;
        }

        private void HitScoreLabel_MouseLeave(object sender, EventArgs e)
        {
            HitScoreLabel.BackColor = Color.Transparent;
            HitScoreLabel.ForeColor = Color.White;
        }

        private void MissScoreLabel_MouseMove(object sender, MouseEventArgs e)
        {
            MissScoreLabel.BackColor = Color.White;
            MissScoreLabel.ForeColor = Color.Black;
        }

        private void MissScoreLabel_MouseLeave(object sender, EventArgs e)
        {
            MissScoreLabel.BackColor = Color.Transparent;
            MissScoreLabel.ForeColor = Color.White;
        }

        private void GameModeLabel_MouseMove(object sender, MouseEventArgs e)
        {
            GameModeLabel.BackColor = Color.White;
            GameModeLabel.ForeColor = Color.Black;
        }

        private void GameModeLabel_MouseLeave(object sender, EventArgs e)
        {
            GameModeLabel.BackColor = Color.Transparent;
            GameModeLabel.ForeColor = Color.White;
        }

        private void PixelsScoreLabel_MouseMove(object sender, MouseEventArgs e)
        {
            PixelsScoreLabel.BackColor = Color.White;
            PixelsScoreLabel.ForeColor = Color.Black;
        }

        private void PixelsScoreLabel_MouseLeave(object sender, EventArgs e)
        {
            PixelsScoreLabel.BackColor = Color.Transparent;
            PixelsScoreLabel.ForeColor = Color.White;
        }

        private void LastScore_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LastScore_Load(object sender, EventArgs e)
        {
            Game game = new Game();

        }

        public void LastScoreUpdate()
        {
            NicknameLabel.Text = $"Nickname - {Properties.Settings.Default.nicknameLast}";
            ClickScoreLabel.Text = $"Total Clicks - {Properties.Settings.Default.HitScoreLast + Properties.Settings.Default.MissScoreLast}";
            HitScoreLabel.Text = $"Hit - {Properties.Settings.Default.HitScoreLast}";
            MissScoreLabel.Text = $"Miss - {Properties.Settings.Default.MissScoreLast}";
            GameModeLabel.Text = $"Game Mode - {Properties.Settings.Default.GameModeLast}";
            PixelsScoreLabel.Text = $"Pixels - {Properties.Settings.Default.PixelsScoreLast}";
            AccuracyLabel.Text = $"Accuracy - {Properties.Settings.Default.AccuracyLast}";
        }

        private void NicknameLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
