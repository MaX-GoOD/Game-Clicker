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
    public partial class Rules : Form
    {
        public Rules()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void Rules_Load(object sender, EventArgs e)
        {

        }

        private void TextLabel_MouseMove(object sender, MouseEventArgs e)
        {
            TextLabel.ForeColor = Color.White;
        }

        private void TextLabel_MouseLeave(object sender, EventArgs e)
        {
            TextLabel.ForeColor = Color.Purple;
        }

        private void Rules_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
