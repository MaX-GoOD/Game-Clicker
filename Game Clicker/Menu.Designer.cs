namespace Game_Clicker
{
    partial class Menu
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
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.newgameLabel = new System.Windows.Forms.Label();
            this.quitLabel = new System.Windows.Forms.Label();
            this.backLabel = new System.Windows.Forms.Label();
            this.OptionsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.welcomeLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.welcomeLabel.Font = new System.Drawing.Font("Jokerman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.Color.Red;
            this.welcomeLabel.Location = new System.Drawing.Point(0, 0);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(608, 128);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome nickname!";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // newgameLabel
            // 
            this.newgameLabel.AutoSize = true;
            this.newgameLabel.BackColor = System.Drawing.Color.Transparent;
            this.newgameLabel.Font = new System.Drawing.Font("Algerian", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newgameLabel.ForeColor = System.Drawing.Color.Blue;
            this.newgameLabel.Location = new System.Drawing.Point(203, 128);
            this.newgameLabel.Name = "newgameLabel";
            this.newgameLabel.Size = new System.Drawing.Size(203, 39);
            this.newgameLabel.TabIndex = 1;
            this.newgameLabel.Text = "NEW GAME";
            this.newgameLabel.Click += new System.EventHandler(this.newgameLabel_Click);
            this.newgameLabel.MouseLeave += new System.EventHandler(this.newgameLabel_MouseLeave);
            this.newgameLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label2_MouseMove);
            // 
            // quitLabel
            // 
            this.quitLabel.AutoSize = true;
            this.quitLabel.BackColor = System.Drawing.Color.Transparent;
            this.quitLabel.Font = new System.Drawing.Font("Algerian", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitLabel.ForeColor = System.Drawing.Color.Blue;
            this.quitLabel.Location = new System.Drawing.Point(257, 332);
            this.quitLabel.Name = "quitLabel";
            this.quitLabel.Size = new System.Drawing.Size(95, 39);
            this.quitLabel.TabIndex = 2;
            this.quitLabel.Text = "QUIT";
            this.quitLabel.Click += new System.EventHandler(this.quitLabel_Click);
            this.quitLabel.MouseLeave += new System.EventHandler(this.quitLabel_MouseLeave);
            this.quitLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.quitLabel_MouseMove);
            // 
            // backLabel
            // 
            this.backLabel.AutoSize = true;
            this.backLabel.BackColor = System.Drawing.Color.Transparent;
            this.backLabel.Font = new System.Drawing.Font("Algerian", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backLabel.ForeColor = System.Drawing.Color.Blue;
            this.backLabel.Location = new System.Drawing.Point(247, 264);
            this.backLabel.Name = "backLabel";
            this.backLabel.Size = new System.Drawing.Size(114, 39);
            this.backLabel.TabIndex = 3;
            this.backLabel.Text = "BACK";
            this.backLabel.Click += new System.EventHandler(this.label1_Click);
            this.backLabel.MouseLeave += new System.EventHandler(this.backLabel_MouseLeave);
            this.backLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.backLabel_MouseMove);
            // 
            // OptionsLabel
            // 
            this.OptionsLabel.AutoSize = true;
            this.OptionsLabel.BackColor = System.Drawing.Color.Transparent;
            this.OptionsLabel.Font = new System.Drawing.Font("Algerian", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptionsLabel.ForeColor = System.Drawing.Color.Blue;
            this.OptionsLabel.Location = new System.Drawing.Point(224, 196);
            this.OptionsLabel.Name = "OptionsLabel";
            this.OptionsLabel.Size = new System.Drawing.Size(160, 39);
            this.OptionsLabel.TabIndex = 4;
            this.OptionsLabel.Text = "OPTIONS";
            this.OptionsLabel.Click += new System.EventHandler(this.OptionsLabel_Click);
            this.OptionsLabel.MouseLeave += new System.EventHandler(this.OptionsLabel_MouseLeave);
            this.OptionsLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OptionsLabel_MouseMove);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Game_Clicker.Properties.Resources.ichigo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(608, 409);
            this.Controls.Add(this.OptionsLabel);
            this.Controls.Add(this.backLabel);
            this.Controls.Add(this.quitLabel);
            this.Controls.Add(this.newgameLabel);
            this.Controls.Add(this.welcomeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label newgameLabel;
        private System.Windows.Forms.Label quitLabel;
        public System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label backLabel;
        private System.Windows.Forms.Label OptionsLabel;
    }
}