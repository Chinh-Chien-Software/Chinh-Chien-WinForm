namespace ChinhChien.UI
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
            this.tbcUsername = new ChinhChien.Custom.TextBox_Custom();
            this.panelPassword = new System.Windows.Forms.Panel();
            this.tbcPassword = new ChinhChien.Custom.TextBox_Custom();
            this.panelBackground = new System.Windows.Forms.Panel();
            this.pnlThongBao = new System.Windows.Forms.Panel();
            this.pnlEmail = new System.Windows.Forms.Panel();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbcEmail = new ChinhChien.Custom.TextBox_Custom();
            this.pnlRewrite = new System.Windows.Forms.Panel();
            this.iPBxShowHideRewritePasword = new FontAwesome.Sharp.IconPictureBox();
            this.lblRewritePassword = new System.Windows.Forms.Label();
            this.tbcRewritePassword = new ChinhChien.Custom.TextBox_Custom();
            this.SignInButton = new ChinhChien.Extra.BlackWhiteButton();
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
            this.btnExit.IconSize = 59;
            this.btnExit.Location = new System.Drawing.Point(429, 14);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(61, 59);
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
            this.iPBxShowHidePasword.IconSize = 31;
            this.iPBxShowHidePasword.Location = new System.Drawing.Point(392, 54);
            this.iPBxShowHidePasword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iPBxShowHidePasword.Name = "iPBxShowHidePasword";
            this.iPBxShowHidePasword.Size = new System.Drawing.Size(39, 31);
            this.iPBxShowHidePasword.TabIndex = 16;
            this.iPBxShowHidePasword.TabStop = false;
            this.iPBxShowHidePasword.Click += new System.EventHandler(this.iPBxShowHidePasword_Click);
            // 
            // labelPasword
            // 
            this.labelPasword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelPasword.AutoSize = true;
            this.labelPasword.BackColor = System.Drawing.Color.Transparent;
            this.labelPasword.Font = new System.Drawing.Font("Cascadia Code", 19.8F);
            this.labelPasword.Location = new System.Drawing.Point(62, -1);
            this.labelPasword.Name = "labelPasword";
            this.labelPasword.Size = new System.Drawing.Size(171, 44);
            this.labelPasword.TabIndex = 7;
            this.labelPasword.Text = "Mật khẩu";
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Cascadia Code", 19.8F);
            this.lblUsername.Location = new System.Drawing.Point(59, 2);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(266, 44);
            this.lblUsername.TabIndex = 6;
            this.lblUsername.Text = "Tên đăng nhập";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblYesAccount
            // 
            this.lblYesAccount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblYesAccount.AutoSize = true;
            this.lblYesAccount.BackColor = System.Drawing.Color.Transparent;
            this.lblYesAccount.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold);
            this.lblYesAccount.Location = new System.Drawing.Point(120, 842);
            this.lblYesAccount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYesAccount.Name = "lblYesAccount";
            this.lblYesAccount.Size = new System.Drawing.Size(252, 27);
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
            this.lblThongBao.Font = new System.Drawing.Font("Cascadia Code", 10F, System.Drawing.FontStyle.Bold);
            this.lblThongBao.ForeColor = System.Drawing.Color.Red;
            this.lblThongBao.Location = new System.Drawing.Point(0, 0);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(506, 71);
            this.lblThongBao.TabIndex = 9;
            this.lblThongBao.Text = "hiện thông báo về mật khẩu và tài khoản";
            this.lblThongBao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblThongBao.Visible = false;
            // 
            // lblSignIn
            // 
            this.lblSignIn.BackColor = System.Drawing.Color.Transparent;
            this.lblSignIn.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSignIn.Font = new System.Drawing.Font("Cascadia Code", 40.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignIn.Location = new System.Drawing.Point(0, 0);
            this.lblSignIn.Name = "lblSignIn";
            this.lblSignIn.Size = new System.Drawing.Size(505, 164);
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
            this.panelUsername.Location = new System.Drawing.Point(4, 167);
            this.panelUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelUsername.Name = "panelUsername";
            this.panelUsername.Size = new System.Drawing.Size(502, 91);
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
            this.iPBCheckUsername.IconSize = 31;
            this.iPBCheckUsername.Location = new System.Drawing.Point(435, 58);
            this.iPBCheckUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iPBCheckUsername.Name = "iPBCheckUsername";
            this.iPBCheckUsername.Size = new System.Drawing.Size(39, 31);
            this.iPBCheckUsername.TabIndex = 17;
            this.iPBCheckUsername.TabStop = false;
            this.iPBCheckUsername.Visible = false;
            // 
            // tbcUsername
            // 
            this.tbcUsername.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbcUsername.ForeColor = System.Drawing.Color.White;
            this.tbcUsername.Location = new System.Drawing.Point(67, 47);
            this.tbcUsername.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbcUsername.Name = "tbcUsername";
            this.tbcUsername.PasswordChar = '\0';
            this.tbcUsername.Size = new System.Drawing.Size(361, 44);
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
            this.panelPassword.Location = new System.Drawing.Point(0, 370);
            this.panelPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelPassword.Name = "panelPassword";
            this.panelPassword.Size = new System.Drawing.Size(505, 97);
            this.panelPassword.TabIndex = 12;
            // 
            // tbcPassword
            // 
            this.tbcPassword.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbcPassword.ForeColor = System.Drawing.Color.White;
            this.tbcPassword.Location = new System.Drawing.Point(70, 43);
            this.tbcPassword.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbcPassword.Name = "tbcPassword";
            this.tbcPassword.PasswordChar = '*';
            this.tbcPassword.Size = new System.Drawing.Size(361, 44);
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
            this.panelBackground.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Size = new System.Drawing.Size(505, 894);
            this.panelBackground.TabIndex = 11;
            // 
            // pnlThongBao
            // 
            this.pnlThongBao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlThongBao.BackColor = System.Drawing.Color.Transparent;
            this.pnlThongBao.Controls.Add(this.lblThongBao);
            this.pnlThongBao.Location = new System.Drawing.Point(0, 580);
            this.pnlThongBao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlThongBao.Name = "pnlThongBao";
            this.pnlThongBao.Size = new System.Drawing.Size(506, 71);
            this.pnlThongBao.TabIndex = 19;
            // 
            // pnlEmail
            // 
            this.pnlEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlEmail.BackColor = System.Drawing.Color.Transparent;
            this.pnlEmail.Controls.Add(this.lblEmail);
            this.pnlEmail.Controls.Add(this.tbcEmail);
            this.pnlEmail.Location = new System.Drawing.Point(4, 266);
            this.pnlEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlEmail.Name = "pnlEmail";
            this.pnlEmail.Size = new System.Drawing.Size(505, 97);
            this.pnlEmail.TabIndex = 18;
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Cascadia Code", 19.8F);
            this.lblEmail.Location = new System.Drawing.Point(62, -1);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(114, 44);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Email";
            // 
            // tbcEmail
            // 
            this.tbcEmail.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbcEmail.ForeColor = System.Drawing.Color.White;
            this.tbcEmail.Location = new System.Drawing.Point(70, 43);
            this.tbcEmail.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbcEmail.Name = "tbcEmail";
            this.tbcEmail.PasswordChar = '\0';
            this.tbcEmail.Size = new System.Drawing.Size(361, 44);
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
            this.pnlRewrite.Location = new System.Drawing.Point(0, 475);
            this.pnlRewrite.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlRewrite.Name = "pnlRewrite";
            this.pnlRewrite.Size = new System.Drawing.Size(505, 97);
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
            this.iPBxShowHideRewritePasword.IconSize = 31;
            this.iPBxShowHideRewritePasword.Location = new System.Drawing.Point(390, 54);
            this.iPBxShowHideRewritePasword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iPBxShowHideRewritePasword.Name = "iPBxShowHideRewritePasword";
            this.iPBxShowHideRewritePasword.Size = new System.Drawing.Size(39, 31);
            this.iPBxShowHideRewritePasword.TabIndex = 17;
            this.iPBxShowHideRewritePasword.TabStop = false;
            this.iPBxShowHideRewritePasword.Click += new System.EventHandler(this.iPBxShowHideRewritePasword_Click);
            // 
            // lblRewritePassword
            // 
            this.lblRewritePassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblRewritePassword.AutoSize = true;
            this.lblRewritePassword.BackColor = System.Drawing.Color.Transparent;
            this.lblRewritePassword.Font = new System.Drawing.Font("Cascadia Code", 19.8F);
            this.lblRewritePassword.Location = new System.Drawing.Point(62, -1);
            this.lblRewritePassword.Name = "lblRewritePassword";
            this.lblRewritePassword.Size = new System.Drawing.Size(342, 44);
            this.lblRewritePassword.TabIndex = 7;
            this.lblRewritePassword.Text = "Nhập lại mật khẩu";
            // 
            // tbcRewritePassword
            // 
            this.tbcRewritePassword.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbcRewritePassword.ForeColor = System.Drawing.Color.White;
            this.tbcRewritePassword.Location = new System.Drawing.Point(70, 43);
            this.tbcRewritePassword.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbcRewritePassword.Name = "tbcRewritePassword";
            this.tbcRewritePassword.PasswordChar = '*';
            this.tbcRewritePassword.Size = new System.Drawing.Size(361, 44);
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
            this.SignInButton.Font = new System.Drawing.Font("Cascadia Code", 20F, System.Drawing.FontStyle.Bold);
            this.SignInButton.ForeColor = System.Drawing.Color.White;
            this.SignInButton.Location = new System.Drawing.Point(74, 653);
            this.SignInButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(361, 150);
            this.SignInButton.TabIndex = 10;
            this.SignInButton.Text = "ĐĂNG KÝ";
            this.SignInButton.TextColor = System.Drawing.Color.White;
            this.SignInButton.UseVisualStyleBackColor = false;
            this.SignInButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(505, 894);
            this.ControlBox = false;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panelBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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