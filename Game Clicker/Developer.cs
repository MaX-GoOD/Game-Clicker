using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Game_Clicker
{
    public partial class Developer : Form
    {
        public Developer()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void TitleLabel_Click(object sender, EventArgs e)
        {
            Process.Start("https://vk.com/maxatermahanov");
        }

        private void TitleLabel_MouseMove(object sender, MouseEventArgs e)
        {
            TitleLabel.ForeColor = Color.Blue;
        }

        private void TitleLabel_MouseLeave(object sender, EventArgs e)
        {
            TitleLabel.ForeColor = Color.Red;
        }

        private void Developer_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Developer_Load(object sender, EventArgs e)
        {
            
        }

        private void TextLabel_MouseMove(object sender, MouseEventArgs e)
        {
            TextLabel.ForeColor = Color.Black;
        }

        private void TextLabel_MouseLeave(object sender, EventArgs e)
        {
            TextLabel.ForeColor = Color.Red;
        }
    }
}
