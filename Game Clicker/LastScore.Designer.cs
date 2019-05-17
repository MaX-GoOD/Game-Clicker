namespace Game_Clicker
{
    partial class LastScore
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.NicknameLabel = new System.Windows.Forms.Label();
            this.ClickScoreLabel = new System.Windows.Forms.Label();
            this.HitScoreLabel = new System.Windows.Forms.Label();
            this.MissScoreLabel = new System.Windows.Forms.Label();
            this.GameModeLabel = new System.Windows.Forms.Label();
            this.PixelsScoreLabel = new System.Windows.Forms.Label();
            this.AccuracyLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.TitleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleLabel.Font = new System.Drawing.Font("Castellar", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.TitleLabel.Location = new System.Drawing.Point(0, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(573, 99);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Last Score";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NicknameLabel
            // 
            this.NicknameLabel.BackColor = System.Drawing.Color.Transparent;
            this.NicknameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.NicknameLabel.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NicknameLabel.ForeColor = System.Drawing.Color.White;
            this.NicknameLabel.Location = new System.Drawing.Point(0, 99);
            this.NicknameLabel.Name = "NicknameLabel";
            this.NicknameLabel.Size = new System.Drawing.Size(573, 37);
            this.NicknameLabel.TabIndex = 1;
            this.NicknameLabel.Text = "Nickname - ";
            this.NicknameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NicknameLabel.Click += new System.EventHandler(this.NicknameLabel_Click);
            this.NicknameLabel.MouseLeave += new System.EventHandler(this.NicknameLabel_MouseLeave);
            this.NicknameLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.NicknameLabel_MouseMove);
            // 
            // ClickScoreLabel
            // 
            this.ClickScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.ClickScoreLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ClickScoreLabel.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClickScoreLabel.ForeColor = System.Drawing.Color.White;
            this.ClickScoreLabel.Location = new System.Drawing.Point(0, 136);
            this.ClickScoreLabel.Name = "ClickScoreLabel";
            this.ClickScoreLabel.Size = new System.Drawing.Size(573, 38);
            this.ClickScoreLabel.TabIndex = 2;
            this.ClickScoreLabel.Text = "Total Clicks -";
            this.ClickScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ClickScoreLabel.MouseLeave += new System.EventHandler(this.ClickScoreLabel_MouseLeave);
            this.ClickScoreLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ClickScoreLabel_MouseMove);
            // 
            // HitScoreLabel
            // 
            this.HitScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.HitScoreLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HitScoreLabel.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HitScoreLabel.ForeColor = System.Drawing.Color.White;
            this.HitScoreLabel.Location = new System.Drawing.Point(0, 174);
            this.HitScoreLabel.Name = "HitScoreLabel";
            this.HitScoreLabel.Size = new System.Drawing.Size(573, 38);
            this.HitScoreLabel.TabIndex = 3;
            this.HitScoreLabel.Text = "Hit - ";
            this.HitScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HitScoreLabel.MouseLeave += new System.EventHandler(this.HitScoreLabel_MouseLeave);
            this.HitScoreLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HitScoreLabel_MouseMove);
            // 
            // MissScoreLabel
            // 
            this.MissScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.MissScoreLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MissScoreLabel.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MissScoreLabel.ForeColor = System.Drawing.Color.White;
            this.MissScoreLabel.Location = new System.Drawing.Point(0, 212);
            this.MissScoreLabel.Name = "MissScoreLabel";
            this.MissScoreLabel.Size = new System.Drawing.Size(573, 38);
            this.MissScoreLabel.TabIndex = 4;
            this.MissScoreLabel.Text = "Miss -";
            this.MissScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MissScoreLabel.MouseLeave += new System.EventHandler(this.MissScoreLabel_MouseLeave);
            this.MissScoreLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MissScoreLabel_MouseMove);
            // 
            // GameModeLabel
            // 
            this.GameModeLabel.BackColor = System.Drawing.Color.Transparent;
            this.GameModeLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.GameModeLabel.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GameModeLabel.ForeColor = System.Drawing.Color.White;
            this.GameModeLabel.Location = new System.Drawing.Point(0, 250);
            this.GameModeLabel.Name = "GameModeLabel";
            this.GameModeLabel.Size = new System.Drawing.Size(573, 38);
            this.GameModeLabel.TabIndex = 5;
            this.GameModeLabel.Text = "Game Mode -";
            this.GameModeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GameModeLabel.MouseLeave += new System.EventHandler(this.GameModeLabel_MouseLeave);
            this.GameModeLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GameModeLabel_MouseMove);
            // 
            // PixelsScoreLabel
            // 
            this.PixelsScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.PixelsScoreLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.PixelsScoreLabel.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PixelsScoreLabel.ForeColor = System.Drawing.Color.White;
            this.PixelsScoreLabel.Location = new System.Drawing.Point(0, 288);
            this.PixelsScoreLabel.Name = "PixelsScoreLabel";
            this.PixelsScoreLabel.Size = new System.Drawing.Size(573, 38);
            this.PixelsScoreLabel.TabIndex = 6;
            this.PixelsScoreLabel.Text = "Pixels -";
            this.PixelsScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PixelsScoreLabel.MouseLeave += new System.EventHandler(this.PixelsScoreLabel_MouseLeave);
            this.PixelsScoreLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PixelsScoreLabel_MouseMove);
            // 
            // AccuracyLabel
            // 
            this.AccuracyLabel.BackColor = System.Drawing.Color.Transparent;
            this.AccuracyLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AccuracyLabel.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AccuracyLabel.ForeColor = System.Drawing.Color.White;
            this.AccuracyLabel.Location = new System.Drawing.Point(0, 326);
            this.AccuracyLabel.Name = "AccuracyLabel";
            this.AccuracyLabel.Size = new System.Drawing.Size(573, 38);
            this.AccuracyLabel.TabIndex = 7;
            this.AccuracyLabel.Text = "Accuracy - ";
            this.AccuracyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LastScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Game_Clicker.Properties.Resources.B74WCzZ;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(573, 383);
            this.Controls.Add(this.AccuracyLabel);
            this.Controls.Add(this.PixelsScoreLabel);
            this.Controls.Add(this.GameModeLabel);
            this.Controls.Add(this.MissScoreLabel);
            this.Controls.Add(this.HitScoreLabel);
            this.Controls.Add(this.ClickScoreLabel);
            this.Controls.Add(this.NicknameLabel);
            this.Controls.Add(this.TitleLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LastScore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LastScore";
            this.Deactivate += new System.EventHandler(this.LastScore_Deactivate);
            this.Load += new System.EventHandler(this.LastScore_Load);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Label NicknameLabel;
        public System.Windows.Forms.Label ClickScoreLabel;
        public System.Windows.Forms.Label HitScoreLabel;
        public System.Windows.Forms.Label MissScoreLabel;
        public System.Windows.Forms.Label GameModeLabel;
        public System.Windows.Forms.Label PixelsScoreLabel;
        public System.Windows.Forms.Label TitleLabel;
        public System.Windows.Forms.Label AccuracyLabel;
    }
}