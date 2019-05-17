using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;

namespace Game_Clicker
{
    public partial class Auth : Form
    {

        public Auth()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            Properties.Settings.Default.TimeUse = Properties.Settings.Default.Time;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            nicknameLabel.Text = nicknameTextBox.Text;
            if (nicknameTextBox.Text.Length >= 4) joinButton.Enabled = true;
            else joinButton.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
            menu.welcomeLabel.Text = "Welcome "+nicknameTextBox.Text+"!";
            Properties.Settings.Default.nickname = nicknameTextBox.Text;
            Properties.Settings.Default.nicknameLast = nicknameTextBox.Text;
            Properties.Settings.Default.Save();
        }

        private void Auth_Load(object sender, EventArgs e)
        {
            nicknameTextBox.Text = Properties.Settings.Default.nicknameLast;
        }

        private void joinButton_MouseMove(object sender, MouseEventArgs e)
        {
            joinButton.ForeColor = Color.Black;
        }

        private void joinButton_MouseLeave(object sender, EventArgs e)
        {
            joinButton.ForeColor = Color.White;
        }

        private void CancelButton_MouseMove(object sender, MouseEventArgs e)
        {
            CancelButton.ForeColor = Color.Black;
        }

        private void CancelButton_MouseLeave(object sender, EventArgs e)
        {
            CancelButton.ForeColor = Color.White;
        }
    }
}
