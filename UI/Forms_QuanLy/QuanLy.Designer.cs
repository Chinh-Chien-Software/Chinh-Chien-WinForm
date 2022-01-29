
namespace ChinChin.FormsQuanLy
{
    partial class QuanLy
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnMinimize = new FontAwesome.Sharp.IconPictureBox();
            this.btnMaximize = new FontAwesome.Sharp.IconPictureBox();
            this.btnExit = new FontAwesome.Sharp.IconPictureBox();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelTittleBar = new System.Windows.Forms.Panel();
            this.labelTittleChildForm = new System.Windows.Forms.Label();
            this.SignInButton = new ChinChin.Extra.BlackWhiteButton();
            this.lblVersion = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Label();
            this.ChamCongBTN = new FontAwesome.Sharp.IconButton();
            this.KhoHangBTN = new FontAwesome.Sharp.IconButton();
            this.ThongKeBTN = new FontAwesome.Sharp.IconButton();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.panelTittleBar.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.White;
            this.btnMinimize.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.MinusCircle;
            this.btnMinimize.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 62;
            this.btnMinimize.Location = new System.Drawing.Point(1696, 2);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(62, 62);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.White;
            this.btnMaximize.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.ExpandArrowsAlt;
            this.btnMaximize.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximize.IconSize = 60;
            this.btnMaximize.Location = new System.Drawing.Point(1764, 2);
            this.btnMaximize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(67, 60);
            this.btnMaximize.TabIndex = 3;
            this.btnMaximize.TabStop = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click_1);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btnExit.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 62;
            this.btnExit.Location = new System.Drawing.Point(1837, 2);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(63, 62);
            this.btnExit.TabIndex = 2;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.Transparent;
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.Black;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.Black;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.IconSize = 61;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(0, 11);
            this.iconCurrentChildForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(61, 62);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelTittleBar
            // 
            this.panelTittleBar.BackColor = System.Drawing.Color.White;
            this.panelTittleBar.Controls.Add(this.btnMinimize);
            this.panelTittleBar.Controls.Add(this.btnMaximize);
            this.panelTittleBar.Controls.Add(this.btnExit);
            this.panelTittleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTittleBar.Controls.Add(this.labelTittleChildForm);
            this.panelTittleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTittleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTittleBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTittleBar.Name = "panelTittleBar";
            this.panelTittleBar.Size = new System.Drawing.Size(1902, 75);
            this.panelTittleBar.TabIndex = 7;
            this.panelTittleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTittleBar_MouseDown_1);
            // 
            // labelTittleChildForm
            // 
            this.labelTittleChildForm.AutoSize = true;
            this.labelTittleChildForm.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTittleChildForm.Location = new System.Drawing.Point(67, 33);
            this.labelTittleChildForm.Name = "labelTittleChildForm";
            this.labelTittleChildForm.Size = new System.Drawing.Size(58, 20);
            this.labelTittleChildForm.TabIndex = 1;
            this.labelTittleChildForm.Text = "Home";
            this.labelTittleChildForm.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.SignInButton.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInButton.ForeColor = System.Drawing.Color.White;
            this.SignInButton.Location = new System.Drawing.Point(242, 9);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(250, 50);
            this.SignInButton.TabIndex = 11;
            this.SignInButton.Text = "ĐĂNG XUẤT";
            this.SignInButton.TextColor = System.Drawing.Color.White;
            this.SignInButton.UseVisualStyleBackColor = false;
            this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click);
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.ForeColor = System.Drawing.Color.Black;
            this.lblVersion.Location = new System.Drawing.Point(4, 9);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(93, 20);
            this.lblVersion.TabIndex = 1;
            this.lblVersion.Text = "Version 0.2";
            // 
            // btnHome
            // 
            this.btnHome.AutoSize = true;
            this.btnHome.Font = new System.Drawing.Font("MV Boli", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.Black;
            this.btnHome.Location = new System.Drawing.Point(-4, 51);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(211, 63);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Manager";
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click_1);
            // 
            // ChamCongBTN
            // 
            this.ChamCongBTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.ChamCongBTN.FlatAppearance.BorderSize = 0;
            this.ChamCongBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChamCongBTN.Font = new System.Drawing.Font("Cascadia Code", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChamCongBTN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ChamCongBTN.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckAlt;
            this.ChamCongBTN.IconColor = System.Drawing.Color.Black;
            this.ChamCongBTN.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ChamCongBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ChamCongBTN.Location = new System.Drawing.Point(0, 400);
            this.ChamCongBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChamCongBTN.Name = "ChamCongBTN";
            this.ChamCongBTN.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.ChamCongBTN.Size = new System.Drawing.Size(498, 125);
            this.ChamCongBTN.TabIndex = 3;
            this.ChamCongBTN.Text = "LỊCH LÀM";
            this.ChamCongBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ChamCongBTN.UseVisualStyleBackColor = true;
            this.ChamCongBTN.Click += new System.EventHandler(this.ChamCongBTN_Click);
            // 
            // KhoHangBTN
            // 
            this.KhoHangBTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.KhoHangBTN.FlatAppearance.BorderSize = 0;
            this.KhoHangBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KhoHangBTN.Font = new System.Drawing.Font("Cascadia Code", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KhoHangBTN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.KhoHangBTN.IconChar = FontAwesome.Sharp.IconChar.Boxes;
            this.KhoHangBTN.IconColor = System.Drawing.Color.Black;
            this.KhoHangBTN.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.KhoHangBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.KhoHangBTN.Location = new System.Drawing.Point(0, 275);
            this.KhoHangBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.KhoHangBTN.Name = "KhoHangBTN";
            this.KhoHangBTN.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.KhoHangBTN.Size = new System.Drawing.Size(498, 125);
            this.KhoHangBTN.TabIndex = 2;
            this.KhoHangBTN.Text = "KHO HÀNG";
            this.KhoHangBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.KhoHangBTN.UseVisualStyleBackColor = true;
            this.KhoHangBTN.Click += new System.EventHandler(this.KhoHangBTN_Click_1);
            // 
            // ThongKeBTN
            // 
            this.ThongKeBTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.ThongKeBTN.FlatAppearance.BorderSize = 0;
            this.ThongKeBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ThongKeBTN.Font = new System.Drawing.Font("Cascadia Code", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThongKeBTN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ThongKeBTN.IconChar = FontAwesome.Sharp.IconChar.Dashcube;
            this.ThongKeBTN.IconColor = System.Drawing.Color.Black;
            this.ThongKeBTN.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ThongKeBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ThongKeBTN.Location = new System.Drawing.Point(0, 150);
            this.ThongKeBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ThongKeBTN.Name = "ThongKeBTN";
            this.ThongKeBTN.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.ThongKeBTN.Size = new System.Drawing.Size(498, 125);
            this.ThongKeBTN.TabIndex = 1;
            this.ThongKeBTN.Text = "THỐNG KÊ";
            this.ThongKeBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ThongKeBTN.UseVisualStyleBackColor = true;
            this.ThongKeBTN.Click += new System.EventHandler(this.ThongKeBTN_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelMenu.BackColor = System.Drawing.Color.White;
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenu.Controls.Add(this.ChamCongBTN);
            this.panelMenu.Controls.Add(this.KhoHangBTN);
            this.panelMenu.Controls.Add(this.ThongKeBTN);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.ForeColor = System.Drawing.Color.Coral;
            this.panelMenu.Location = new System.Drawing.Point(0, 75);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(500, 958);
            this.panelMenu.TabIndex = 6;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.Transparent;
            this.panelLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLogo.Controls.Add(this.SignInButton);
            this.panelLogo.Controls.Add(this.lblVersion);
            this.panelLogo.Controls.Add(this.btnHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(498, 150);
            this.panelLogo.TabIndex = 0;
            // 
            // panelDesktop
            // 
            this.panelDesktop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDesktop.BackColor = System.Drawing.Color.White;
            this.panelDesktop.BackgroundImage = global::ChinChin.Properties.Resources.background_1920x1920;
            this.panelDesktop.Location = new System.Drawing.Point(500, 75);
            this.panelDesktop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1402, 958);
            this.panelDesktop.TabIndex = 8;
            // 
            // QuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.panelTittleBar);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelDesktop);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QuanLy";
            this.Text = "QuanLy";
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.panelTittleBar.ResumeLayout(false);
            this.panelTittleBar.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private FontAwesome.Sharp.IconPictureBox btnMinimize;
        private FontAwesome.Sharp.IconPictureBox btnMaximize;
        private FontAwesome.Sharp.IconPictureBox btnExit;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Panel panelTittleBar;
        private System.Windows.Forms.Label labelTittleChildForm;
        private Extra.BlackWhiteButton SignInButton;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label btnHome;
        private FontAwesome.Sharp.IconButton ChamCongBTN;
        private FontAwesome.Sharp.IconButton KhoHangBTN;
        private FontAwesome.Sharp.IconButton ThongKeBTN;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelDesktop;
    }
}