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
    public partial class BestScore : Form
    {
        public BestScore()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void BestScore_Load(object sender, EventArgs e)
        {

        }

        public void BestScoreUpdate()
        {
            NicknameLabel.Text = $"Nickname - {Properties.Settings.Default.nicknameBest}";
            ClickScoreLabel.Text = $"Total Clicks - {Properties.Settings.Default.HitScoreBest + Properties.Settings.Default.MissScoreBest}";
            HitScoreLabel.Text = $"Hit - {Properties.Settings.Default.HitScoreBest}";
            MissScoreLabel.Text = $"Miss - {Properties.Settings.Default.MissScoreBest}";
            GameModeLabel.Text = $"Game Mode - {Properties.Settings.Default.GameModeBest}";
            PixelsScoreLabel.Text = $"Pixels - {Properties.Settings.Default.PixelsScoreBest}";
        }

        private void NicknameLabel_MouseMove(object sender, MouseEventArgs e)
        {
            NicknameLabel.BackColor = Color.White;
            NicknameLabel.ForeColor = Color.Black;
        }

        private void BestScore_Deactivate(object sender, EventArgs e)
        {
            this.Close();
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

        private void GameModeLabel_Click(object sender, EventArgs e)
        {

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
    }
}
