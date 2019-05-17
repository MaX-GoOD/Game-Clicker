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
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GameEnd();
            Application.Exit();
        }

        private void вГлавноеМенюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GameEnd();
            Menu menu = new Menu();
            this.Hide();
            menu.Show();
        }

        private void закончитьИгруToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GameEnd();
        }

        private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Options options = new Options();
            options.ShowDialog();

        }

        private void Game_Load(object sender, EventArgs e)
        {
            ScoreLabel.Left = ClientSize.Width - ScoreLabel.Width;
            ScoreLabel.Top = menuStrip1.Top + menuStrip1.Height;
            GameStatusLabel.Left = 0;
            GameStatusLabel.Top = menuStrip1.Top + menuStrip1.Height;
            Properties.Settings.Default.HitScore = 0;
            Properties.Settings.Default.MissScore = 0;
        }

        private void обАвтореToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Developer developer = new Developer();
            developer.Show();
        }

        private void последнийРезультатToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LastScore lastScore = new LastScore();
            lastScore.Show();
            lastScore.LastScoreUpdate();
        }

        private void правилаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rules rules = new Rules();
            rules.Show();
        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            Properties.Settings.Default.TimeUse--;
            if (Properties.Settings.Default.TimeUse == 0) GameEnd();
            ScoreUpdate();
            TimeUpdate();
        }

        public void NewGame()
        {
            GameStatusLabel.Visible = false;
            закончитьИгруToolStripMenuItem.Enabled = true;
            TimerLabel.Visible = true;
            BoxButton.Enabled = true;
            Properties.Settings.Default.TimeUse = Properties.Settings.Default.Time;
            TimeUpdate();
        }
        public void GameEnd()
        {
            GameStatusLabel.Visible = true;
            GameStatusLabel.Text = $"Game Finished\nHit: {Properties.Settings.Default.HitScore}\nMiss: {Properties.Settings.Default.MissScore}";
            закончитьИгруToolStripMenuItem.Enabled = false;
            TimerLabel.Visible = false;
            timer1.Enabled = false;
            GameStatus = false;
            BoxButton.Enabled = false;
            Properties.Settings.Default.nicknameLast = Properties.Settings.Default.nickname;
            Properties.Settings.Default.TimeUse = 0;
            Properties.Settings.Default.HitScoreLast = Properties.Settings.Default.HitScore;
            Properties.Settings.Default.HitScore = 0;
            Properties.Settings.Default.MissScoreLast = Properties.Settings.Default.MissScore;
            Properties.Settings.Default.MissScore = 0;
            
            LastScore lastScore = new LastScore();
            lastScore.LastScoreUpdate();

            Properties.Settings.Default.Accuracy = Accuracy(Properties.Settings.Default.HitScore,Properties.Settings.Default.MissScore);
            Properties.Settings.Default.AccuracyLast = Properties.Settings.Default.Accuracy;
            if (Properties.Settings.Default.AccuracyLast > Properties.Settings.Default.AccuracyBest) Properties.Settings.Default.AccuracyBest = Properties.Settings.Default.AccuracyLast;
            Properties.Settings.Default.Save();
            ScoreUpdate();
            TimeUpdate();
            BoxButton.Location = new Point((ClientSize.Width/2)-BoxButton.Width/2,(ClientSize.Height/2)-BoxButton.Height/2);
        }

        public static int Accuracy(int Hit, int Miss)
        {
            int res;
            int a = 100 / (Hit + Miss);
            res = (Hit * 100) / (Hit + Miss);
            return res;
        }

        private void TimeUpdate()
        {
           TimerLabel.Text = $"{(Properties.Settings.Default.TimeUse / 60):00}:{(Properties.Settings.Default.TimeUse % 60):00}";
        }

        private void ScoreUpdate()
        {
            ScoreLabel.Text = 
                $"Hit: {Properties.Settings.Default.HitScore}" +
                $"\nMiss: {Properties.Settings.Default.MissScore}" +
                $"\nAccuracy: {Properties.Settings.Default.Accuracy}%";
            ScoreLabel.Left = ClientSize.Width - ScoreLabel.Width;
            ScoreLabel.Top = menuStrip1.Top + menuStrip1.Height;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (GameStatus == false) GameStatusLabel.Visible = true;
            закончитьИгруToolStripMenuItem.Enabled = true;
            GameStatus = true;
            timer1.Enabled = true;
            Properties.Settings.Default.HitScore++;
            Properties.Settings.Default.Accuracy = Accuracy(Properties.Settings.Default.HitScore, Properties.Settings.Default.MissScore);
            ScoreUpdate();
            Random r = new Random();
            BoxButton.Location = new Point(r.Next(ClientSize.Width-BoxButton.Width),r.Next(ClientSize.Height-BoxButton.Height));
        }
        private bool GameStatus = false;
        private void Game_Click(object sender, EventArgs e)
        {
            if (GameStatus == true)
            {
                Properties.Settings.Default.MissScore++;
                Properties.Settings.Default.Accuracy = Accuracy(Properties.Settings.Default.HitScore, Properties.Settings.Default.MissScore);
                ScoreUpdate();
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void TimerLabel_Click(object sender, EventArgs e)
        {
            if (GameStatus == true)
            {
                Properties.Settings.Default.Accuracy = Accuracy(Properties.Settings.Default.HitScore, Properties.Settings.Default.MissScore);
                Properties.Settings.Default.MissScore++;
                ScoreUpdate();
            }
        }

        private void ScoreLabel_Click(object sender, EventArgs e)
        {
            if (GameStatus == true)
            {
                Properties.Settings.Default.Accuracy = Accuracy(Properties.Settings.Default.HitScore, Properties.Settings.Default.MissScore);
                Properties.Settings.Default.MissScore++;
                ScoreUpdate();
            }
        }

        private void GameStatusLabel_MouseMove(object sender, MouseEventArgs e)
        {
            GameStatusLabel.ForeColor = Color.Yellow;
        }

        private void GameStatusLabel_MouseLeave(object sender, EventArgs e)
        {
            GameStatusLabel.ForeColor = Color.Red;
        }

        private void новаяИграToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GameEnd();
            NewGame();
        }

        private void bestScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BestScore bestScore = new BestScore();
            bestScore.Show();
            bestScore.BestScoreUpdate();
        }
    }
}
