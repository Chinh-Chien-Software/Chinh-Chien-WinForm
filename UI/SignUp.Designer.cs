namespace ChinChin.UI
{
    partial class SignUp
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
            this.btnExit = new FontAwesome.Sharp.IconPictureBox();
            this.tbcPassword = new ChinChin.Custom.TextBox_Custom();
            this.SignInButton = new ChinChin.Extra.BlackWhiteButton();
            this.iPBxShowHidePasword = new FontAwesome.Sharp.IconPictureBox();
            this.labelPasword = new System.Windows.Forms.Label();
            this.tbcUserName = new ChinChin.Custom.TextBox_Custom();
            this.labelUserName = new System.Windows.Forms.Label();
            this.lblNoAccount = new System.Windows.Forms.Label();
            this.lblThongBao = new System.Windows.Forms.Label();
            this.lblSignIn = new System.Windows.Forms.Label();
            this.panelUsername = new System.Windows.Forms.Panel();
            this.panelPassword = new System.Windows.Forms.Panel();
            this.panelBackground = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbcEmail = new ChinChin.Custom.TextBox_Custom();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPBxShowHidePasword)).BeginInit();
            this.panelUsername.SuspendLayout();
            this.panelPassword.SuspendLayout();
            this.panelBackground.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btnExit.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 46;
            this.btnExit.Location = new System.Drawing.Point(743, 11);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(46, 48);
            this.btnExit.TabIndex = 9;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tbcPassword
            // 
            this.tbcPassword.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbcPassword.ForeColor = System.Drawing.Color.White;
            this.tbcPassword.Location = new System.Drawing.Point(263, 35);
            this.tbcPassword.Name = "tbcPassword";
            this.tbcPassword.PasswordChar = '\0';
            this.tbcPassword.Size = new System.Drawing.Size(271, 36);
            this.tbcPassword.TabIndex = 8;
            // 
            // SignInButton
            // 
            this.SignInButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SignInButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(108)))), ((int)(((byte)(247)))));
            this.SignInButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(108)))), ((int)(((byte)(247)))));
            this.SignInButton.BorderColor = System.Drawing.Color.Black;
            this.SignInButton.BorderRadius = 0;
            this.SignInButton.BorderSize = 0;
            this.SignInButton.FlatAppearance.BorderSize = 0;
            this.SignInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignInButton.Font = new System.Drawing.Font("Inter", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInButton.ForeColor = System.Drawing.Color.White;
            this.SignInButton.Location = new System.Drawing.Point(263, 437);
            this.SignInButton.Margin = new System.Windows.Forms.Padding(2);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(271, 122);
            this.SignInButton.TabIndex = 10;
            this.SignInButton.Text = "ĐĂNG NHẬP";
            this.SignInButton.TextColor = System.Drawing.Color.White;
            this.SignInButton.UseVisualStyleBackColor = false;
            // 
            // iPBxShowHidePasword
            // 
            this.iPBxShowHidePasword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iPBxShowHidePasword.BackColor = System.Drawing.Color.White;
            this.iPBxShowHidePasword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iPBxShowHidePasword.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.iPBxShowHidePasword.IconColor = System.Drawing.SystemColors.ControlText;
            this.iPBxShowHidePasword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iPBxShowHidePasword.IconSize = 25;
            this.iPBxShowHidePasword.Location = new System.Drawing.Point(505, 44);
            this.iPBxShowHidePasword.Margin = new System.Windows.Forms.Padding(2);
            this.iPBxShowHidePasword.Name = "iPBxShowHidePasword";
            this.iPBxShowHidePasword.Size = new System.Drawing.Size(29, 25);
            this.iPBxShowHidePasword.TabIndex = 16;
            this.iPBxShowHidePasword.TabStop = false;
            // 
            // labelPasword
            // 
            this.labelPasword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelPasword.AutoSize = true;
            this.labelPasword.BackColor = System.Drawing.Color.Transparent;
            this.labelPasword.Font = new System.Drawing.Font("Inter", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPasword.Location = new System.Drawing.Point(257, -1);
            this.labelPasword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPasword.Name = "labelPasword";
            this.labelPasword.Size = new System.Drawing.Size(128, 33);
            this.labelPasword.TabIndex = 7;
            this.labelPasword.Text = "Mật khẩu";
            // 
            // tbcUserName
            // 
            this.tbcUserName.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbcUserName.ForeColor = System.Drawing.Color.White;
            this.tbcUserName.Location = new System.Drawing.Point(261, 38);
            this.tbcUserName.Name = "tbcUserName";
            this.tbcUserName.PasswordChar = '\0';
            this.tbcUserName.Size = new System.Drawing.Size(271, 36);
            this.tbcUserName.TabIndex = 7;
            // 
            // labelUserName
            // 
            this.labelUserName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelUserName.AutoSize = true;
            this.labelUserName.BackColor = System.Drawing.Color.Transparent;
            this.labelUserName.Font = new System.Drawing.Font("Inter", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.Location = new System.Drawing.Point(255, 2);
            this.labelUserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(133, 33);
            this.labelUserName.TabIndex = 6;
            this.labelUserName.Text = "Tài khoản";
            this.labelUserName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNoAccount
            // 
            this.lblNoAccount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNoAccount.AutoSize = true;
            this.lblNoAccount.BackColor = System.Drawing.Color.Transparent;
            this.lblNoAccount.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoAccount.Location = new System.Drawing.Point(302, 572);
            this.lblNoAccount.Name = "lblNoAccount";
            this.lblNoAccount.Size = new System.Drawing.Size(169, 19);
            this.lblNoAccount.TabIndex = 13;
            this.lblNoAccount.Text = "Bạn đã có tài khoản?";
            this.lblNoAccount.Click += new System.EventHandler(this.lblNoAccount_Click);
            // 
            // lblThongBao
            // 
            this.lblThongBao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblThongBao.AutoSize = true;
            this.lblThongBao.BackColor = System.Drawing.Color.Transparent;
            this.lblThongBao.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongBao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblThongBao.Location = new System.Drawing.Point(244, 387);
            this.lblThongBao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(322, 19);
            this.lblThongBao.TabIndex = 9;
            this.lblThongBao.Text = "hiện thông báo về mật khẩu và tài khoản";
            // 
            // lblSignIn
            // 
            this.lblSignIn.BackColor = System.Drawing.Color.Transparent;
            this.lblSignIn.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSignIn.Font = new System.Drawing.Font("Inter", 40.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignIn.Location = new System.Drawing.Point(0, 0);
            this.lblSignIn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSignIn.Name = "lblSignIn";
            this.lblSignIn.Size = new System.Drawing.Size(800, 133);
            this.lblSignIn.TabIndex = 3;
            this.lblSignIn.Text = "Đăng ký";
            this.lblSignIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelUsername
            // 
            this.panelUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelUsername.BackColor = System.Drawing.Color.Transparent;
            this.panelUsername.Controls.Add(this.tbcUserName);
            this.panelUsername.Controls.Add(this.labelUserName);
            this.panelUsername.Location = new System.Drawing.Point(3, 136);
            this.panelUsername.Name = "panelUsername";
            this.panelUsername.Size = new System.Drawing.Size(798, 74);
            this.panelUsername.TabIndex = 11;
            // 
            // panelPassword
            // 
            this.panelPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPassword.BackColor = System.Drawing.Color.Transparent;
            this.panelPassword.Controls.Add(this.iPBxShowHidePasword);
            this.panelPassword.Controls.Add(this.labelPasword);
            this.panelPassword.Controls.Add(this.tbcPassword);
            this.panelPassword.Location = new System.Drawing.Point(3, 216);
            this.panelPassword.Name = "panelPassword";
            this.panelPassword.Size = new System.Drawing.Size(800, 79);
            this.panelPassword.TabIndex = 12;
            // 
            // panelBackground
            // 
            this.panelBackground.Controls.Add(this.panel1);
            this.panelBackground.Controls.Add(this.lblNoAccount);
            this.panelBackground.Controls.Add(this.SignInButton);
            this.panelBackground.Controls.Add(this.lblThongBao);
            this.panelBackground.Controls.Add(this.lblSignIn);
            this.panelBackground.Controls.Add(this.panelUsername);
            this.panelBackground.Controls.Add(this.panelPassword);
            this.panelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackground.Location = new System.Drawing.Point(0, 0);
            this.panelBackground.Margin = new System.Windows.Forms.Padding(2);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Size = new System.Drawing.Size(800, 626);
            this.panelBackground.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.tbcEmail);
            this.panel1.Location = new System.Drawing.Point(3, 301);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 79);
            this.panel1.TabIndex = 17;
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Inter", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(257, -1);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(81, 33);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Email";
            // 
            // tbcEmail
            // 
            this.tbcEmail.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbcEmail.ForeColor = System.Drawing.Color.White;
            this.tbcEmail.Location = new System.Drawing.Point(263, 35);
            this.tbcEmail.Name = "tbcEmail";
            this.tbcEmail.PasswordChar = '\0';
            this.tbcEmail.Size = new System.Drawing.Size(271, 36);
            this.tbcEmail.TabIndex = 8;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 626);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panelBackground);
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            this.Load += new System.EventHandler(this.SignUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPBxShowHidePasword)).EndInit();
            this.panelUsername.ResumeLayout(false);
            this.panelUsername.PerformLayout();
            this.panelPassword.ResumeLayout(false);
            this.panelPassword.PerformLayout();
            this.panelBackground.ResumeLayout(false);
            this.panelBackground.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconPictureBox btnExit;
        private Custom.TextBox_Custom tbcPassword;
        private Extra.BlackWhiteButton SignInButton;
        private FontAwesome.Sharp.IconPictureBox iPBxShowHidePasword;
        private System.Windows.Forms.Label labelPasword;
        private Custom.TextBox_Custom tbcUserName;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label lblNoAccount;
        private System.Windows.Forms.Label lblThongBao;
        private System.Windows.Forms.Label lblSignIn;
        private System.Windows.Forms.Panel panelUsername;
        private System.Windows.Forms.Panel panelPassword;
        private System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblEmail;
        private Custom.TextBox_Custom tbcEmail;
    }
}