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
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void Options_Load(object sender, EventArgs e)
        {
            TitleLabel.Size = new Size(TitleLabel.Size.Width, (this.Height / 100) * 40);
            TitleLabel.Font = new Font(TitleLabel.Font.FontFamily, ((this.Width + this.Height) / 100) * 3);
            backButton.Left = ClientSize.Width/2-(backButton.Width/2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Game game = new Game();
            this.Hide();
        }

        private void TitleLabel_Click(object sender, EventArgs e)
        {

        }

        private void backButton_MouseMove(object sender, MouseEventArgs e)
        {
            backButton.ForeColor = Color.White;
        }

        private void backButton_MouseLeave(object sender, EventArgs e)
        {
            backButton.ForeColor = Color.Green;
        }
    }
}
