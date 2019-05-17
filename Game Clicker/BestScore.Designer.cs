namespace Game_Clicker
{
    partial class BestScore
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
            this.label1 = new System.Windows.Forms.Label();
            this.PixelsScoreLabel = new System.Windows.Forms.Label();
            this.GameModeLabel = new System.Windows.Forms.Label();
            this.MissScoreLabel = new System.Windows.Forms.Label();
            this.HitScoreLabel = new System.Windows.Forms.Label();
            this.ClickScoreLabel = new System.Windows.Forms.Label();
            this.NicknameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Castellar", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(598, 106);
            this.label1.TabIndex = 0;
            this.label1.Text = "BEST SCORE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PixelsScoreLabel
            // 
            this.PixelsScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.PixelsScoreLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.PixelsScoreLabel.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PixelsScoreLabel.ForeColor = System.Drawing.Color.White;
            this.PixelsScoreLabel.Location = new System.Drawing.Point(0, 295);
            this.PixelsScoreLabel.Name = "PixelsScoreLabel";
            this.PixelsScoreLabel.Size = new System.Drawing.Size(598, 38);
            this.PixelsScoreLabel.TabIndex = 12;
            this.PixelsScoreLabel.Text = "Pixels -";
            this.PixelsScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PixelsScoreLabel.MouseLeave += new System.EventHandler(this.PixelsScoreLabel_MouseLeave);
            this.PixelsScoreLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PixelsScoreLabel_MouseMove);
            // 
            // GameModeLabel
            // 
            this.GameModeLabel.BackColor = System.Drawing.Color.Transparent;
            this.GameModeLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.GameModeLabel.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GameModeLabel.ForeColor = System.Drawing.Color.White;
            this.GameModeLabel.Location = new System.Drawing.Point(0, 257);
            this.GameModeLabel.Name = "GameModeLabel";
            this.GameModeLabel.Size = new System.Drawing.Size(598, 38);
            this.GameModeLabel.TabIndex = 11;
            this.GameModeLabel.Text = "Game Mode -";
            this.GameModeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GameModeLabel.Click += new System.EventHandler(this.GameModeLabel_Click);
            this.GameModeLabel.MouseLeave += new System.EventHandler(this.GameModeLabel_MouseLeave);
            this.GameModeLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GameModeLabel_MouseMove);
            // 
            // MissScoreLabel
            // 
            this.MissScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.MissScoreLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MissScoreLabel.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MissScoreLabel.ForeColor = System.Drawing.Color.White;
            this.MissScoreLabel.Location = new System.Drawing.Point(0, 219);
            this.MissScoreLabel.Name = "MissScoreLabel";
            this.MissScoreLabel.Size = new System.Drawing.Size(598, 38);
            this.MissScoreLabel.TabIndex = 10;
            this.MissScoreLabel.Text = "Miss -";
            this.MissScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MissScoreLabel.MouseLeave += new System.EventHandler(this.MissScoreLabel_MouseLeave);
            this.MissScoreLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MissScoreLabel_MouseMove);
            // 
            // HitScoreLabel
            // 
            this.HitScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.HitScoreLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HitScoreLabel.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HitScoreLabel.ForeColor = System.Drawing.Color.White;
            this.HitScoreLabel.Location = new System.Drawing.Point(0, 181);
            this.HitScoreLabel.Name = "HitScoreLabel";
            this.HitScoreLabel.Size = new System.Drawing.Size(598, 38);
            this.HitScoreLabel.TabIndex = 9;
            this.HitScoreLabel.Text = "Hit - ";
            this.HitScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HitScoreLabel.MouseLeave += new System.EventHandler(this.HitScoreLabel_MouseLeave);
            this.HitScoreLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HitScoreLabel_MouseMove);
            // 
            // ClickScoreLabel
            // 
            this.ClickScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.ClickScoreLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ClickScoreLabel.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClickScoreLabel.ForeColor = System.Drawing.Color.White;
            this.ClickScoreLabel.Location = new System.Drawing.Point(0, 143);
            this.ClickScoreLabel.Name = "ClickScoreLabel";
            this.ClickScoreLabel.Size = new System.Drawing.Size(598, 38);
            this.ClickScoreLabel.TabIndex = 8;
            this.ClickScoreLabel.Text = "Total Clicks -";
            this.ClickScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ClickScoreLabel.MouseLeave += new System.EventHandler(this.ClickScoreLabel_MouseLeave);
            this.ClickScoreLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ClickScoreLabel_MouseMove);
            // 
            // NicknameLabel
            // 
            this.NicknameLabel.BackColor = System.Drawing.Color.Transparent;
            this.NicknameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.NicknameLabel.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NicknameLabel.ForeColor = System.Drawing.Color.White;
            this.NicknameLabel.Location = new System.Drawing.Point(0, 106);
            this.NicknameLabel.Name = "NicknameLabel";
            this.NicknameLabel.Size = new System.Drawing.Size(598, 37);
            this.NicknameLabel.TabIndex = 7;
            this.NicknameLabel.Text = "Nickname - ";
            this.NicknameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NicknameLabel.MouseLeave += new System.EventHandler(this.NicknameLabel_MouseLeave);
            this.NicknameLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.NicknameLabel_MouseMove);
            // 
            // BestScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Game_Clicker.Properties.Resources.B74WCzZ;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(598, 382);
            this.Controls.Add(this.PixelsScoreLabel);
            this.Controls.Add(this.GameModeLabel);
            this.Controls.Add(this.MissScoreLabel);
            this.Controls.Add(this.HitScoreLabel);
            this.Controls.Add(this.ClickScoreLabel);
            this.Controls.Add(this.NicknameLabel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BestScore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BestScore";
            this.Deactivate += new System.EventHandler(this.BestScore_Deactivate);
            this.Load += new System.EventHandler(this.BestScore_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label PixelsScoreLabel;
        public System.Windows.Forms.Label GameModeLabel;
        public System.Windows.Forms.Label MissScoreLabel;
        public System.Windows.Forms.Label HitScoreLabel;
        public System.Windows.Forms.Label ClickScoreLabel;
        public System.Windows.Forms.Label NicknameLabel;
    }
}