namespace Game_Clicker
{
    partial class Game
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закончитьИгруToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новаяИграToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вГлавноеМенюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правилаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.информацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обАвтореToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.последнийРезультатToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BoxButton = new System.Windows.Forms.Button();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TimerLabel = new System.Windows.Forms.Label();
            this.GameStatusLabel = new System.Windows.Forms.Label();
            this.bestScoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem,
            this.помощьToolStripMenuItem,
            this.информацияToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(724, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.закончитьИгруToolStripMenuItem,
            this.новаяИграToolStripMenuItem,
            this.настройкиToolStripMenuItem,
            this.вГлавноеМенюToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.менюToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.менюToolStripMenuItem.Text = "Menu";
            // 
            // закончитьИгруToolStripMenuItem
            // 
            this.закончитьИгруToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.закончитьИгруToolStripMenuItem.Enabled = false;
            this.закончитьИгруToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.закончитьИгруToolStripMenuItem.Name = "закончитьИгруToolStripMenuItem";
            this.закончитьИгруToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.закончитьИгруToolStripMenuItem.Text = "Finish game";
            this.закончитьИгруToolStripMenuItem.Click += new System.EventHandler(this.закончитьИгруToolStripMenuItem_Click);
            // 
            // новаяИграToolStripMenuItem
            // 
            this.новаяИграToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.новаяИграToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.новаяИграToolStripMenuItem.Name = "новаяИграToolStripMenuItem";
            this.новаяИграToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.новаяИграToolStripMenuItem.Text = "New game";
            this.новаяИграToolStripMenuItem.Click += new System.EventHandler(this.новаяИграToolStripMenuItem_Click);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.настройкиToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.настройкиToolStripMenuItem.Text = "Options";
            this.настройкиToolStripMenuItem.Click += new System.EventHandler(this.настройкиToolStripMenuItem_Click);
            // 
            // вГлавноеМенюToolStripMenuItem
            // 
            this.вГлавноеМенюToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.вГлавноеМенюToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.вГлавноеМенюToolStripMenuItem.Name = "вГлавноеМенюToolStripMenuItem";
            this.вГлавноеМенюToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.вГлавноеМенюToolStripMenuItem.Text = "Main menu";
            this.вГлавноеМенюToolStripMenuItem.Click += new System.EventHandler(this.вГлавноеМенюToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.выходToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.выходToolStripMenuItem.Text = "Quit";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.помощьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.правилаToolStripMenuItem});
            this.помощьToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.помощьToolStripMenuItem.Text = "Help";
            // 
            // правилаToolStripMenuItem
            // 
            this.правилаToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.правилаToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.правилаToolStripMenuItem.Name = "правилаToolStripMenuItem";
            this.правилаToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.правилаToolStripMenuItem.Text = "Rules";
            this.правилаToolStripMenuItem.Click += new System.EventHandler(this.правилаToolStripMenuItem_Click);
            // 
            // информацияToolStripMenuItem
            // 
            this.информацияToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.информацияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обАвтореToolStripMenuItem,
            this.последнийРезультатToolStripMenuItem,
            this.bestScoreToolStripMenuItem});
            this.информацияToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.информацияToolStripMenuItem.Name = "информацияToolStripMenuItem";
            this.информацияToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.информацияToolStripMenuItem.Text = "Info";
            // 
            // обАвтореToolStripMenuItem
            // 
            this.обАвтореToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.обАвтореToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.обАвтореToolStripMenuItem.Name = "обАвтореToolStripMenuItem";
            this.обАвтореToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.обАвтореToolStripMenuItem.Text = "Developer";
            this.обАвтореToolStripMenuItem.Click += new System.EventHandler(this.обАвтореToolStripMenuItem_Click);
            // 
            // последнийРезультатToolStripMenuItem
            // 
            this.последнийРезультатToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.последнийРезультатToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.последнийРезультатToolStripMenuItem.Name = "последнийРезультатToolStripMenuItem";
            this.последнийРезультатToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.последнийРезультатToolStripMenuItem.Text = "Last Score";
            this.последнийРезультатToolStripMenuItem.Click += new System.EventHandler(this.последнийРезультатToolStripMenuItem_Click);
            // 
            // BoxButton
            // 
            this.BoxButton.BackColor = System.Drawing.Color.Red;
            this.BoxButton.Location = new System.Drawing.Point(200, 200);
            this.BoxButton.Name = "BoxButton";
            this.BoxButton.Size = new System.Drawing.Size(100, 100);
            this.BoxButton.TabIndex = 1;
            this.BoxButton.Text = "\r\n\r\n\r\n\r\n";
            this.BoxButton.UseVisualStyleBackColor = false;
            this.BoxButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.ScoreLabel.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.ScoreLabel.Location = new System.Drawing.Point(589, 24);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(120, 64);
            this.ScoreLabel.TabIndex = 2;
            this.ScoreLabel.Text = "Hit: 0\r\nMiss: 0";
            this.ScoreLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.ScoreLabel.Click += new System.EventHandler(this.ScoreLabel_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TimerLabel
            // 
            this.TimerLabel.BackColor = System.Drawing.Color.Transparent;
            this.TimerLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TimerLabel.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimerLabel.ForeColor = System.Drawing.Color.White;
            this.TimerLabel.Location = new System.Drawing.Point(0, 24);
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(724, 39);
            this.TimerLabel.TabIndex = 3;
            this.TimerLabel.Text = "00:00";
            this.TimerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TimerLabel.Click += new System.EventHandler(this.TimerLabel_Click);
            // 
            // GameStatusLabel
            // 
            this.GameStatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.GameStatusLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GameStatusLabel.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GameStatusLabel.ForeColor = System.Drawing.Color.Red;
            this.GameStatusLabel.Location = new System.Drawing.Point(0, 63);
            this.GameStatusLabel.Name = "GameStatusLabel";
            this.GameStatusLabel.Size = new System.Drawing.Size(724, 338);
            this.GameStatusLabel.TabIndex = 4;
            this.GameStatusLabel.Text = "Game Finished\r\nHit: 0\r\nMiss: 0";
            this.GameStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GameStatusLabel.Visible = false;
            this.GameStatusLabel.MouseLeave += new System.EventHandler(this.GameStatusLabel_MouseLeave);
            this.GameStatusLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GameStatusLabel_MouseMove);
            // 
            // bestScoreToolStripMenuItem
            // 
            this.bestScoreToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.bestScoreToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.bestScoreToolStripMenuItem.Name = "bestScoreToolStripMenuItem";
            this.bestScoreToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bestScoreToolStripMenuItem.Text = "Best Score";
            this.bestScoreToolStripMenuItem.Click += new System.EventHandler(this.bestScoreToolStripMenuItem_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(724, 401);
            this.Controls.Add(this.GameStatusLabel);
            this.Controls.Add(this.BoxButton);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.TimerLabel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Game_FormClosed);
            this.Load += new System.EventHandler(this.Game_Load);
            this.Click += new System.EventHandler(this.Game_Click);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закончитьИгруToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новаяИграToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem правилаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem информацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обАвтореToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem последнийРезультатToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вГлавноеМенюToolStripMenuItem;
        private System.Windows.Forms.Button BoxButton;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label TimerLabel;
        private System.Windows.Forms.Label GameStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem bestScoreToolStripMenuItem;
    }
}