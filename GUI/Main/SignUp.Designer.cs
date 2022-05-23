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
            this.iPBxShowHidePasword = new FontAwesome.Sharp.IconPictureBox();
            this.labelPasword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblYesAccount = new System.Windows.Forms.Label();
            this.lblThongBao = new System.Windows.Forms.Label();
            this.lblSignIn = new System.Windows.Forms.Label();
            this.panelUsername = new System.Windows.Forms.Panel();
            this.iPBCheckUsername = new FontAwesome.Sharp.IconPictureBox();
            this.tbcUsername = new ChinChin.Custom.TextBox_Custom();
            this.panelPassword = new System.Windows.Forms.Panel();
            this.tbcPassword = new ChinChin.Custom.TextBox_Custom();
            this.panelBackground = new System.Windows.Forms.Panel();
            this.pnlThongBao = new System.Windows.Forms.Panel();
            this.pnlEmail = new System.Windows.Forms.Panel();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbcEmail = new ChinChin.Custom.TextBox_Custom();
            this.pnlRewrite = new System.Windows.Forms.Panel();
            this.iPBxShowHideRewritePasword = new FontAwesome.Sharp.IconPictureBox();
            this.lblRewritePassword = new System.Windows.Forms.Label();
            this.tbcRewritePassword = new ChinChin.Custom.TextBox_Custom();
            this.SignInButton = new ChinChin.Extra.BlackWhiteButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPBxShowHidePasword)).BeginInit();
            this.panelUsername.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iPBCheckUsername)).BeginInit();
            this.panelPassword.SuspendLayout();
            this.panelBackground.SuspendLayout();
            this.pnlThongBao.SuspendLayout();
            this.pnlEmail.SuspendLayout();
            this.pnlRewrite.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iPBxShowHideRewritePasword)).BeginInit();
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
            this.iPBxShowHidePasword.Click += new System.EventHandler(this.iPBxShowHidePasword_Click);
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
            // lblUsername
            // 
            this.lblUsername.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Inter", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(255, 2);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(200, 33);
            this.lblUsername.TabIndex = 6;
            this.lblUsername.Text = "Tên đăng nhập";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblYesAccount
            // 
            this.lblYesAccount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblYesAccount.AutoSize = true;
            this.lblYesAccount.BackColor = System.Drawing.Color.Transparent;
            this.lblYesAccount.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYesAccount.Location = new System.Drawing.Point(326, 682);
            this.lblYesAccount.Name = "lblYesAccount";
            this.lblYesAccount.Size = new System.Drawing.Size(169, 19);
            this.lblYesAccount.TabIndex = 13;
            this.lblYesAccount.Text = "Bạn đã có tài khoản?";
            this.lblYesAccount.Click += new System.EventHandler(this.lblNoAccount_Click);
            this.lblYesAccount.MouseLeave += new System.EventHandler(this.lblYesAccount_MouseLeave);
            this.lblYesAccount.MouseHover += new System.EventHandler(this.lblYesAccount_MouseHover);
            // 
            // lblThongBao
            // 
            this.lblThongBao.BackColor = System.Drawing.Color.Transparent;
            this.lblThongBao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblThongBao.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongBao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblThongBao.Location = new System.Drawing.Point(0, 0);
            this.lblThongBao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(801, 58);
            this.lblThongBao.TabIndex = 9;
            this.lblThongBao.Text = "hiện thông báo về mật khẩu và tài khoản";
            this.lblThongBao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.panelUsername.Controls.Add(this.iPBCheckUsername);
            this.panelUsername.Controls.Add(this.tbcUsername);
            this.panelUsername.Controls.Add(this.lblUsername);
            this.panelUsername.Location = new System.Drawing.Point(3, 136);
            this.panelUsername.Name = "panelUsername";
            this.panelUsername.Size = new System.Drawing.Size(798, 74);
            this.panelUsername.TabIndex = 11;
            // 
            // iPBCheckUsername
            // 
            this.iPBCheckUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iPBCheckUsername.BackColor = System.Drawing.Color.White;
            this.iPBCheckUsername.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iPBCheckUsername.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.iPBCheckUsername.IconColor = System.Drawing.SystemColors.ControlText;
            this.iPBCheckUsername.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iPBCheckUsername.IconSize = 25;
            this.iPBCheckUsername.Location = new System.Drawing.Point(537, 47);
            this.iPBCheckUsername.Margin = new System.Windows.Forms.Padding(2);
            this.iPBCheckUsername.Name = "iPBCheckUsername";
            this.iPBCheckUsername.Size = new System.Drawing.Size(29, 25);
            this.iPBCheckUsername.TabIndex = 17;
            this.iPBCheckUsername.TabStop = false;
            this.iPBCheckUsername.Visible = false;
            // 
            // tbcUsername
            // 
            this.tbcUsername.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbcUsername.ForeColor = System.Drawing.Color.White;
            this.tbcUsername.Location = new System.Drawing.Point(261, 38);
            this.tbcUsername.Name = "tbcUsername";
            this.tbcUsername.PasswordChar = '\0';
            this.tbcUsername.Size = new System.Drawing.Size(271, 36);
            this.tbcUsername.TabIndex = 7;
            this.tbcUsername.TextChanged += new System.EventHandler(this.tbcUsername_TextChanged);
            // 
            // panelPassword
            // 
            this.panelPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPassword.BackColor = System.Drawing.Color.Transparent;
            this.panelPassword.Controls.Add(this.iPBxShowHidePasword);
            this.panelPassword.Controls.Add(this.labelPasword);
            this.panelPassword.Controls.Add(this.tbcPassword);
            this.panelPassword.Location = new System.Drawing.Point(0, 301);
            this.panelPassword.Name = "panelPassword";
            this.panelPassword.Size = new System.Drawing.Size(800, 79);
            this.panelPassword.TabIndex = 12;
            // 
            // tbcPassword
            // 
            this.tbcPassword.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbcPassword.ForeColor = System.Drawing.Color.White;
            this.tbcPassword.Location = new System.Drawing.Point(263, 35);
            this.tbcPassword.Name = "tbcPassword";
            this.tbcPassword.PasswordChar = '*';
            this.tbcPassword.Size = new System.Drawing.Size(271, 36);
            this.tbcPassword.TabIndex = 8;
            // 
            // panelBackground
            // 
            this.panelBackground.Controls.Add(this.pnlThongBao);
            this.panelBackground.Controls.Add(this.pnlEmail);
            this.panelBackground.Controls.Add(this.pnlRewrite);
            this.panelBackground.Controls.Add(this.lblYesAccount);
            this.panelBackground.Controls.Add(this.SignInButton);
            this.panelBackground.Controls.Add(this.lblSignIn);
            this.panelBackground.Controls.Add(this.panelUsername);
            this.panelBackground.Controls.Add(this.panelPassword);
            this.panelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackground.Location = new System.Drawing.Point(0, 0);
            this.panelBackground.Margin = new System.Windows.Forms.Padding(2);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Size = new System.Drawing.Size(800, 726);
            this.panelBackground.TabIndex = 11;
            // 
            // pnlThongBao
            // 
            this.pnlThongBao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlThongBao.BackColor = System.Drawing.Color.Transparent;
            this.pnlThongBao.Controls.Add(this.lblThongBao);
            this.pnlThongBao.Location = new System.Drawing.Point(0, 471);
            this.pnlThongBao.Name = "pnlThongBao";
            this.pnlThongBao.Size = new System.Drawing.Size(801, 58);
            this.pnlThongBao.TabIndex = 19;
            // 
            // pnlEmail
            // 
            this.pnlEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlEmail.BackColor = System.Drawing.Color.Transparent;
            this.pnlEmail.Controls.Add(this.lblEmail);
            this.pnlEmail.Controls.Add(this.tbcEmail);
            this.pnlEmail.Location = new System.Drawing.Point(3, 216);
            this.pnlEmail.Name = "pnlEmail";
            this.pnlEmail.Size = new System.Drawing.Size(800, 79);
            this.pnlEmail.TabIndex = 18;
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
            // pnlRewrite
            // 
            this.pnlRewrite.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlRewrite.BackColor = System.Drawing.Color.Transparent;
            this.pnlRewrite.Controls.Add(this.iPBxShowHideRewritePasword);
            this.pnlRewrite.Controls.Add(this.lblRewritePassword);
            this.pnlRewrite.Controls.Add(this.tbcRewritePassword);
            this.pnlRewrite.Location = new System.Drawing.Point(0, 386);
            this.pnlRewrite.Name = "pnlRewrite";
            this.pnlRewrite.Size = new System.Drawing.Size(800, 79);
            this.pnlRewrite.TabIndex = 17;
            // 
            // iPBxShowHideRewritePasword
            // 
            this.iPBxShowHideRewritePasword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iPBxShowHideRewritePasword.BackColor = System.Drawing.Color.White;
            this.iPBxShowHideRewritePasword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iPBxShowHideRewritePasword.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.iPBxShowHideRewritePasword.IconColor = System.Drawing.SystemColors.ControlText;
            this.iPBxShowHideRewritePasword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iPBxShowHideRewritePasword.IconSize = 25;
            this.iPBxShowHideRewritePasword.Location = new System.Drawing.Point(503, 44);
            this.iPBxShowHideRewritePasword.Margin = new System.Windows.Forms.Padding(2);
            this.iPBxShowHideRewritePasword.Name = "iPBxShowHideRewritePasword";
            this.iPBxShowHideRewritePasword.Size = new System.Drawing.Size(29, 25);
            this.iPBxShowHideRewritePasword.TabIndex = 17;
            this.iPBxShowHideRewritePasword.TabStop = false;
            this.iPBxShowHideRewritePasword.Click += new System.EventHandler(this.iPBxShowHideRewritePasword_Click);
            // 
            // lblRewritePassword
            // 
            this.lblRewritePassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblRewritePassword.AutoSize = true;
            this.lblRewritePassword.BackColor = System.Drawing.Color.Transparent;
            this.lblRewritePassword.Font = new System.Drawing.Font("Inter", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRewritePassword.Location = new System.Drawing.Point(257, -1);
            this.lblRewritePassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRewritePassword.Name = "lblRewritePassword";
            this.lblRewritePassword.Size = new System.Drawing.Size(238, 33);
            this.lblRewritePassword.TabIndex = 7;
            this.lblRewritePassword.Text = "Nhập lại mật khẩu";
            // 
            // tbcRewritePassword
            // 
            this.tbcRewritePassword.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbcRewritePassword.ForeColor = System.Drawing.Color.White;
            this.tbcRewritePassword.Location = new System.Drawing.Point(263, 35);
            this.tbcRewritePassword.Name = "tbcRewritePassword";
            this.tbcRewritePassword.PasswordChar = '*';
            this.tbcRewritePassword.Size = new System.Drawing.Size(271, 36);
            this.tbcRewritePassword.TabIndex = 8;
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
            this.SignInButton.Location = new System.Drawing.Point(266, 548);
            this.SignInButton.Margin = new System.Windows.Forms.Padding(2);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(271, 122);
            this.SignInButton.TabIndex = 10;
            this.SignInButton.Text = "ĐĂNG KÝ";
            this.SignInButton.TextColor = System.Drawing.Color.White;
            this.SignInButton.UseVisualStyleBackColor = false;
            this.SignInButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 726);
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
            ((System.ComponentModel.ISupportInitialize)(this.iPBCheckUsername)).EndInit();
            this.panelPassword.ResumeLayout(false);
            this.panelPassword.PerformLayout();
            this.panelBackground.ResumeLayout(false);
            this.panelBackground.PerformLayout();
            this.pnlThongBao.ResumeLayout(false);
            this.pnlEmail.ResumeLayout(false);
            this.pnlEmail.PerformLayout();
            this.pnlRewrite.ResumeLayout(false);
            this.pnlRewrite.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iPBxShowHideRewritePasword)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconPictureBox btnExit;
        private Custom.TextBox_Custom tbcPassword;
        private Extra.BlackWhiteButton SignInButton;
        private FontAwesome.Sharp.IconPictureBox iPBxShowHidePasword;
        private System.Windows.Forms.Label labelPasword;
        private Custom.TextBox_Custom tbcUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblYesAccount;
        private System.Windows.Forms.Label lblThongBao;
        private System.Windows.Forms.Label lblSignIn;
        private System.Windows.Forms.Panel panelUsername;
        private System.Windows.Forms.Panel panelPassword;
        private System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.Panel pnlRewrite;
        private System.Windows.Forms.Label lblRewritePassword;
        private Custom.TextBox_Custom tbcRewritePassword;
        private System.Windows.Forms.Panel pnlEmail;
        private System.Windows.Forms.Label lblEmail;
        private Custom.TextBox_Custom tbcEmail;
        private FontAwesome.Sharp.IconPictureBox iPBxShowHideRewritePasword;
        private FontAwesome.Sharp.IconPictureBox iPBCheckUsername;
        private System.Windows.Forms.Panel pnlThongBao;
    }
}