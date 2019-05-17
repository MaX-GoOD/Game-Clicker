namespace Game_Clicker
{
    partial class Auth
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.nicknameTextBox = new System.Windows.Forms.TextBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.nicknameLabel = new System.Windows.Forms.Label();
            this.joinButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nicknameTextBox
            // 
            this.nicknameTextBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.nicknameTextBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nicknameTextBox.ForeColor = System.Drawing.SystemColors.Info;
            this.nicknameTextBox.Location = new System.Drawing.Point(162, 89);
            this.nicknameTextBox.MaxLength = 13;
            this.nicknameTextBox.Name = "nicknameTextBox";
            this.nicknameTextBox.Size = new System.Drawing.Size(180, 23);
            this.nicknameTextBox.TabIndex = 0;
            this.nicknameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nicknameTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TitleLabel
            // 
            this.TitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.TitleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleLabel.Font = new System.Drawing.Font("Algerian", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.TitleLabel.Location = new System.Drawing.Point(0, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(505, 86);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Press your nickname";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nicknameLabel
            // 
            this.nicknameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nicknameLabel.Font = new System.Drawing.Font("Papyrus", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nicknameLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.nicknameLabel.Location = new System.Drawing.Point(173, 367);
            this.nicknameLabel.Name = "nicknameLabel";
            this.nicknameLabel.Size = new System.Drawing.Size(177, 50);
            this.nicknameLabel.TabIndex = 2;
            this.nicknameLabel.Text = "Nickname";
            this.nicknameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // joinButton
            // 
            this.joinButton.BackColor = System.Drawing.Color.Transparent;
            this.joinButton.Enabled = false;
            this.joinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.joinButton.ForeColor = System.Drawing.SystemColors.Control;
            this.joinButton.Location = new System.Drawing.Point(215, 118);
            this.joinButton.Name = "joinButton";
            this.joinButton.Size = new System.Drawing.Size(75, 23);
            this.joinButton.TabIndex = 3;
            this.joinButton.Text = "Войти";
            this.joinButton.UseVisualStyleBackColor = false;
            this.joinButton.Click += new System.EventHandler(this.button1_Click);
            this.joinButton.MouseLeave += new System.EventHandler(this.joinButton_MouseLeave);
            this.joinButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.joinButton_MouseMove);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.Transparent;
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.ForeColor = System.Drawing.SystemColors.Control;
            this.CancelButton.Location = new System.Drawing.Point(215, 147);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.button2_Click);
            this.CancelButton.MouseLeave += new System.EventHandler(this.CancelButton_MouseLeave);
            this.CancelButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CancelButton_MouseMove);
            // 
            // Auth
            // 
            this.AcceptButton = this.joinButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Game_Clicker.Properties.Resources.NWRsqS7iRzU;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(505, 588);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.joinButton);
            this.Controls.Add(this.nicknameLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.nicknameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Auth";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Auth_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label nicknameLabel;
        private System.Windows.Forms.Button joinButton;
        private System.Windows.Forms.Button CancelButton;
        public System.Windows.Forms.TextBox nicknameTextBox;
    }
}

