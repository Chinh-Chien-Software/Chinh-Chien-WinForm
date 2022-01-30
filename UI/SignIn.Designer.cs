
namespace ChinChin
{
    partial class SignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
            this.panelLeft = new System.Windows.Forms.Panel();
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.panelRight = new System.Windows.Forms.Panel();
            this.txtBxUsername = new System.Windows.Forms.TextBox();
            this.labelThongBao = new System.Windows.Forms.Label();
            this.btnExit = new FontAwesome.Sharp.IconPictureBox();
            this.lblSignIn = new System.Windows.Forms.Label();
            this.labelPasword = new System.Windows.Forms.Label();
            this.ckBxRememberSignIn = new System.Windows.Forms.CheckBox();
            this.labelUserName = new System.Windows.Forms.Label();
            this.txtBxPassword = new System.Windows.Forms.TextBox();
            this.panelUsername = new System.Windows.Forms.Panel();
            this.panelPassword = new System.Windows.Forms.Panel();
            this.SignInButton = new ChinChin.Extra.BlackWhiteButton();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.panelUsername.SuspendLayout();
            this.panelPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.Black;
            this.panelLeft.Controls.Add(this.pictureBoxIcon);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(480, 878);
            this.panelLeft.TabIndex = 9;
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxIcon.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxIcon.Image = global::ChinChin.Properties.Resources.Chin_Chin_Logo_All_Black;
            this.pictureBoxIcon.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxIcon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(480, 520);
            this.pictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxIcon.TabIndex = 0;
            this.pictureBoxIcon.TabStop = false;
            // 
            // panelRight
            // 
            this.panelRight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelRight.BackgroundImage = global::ChinChin.Properties.Resources.background_1920x1920;
            this.panelRight.Controls.Add(this.SignInButton);
            this.panelRight.Controls.Add(this.labelThongBao);
            this.panelRight.Controls.Add(this.btnExit);
            this.panelRight.Controls.Add(this.lblSignIn);
            this.panelRight.Controls.Add(this.ckBxRememberSignIn);
            this.panelRight.Controls.Add(this.panelUsername);
            this.panelRight.Controls.Add(this.panelPassword);
            this.panelRight.Location = new System.Drawing.Point(480, 0);
            this.panelRight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(960, 878);
            this.panelRight.TabIndex = 10;
            // 
            // txtBxUsername
            // 
            this.txtBxUsername.BackColor = System.Drawing.Color.White;
            this.txtBxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxUsername.Location = new System.Drawing.Point(492, 8);
            this.txtBxUsername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBxUsername.Name = "txtBxUsername";
            this.txtBxUsername.Size = new System.Drawing.Size(226, 37);
            this.txtBxUsername.TabIndex = 1;
            this.txtBxUsername.TextChanged += new System.EventHandler(this.txtBxUsername_TextChanged);
            this.txtBxUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBxUsername_KeyDown);
            // 
            // labelThongBao
            // 
            this.labelThongBao.AutoSize = true;
            this.labelThongBao.BackColor = System.Drawing.Color.Transparent;
            this.labelThongBao.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelThongBao.ForeColor = System.Drawing.Color.Lime;
            this.labelThongBao.Location = new System.Drawing.Point(327, 307);
            this.labelThongBao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelThongBao.Name = "labelThongBao";
            this.labelThongBao.Size = new System.Drawing.Size(331, 19);
            this.labelThongBao.TabIndex = 9;
            this.labelThongBao.Text = "hiện thông báo về mật khẩu và username";
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
            this.btnExit.Location = new System.Drawing.Point(905, 9);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(46, 48);
            this.btnExit.TabIndex = 8;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblSignIn
            // 
            this.lblSignIn.BackColor = System.Drawing.Color.Transparent;
            this.lblSignIn.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSignIn.Font = new System.Drawing.Font("Inter", 40.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignIn.Location = new System.Drawing.Point(0, 0);
            this.lblSignIn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSignIn.Name = "lblSignIn";
            this.lblSignIn.Size = new System.Drawing.Size(960, 133);
            this.lblSignIn.TabIndex = 3;
            this.lblSignIn.Text = "Đăng nhập";
            this.lblSignIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPasword
            // 
            this.labelPasword.AutoSize = true;
            this.labelPasword.BackColor = System.Drawing.Color.Transparent;
            this.labelPasword.Font = new System.Drawing.Font("Inter", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPasword.Location = new System.Drawing.Point(93, 9);
            this.labelPasword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPasword.Name = "labelPasword";
            this.labelPasword.Size = new System.Drawing.Size(134, 33);
            this.labelPasword.TabIndex = 7;
            this.labelPasword.Text = "Password";
            // 
            // ckBxRememberSignIn
            // 
            this.ckBxRememberSignIn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ckBxRememberSignIn.BackColor = System.Drawing.Color.Transparent;
            this.ckBxRememberSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckBxRememberSignIn.Location = new System.Drawing.Point(406, 248);
            this.ckBxRememberSignIn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ckBxRememberSignIn.Name = "ckBxRememberSignIn";
            this.ckBxRememberSignIn.Size = new System.Drawing.Size(187, 24);
            this.ckBxRememberSignIn.TabIndex = 5;
            this.ckBxRememberSignIn.Text = "Ghi nhớ đăng nhập";
            this.ckBxRememberSignIn.UseVisualStyleBackColor = false;
            // 
            // labelUserName
            // 
            this.labelUserName.BackColor = System.Drawing.Color.Transparent;
            this.labelUserName.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelUserName.Font = new System.Drawing.Font("Inter", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.Location = new System.Drawing.Point(0, 0);
            this.labelUserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(488, 50);
            this.labelUserName.TabIndex = 6;
            this.labelUserName.Text = "Username";
            this.labelUserName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelUserName.Click += new System.EventHandler(this.labelUserName_Click);
            // 
            // txtBxPassword
            // 
            this.txtBxPassword.BackColor = System.Drawing.Color.White;
            this.txtBxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxPassword.Location = new System.Drawing.Point(308, 9);
            this.txtBxPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBxPassword.Name = "txtBxPassword";
            this.txtBxPassword.PasswordChar = '*';
            this.txtBxPassword.Size = new System.Drawing.Size(226, 37);
            this.txtBxPassword.TabIndex = 2;
            this.txtBxPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBxPassword_KeyDown);
            // 
            // panelUsername
            // 
            this.panelUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelUsername.BackColor = System.Drawing.Color.White;
            this.panelUsername.Controls.Add(this.txtBxUsername);
            this.panelUsername.Controls.Add(this.labelUserName);
            this.panelUsername.Location = new System.Drawing.Point(0, 136);
            this.panelUsername.Name = "panelUsername";
            this.panelUsername.Size = new System.Drawing.Size(960, 50);
            this.panelUsername.TabIndex = 11;
            // 
            // panelPassword
            // 
            this.panelPassword.BackColor = System.Drawing.Color.Transparent;
            this.panelPassword.Controls.Add(this.txtBxPassword);
            this.panelPassword.Controls.Add(this.labelPasword);
            this.panelPassword.Location = new System.Drawing.Point(210, 186);
            this.panelPassword.Name = "panelPassword";
            this.panelPassword.Size = new System.Drawing.Size(568, 50);
            this.panelPassword.TabIndex = 12;
            // 
            // SignInButton
            // 
            this.SignInButton.BackColor = System.Drawing.Color.Black;
            this.SignInButton.BackgroundColor = System.Drawing.Color.Black;
            this.SignInButton.BorderColor = System.Drawing.Color.Black;
            this.SignInButton.BorderRadius = 0;
            this.SignInButton.BorderSize = 0;
            this.SignInButton.FlatAppearance.BorderSize = 0;
            this.SignInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignInButton.Font = new System.Drawing.Font("Inter", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInButton.ForeColor = System.Drawing.Color.White;
            this.SignInButton.Location = new System.Drawing.Point(386, 391);
            this.SignInButton.Margin = new System.Windows.Forms.Padding(2);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(262, 122);
            this.SignInButton.TabIndex = 10;
            this.SignInButton.Text = "ĐĂNG NHẬP";
            this.SignInButton.TextColor = System.Drawing.Color.White;
            this.SignInButton.UseVisualStyleBackColor = false;
            this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click);
            this.SignInButton.MouseHover += new System.EventHandler(this.SignInButton_MouseHover);
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1440, 878);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelRight);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SignIn_Load);
            this.panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.panelUsername.ResumeLayout(false);
            this.panelUsername.PerformLayout();
            this.panelPassword.ResumeLayout(false);
            this.panelPassword.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtBxUsername;
        private System.Windows.Forms.TextBox txtBxPassword;
        private System.Windows.Forms.Label lblSignIn;
        private System.Windows.Forms.CheckBox ckBxRememberSignIn;
        private System.Windows.Forms.Label labelPasword;
        private System.Windows.Forms.Label labelUserName;
        private FontAwesome.Sharp.IconPictureBox btnExit;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.PictureBox pictureBoxIcon;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Label labelThongBao;
        private Extra.BlackWhiteButton SignInButton;
        private System.Windows.Forms.Panel panelUsername;
        private System.Windows.Forms.Panel panelPassword;
    }
}

