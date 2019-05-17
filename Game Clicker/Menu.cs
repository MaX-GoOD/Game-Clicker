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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            newgameLabel.ForeColor = Color.White;
        }

        private void quitLabel_MouseMove(object sender, MouseEventArgs e)
        {
            quitLabel.ForeColor = Color.White;
        }

        private void newgameLabel_MouseLeave(object sender, EventArgs e)
        {
            newgameLabel.ForeColor = Color.Blue;
        }

        private void quitLabel_MouseLeave(object sender, EventArgs e)
        {
            quitLabel.ForeColor = Color.Blue;
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            welcomeLabel.Size = new Size(welcomeLabel.Size.Width,(ClientSize.Height / 100)*40);
            welcomeLabel.Font = new Font(welcomeLabel.Font.FontFamily,((ClientSize.Width + ClientSize.Height)/100)*3);
            newgameLabel.Font = new Font(newgameLabel.Font.FontFamily, (ClientSize.Width + ClientSize.Height) / 100 * 2);
            OptionsLabel.Font = new Font(OptionsLabel.Font.FontFamily, (ClientSize.Width + ClientSize.Height) / 100 * 2);
            backLabel.Font = new Font(backLabel.Font.FontFamily, ((ClientSize.Width + ClientSize.Height) / 100) * 2);
            quitLabel.Font = new Font(newgameLabel.Font.FontFamily, (ClientSize.Width + ClientSize.Height) / 100 * 2);
            newgameLabel.Top = welcomeLabel.Top + welcomeLabel.Height;
            newgameLabel.Left = (ClientSize.Width / 2) - newgameLabel.Width / 2;
            OptionsLabel.Top = newgameLabel.Top + newgameLabel.Height;
            OptionsLabel.Left = (ClientSize.Width / 2) - OptionsLabel.Width / 2;
            backLabel.Top = OptionsLabel.Top + OptionsLabel.Height;
            backLabel.Left = (ClientSize.Width / 2) - backLabel.Width / 2;
            quitLabel.Top = backLabel.Top + backLabel.Height;
            quitLabel.Left = (ClientSize.Width / 2) - quitLabel.Width / 2;
        }

        private void quitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Auth auth = new Auth();
            this.Hide();
            auth.Show();
        }

        private void backLabel_MouseMove(object sender, MouseEventArgs e)
        {
            backLabel.ForeColor = Color.White;
        }

        private void backLabel_MouseLeave(object sender, EventArgs e)
        {
            backLabel.ForeColor = Color.Blue;
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void newgameLabel_Click(object sender, EventArgs e)
        {
            Game game = new Game();
            game.Show();
            game.NewGame();
            this.Hide();
        }

        private void OptionsLabel_MouseMove(object sender, MouseEventArgs e)
        {
            OptionsLabel.ForeColor = Color.White;
        }

        private void OptionsLabel_MouseLeave(object sender, EventArgs e)
        {
            OptionsLabel.ForeColor = Color.Blue;
        }

        private void OptionsLabel_Click(object sender, EventArgs e)
        {
            Options options = new Options();
            options.ShowDialog();
        }
    }
}
