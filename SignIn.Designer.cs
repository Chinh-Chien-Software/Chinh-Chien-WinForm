
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
            this.txtBxUsername = new System.Windows.Forms.TextBox();
            this.txtBxPassword = new System.Windows.Forms.TextBox();
            this.lblSignIn = new System.Windows.Forms.Label();
            this.ckBxRememberSignIn = new System.Windows.Forms.CheckBox();
            this.labelPasword = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.panelRight = new System.Windows.Forms.Panel();
            this.SignInButton = new ChinChin.Extra.BlackWhiteButton();
            this.labelThongBao = new System.Windows.Forms.Label();
            this.btnExit = new FontAwesome.Sharp.IconPictureBox();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBxUsername
            // 
            this.txtBxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxUsername.Location = new System.Drawing.Point(260, 177);
            this.txtBxUsername.Name = "txtBxUsername";
            this.txtBxUsername.Size = new System.Drawing.Size(300, 45);
            this.txtBxUsername.TabIndex = 1;
            this.txtBxUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBxUsername_KeyDown);
            // 
            // txtBxPassword
            // 
            this.txtBxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxPassword.Location = new System.Drawing.Point(260, 233);
            this.txtBxPassword.Name = "txtBxPassword";
            this.txtBxPassword.PasswordChar = '*';
            this.txtBxPassword.Size = new System.Drawing.Size(300, 45);
            this.txtBxPassword.TabIndex = 2;
            this.txtBxPassword.Tag = "";
            this.txtBxPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBxPassword_KeyDown);
            // 
            // lblSignIn
            // 
            this.lblSignIn.AutoSize = true;
            this.lblSignIn.Font = new System.Drawing.Font("Inter", 40.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignIn.Location = new System.Drawing.Point(6, 27);
            this.lblSignIn.Name = "lblSignIn";
            this.lblSignIn.Size = new System.Drawing.Size(390, 82);
            this.lblSignIn.TabIndex = 3;
            this.lblSignIn.Text = "Đăng nhập";
            this.lblSignIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ckBxRememberSignIn
            // 
            this.ckBxRememberSignIn.AutoSize = true;
            this.ckBxRememberSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckBxRememberSignIn.Location = new System.Drawing.Point(161, 292);
            this.ckBxRememberSignIn.Name = "ckBxRememberSignIn";
            this.ckBxRememberSignIn.Size = new System.Drawing.Size(171, 24);
            this.ckBxRememberSignIn.TabIndex = 5;
            this.ckBxRememberSignIn.Text = "Ghi nhớ đăng nhập";
            this.ckBxRememberSignIn.UseVisualStyleBackColor = true;
            // 
            // labelPasword
            // 
            this.labelPasword.AutoSize = true;
            this.labelPasword.Font = new System.Drawing.Font("Inter", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPasword.Location = new System.Drawing.Point(13, 237);
            this.labelPasword.Name = "labelPasword";
            this.labelPasword.Size = new System.Drawing.Size(161, 40);
            this.labelPasword.TabIndex = 7;
            this.labelPasword.Text = "Password";
            this.labelPasword.Click += new System.EventHandler(this.labelPasword_Click);
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Inter", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.Location = new System.Drawing.Point(13, 181);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(172, 40);
            this.labelUserName.TabIndex = 6;
            this.labelUserName.Text = "Username";
            this.labelUserName.Click += new System.EventHandler(this.labelUserName_Click);
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.Black;
            this.panelLeft.Controls.Add(this.pictureBoxIcon);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(640, 1080);
            this.panelLeft.TabIndex = 9;
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxIcon.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxIcon.Image = global::ChinChin.Properties.Resources.Chin_Chin_Logo_All_Black;
            this.pictureBoxIcon.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(640, 640);
            this.pictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxIcon.TabIndex = 0;
            this.pictureBoxIcon.TabStop = false;
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.SignInButton);
            this.panelRight.Controls.Add(this.labelThongBao);
            this.panelRight.Controls.Add(this.btnExit);
            this.panelRight.Controls.Add(this.lblSignIn);
            this.panelRight.Controls.Add(this.labelPasword);
            this.panelRight.Controls.Add(this.ckBxRememberSignIn);
            this.panelRight.Controls.Add(this.txtBxUsername);
            this.panelRight.Controls.Add(this.labelUserName);
            this.panelRight.Controls.Add(this.txtBxPassword);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(640, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(1280, 1080);
            this.panelRight.TabIndex = 10;
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
            this.SignInButton.Location = new System.Drawing.Point(96, 479);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(350, 150);
            this.SignInButton.TabIndex = 10;
            this.SignInButton.Text = "ĐĂNG NHẬP";
            this.SignInButton.TextColor = System.Drawing.Color.White;
            this.SignInButton.UseVisualStyleBackColor = false;
            this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click);
            this.SignInButton.MouseHover += new System.EventHandler(this.SignInButton_MouseHover);
            // 
            // labelThongBao
            // 
            this.labelThongBao.AutoSize = true;
            this.labelThongBao.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelThongBao.ForeColor = System.Drawing.Color.Lime;
            this.labelThongBao.Location = new System.Drawing.Point(17, 375);
            this.labelThongBao.Name = "labelThongBao";
            this.labelThongBao.Size = new System.Drawing.Size(67, 24);
            this.labelThongBao.TabIndex = 9;
            this.labelThongBao.Text = "label1";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btnExit.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 59;
            this.btnExit.Location = new System.Drawing.Point(1207, 11);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(61, 59);
            this.btnExit.TabIndex = 8;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelRight);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
    }
}

