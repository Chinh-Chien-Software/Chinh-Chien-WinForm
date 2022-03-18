
namespace ChinChin.FormsChuQuan
{
    partial class formChuQuan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formChuQuan));
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.iconButtonThucDon = new FontAwesome.Sharp.IconButton();
            this.ChamCongBTN = new FontAwesome.Sharp.IconButton();
            this.KhoHangBTN = new FontAwesome.Sharp.IconButton();
            this.ThongKeBTN = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.SignOutButton = new ChinChin.Extra.BlackWhiteButton();
            this.lblVersion = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Label();
            this.panelTittleBar = new System.Windows.Forms.Panel();
            this.btnMinimize = new FontAwesome.Sharp.IconPictureBox();
            this.btnMaximize = new FontAwesome.Sharp.IconPictureBox();
            this.btnExit = new FontAwesome.Sharp.IconPictureBox();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.labelTittleChildForm = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTittleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.White;
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(376, 61);
            this.panelDesktop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1050, 705);
            this.panelDesktop.TabIndex = 5;
            this.panelDesktop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDesktop_Paint);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.White;
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenu.Controls.Add(this.iconButtonThucDon);
            this.panelMenu.Controls.Add(this.ChamCongBTN);
            this.panelMenu.Controls.Add(this.KhoHangBTN);
            this.panelMenu.Controls.Add(this.ThongKeBTN);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.ForeColor = System.Drawing.Color.Coral;
            this.panelMenu.Location = new System.Drawing.Point(0, 61);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(376, 705);
            this.panelMenu.TabIndex = 3;
            // 
            // iconButtonThucDon
            // 
            this.iconButtonThucDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonThucDon.FlatAppearance.BorderSize = 0;
            this.iconButtonThucDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonThucDon.Font = new System.Drawing.Font("Cascadia Code", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonThucDon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconButtonThucDon.IconChar = FontAwesome.Sharp.IconChar.MugHot;
            this.iconButtonThucDon.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(108)))), ((int)(((byte)(247)))));
            this.iconButtonThucDon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonThucDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonThucDon.Location = new System.Drawing.Point(0, 428);
            this.iconButtonThucDon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.iconButtonThucDon.Name = "iconButtonThucDon";
            this.iconButtonThucDon.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.iconButtonThucDon.Size = new System.Drawing.Size(374, 102);
            this.iconButtonThucDon.TabIndex = 4;
            this.iconButtonThucDon.Text = "THỰC ĐƠN";
            this.iconButtonThucDon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonThucDon.UseVisualStyleBackColor = true;
            this.iconButtonThucDon.Click += new System.EventHandler(this.iconButtonThucDon_Click);
            // 
            // ChamCongBTN
            // 
            this.ChamCongBTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.ChamCongBTN.FlatAppearance.BorderSize = 0;
            this.ChamCongBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChamCongBTN.Font = new System.Drawing.Font("Cascadia Code", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChamCongBTN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ChamCongBTN.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckAlt;
            this.ChamCongBTN.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(108)))), ((int)(((byte)(247)))));
            this.ChamCongBTN.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ChamCongBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ChamCongBTN.Location = new System.Drawing.Point(0, 326);
            this.ChamCongBTN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ChamCongBTN.Name = "ChamCongBTN";
            this.ChamCongBTN.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.ChamCongBTN.Size = new System.Drawing.Size(374, 102);
            this.ChamCongBTN.TabIndex = 3;
            this.ChamCongBTN.Text = "CHẤM CÔNG";
            this.ChamCongBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ChamCongBTN.UseVisualStyleBackColor = true;
            this.ChamCongBTN.Click += new System.EventHandler(this.ChamCongBTN_Click_1);
            // 
            // KhoHangBTN
            // 
            this.KhoHangBTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.KhoHangBTN.FlatAppearance.BorderSize = 0;
            this.KhoHangBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KhoHangBTN.Font = new System.Drawing.Font("Cascadia Code", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KhoHangBTN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.KhoHangBTN.IconChar = FontAwesome.Sharp.IconChar.Boxes;
            this.KhoHangBTN.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(108)))), ((int)(((byte)(247)))));
            this.KhoHangBTN.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.KhoHangBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.KhoHangBTN.Location = new System.Drawing.Point(0, 224);
            this.KhoHangBTN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.KhoHangBTN.Name = "KhoHangBTN";
            this.KhoHangBTN.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.KhoHangBTN.Size = new System.Drawing.Size(374, 102);
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
            this.ThongKeBTN.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(108)))), ((int)(((byte)(247)))));
            this.ThongKeBTN.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ThongKeBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ThongKeBTN.Location = new System.Drawing.Point(0, 122);
            this.ThongKeBTN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ThongKeBTN.Name = "ThongKeBTN";
            this.ThongKeBTN.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.ThongKeBTN.Size = new System.Drawing.Size(374, 102);
            this.ThongKeBTN.TabIndex = 1;
            this.ThongKeBTN.Text = "THỐNG KÊ";
            this.ThongKeBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ThongKeBTN.UseVisualStyleBackColor = true;
            this.ThongKeBTN.Click += new System.EventHandler(this.ThongKeBTN_Click_1);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.Transparent;
            this.panelLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLogo.Controls.Add(this.SignOutButton);
            this.panelLogo.Controls.Add(this.lblVersion);
            this.panelLogo.Controls.Add(this.btnHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(374, 122);
            this.panelLogo.TabIndex = 0;
            // 
            // SignOutButton
            // 
            this.SignOutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(108)))), ((int)(((byte)(247)))));
            this.SignOutButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(108)))), ((int)(((byte)(247)))));
            this.SignOutButton.BorderColor = System.Drawing.Color.Black;
            this.SignOutButton.BorderRadius = 0;
            this.SignOutButton.BorderSize = 0;
            this.SignOutButton.FlatAppearance.BorderSize = 0;
            this.SignOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignOutButton.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignOutButton.ForeColor = System.Drawing.Color.White;
            this.SignOutButton.Location = new System.Drawing.Point(182, 7);
            this.SignOutButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SignOutButton.Name = "SignOutButton";
            this.SignOutButton.Size = new System.Drawing.Size(188, 41);
            this.SignOutButton.TabIndex = 11;
            this.SignOutButton.Text = "ĐĂNG XUẤT";
            this.SignOutButton.TextColor = System.Drawing.Color.White;
            this.SignOutButton.UseVisualStyleBackColor = false;
            this.SignOutButton.Click += new System.EventHandler(this.SignOutButton_Click);
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.ForeColor = System.Drawing.Color.Black;
            this.lblVersion.Location = new System.Drawing.Point(3, 7);
            this.lblVersion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(80, 17);
            this.lblVersion.TabIndex = 1;
            this.lblVersion.Text = "Version 0.2";
            // 
            // btnHome
            // 
            this.btnHome.AutoSize = true;
            this.btnHome.Font = new System.Drawing.Font("MV Boli", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.Black;
            this.btnHome.Location = new System.Drawing.Point(-3, 41);
            this.btnHome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(133, 50);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Owner";
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click_1);
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
            this.panelTittleBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelTittleBar.Name = "panelTittleBar";
            this.panelTittleBar.Size = new System.Drawing.Size(1426, 61);
            this.panelTittleBar.TabIndex = 4;
            this.panelTittleBar.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTittleBar_Paint);
            this.panelTittleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTittleBar_MouseDown_1);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.White;
            this.btnMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(108)))), ((int)(((byte)(247)))));
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.MinusCircle;
            this.btnMinimize.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(108)))), ((int)(((byte)(247)))));
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 46;
            this.btnMinimize.Location = new System.Drawing.Point(1272, 2);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(46, 50);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click_1);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.White;
            this.btnMaximize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(108)))), ((int)(((byte)(247)))));
            this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.ExpandArrowsAlt;
            this.btnMaximize.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(108)))), ((int)(((byte)(247)))));
            this.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximize.IconSize = 49;
            this.btnMaximize.Location = new System.Drawing.Point(1323, 2);
            this.btnMaximize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(50, 49);
            this.btnMaximize.TabIndex = 3;
            this.btnMaximize.TabStop = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click_1);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(108)))), ((int)(((byte)(247)))));
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btnExit.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(108)))), ((int)(((byte)(247)))));
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 47;
            this.btnExit.Location = new System.Drawing.Point(1378, 2);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(47, 50);
            this.btnExit.TabIndex = 2;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.Transparent;
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(108)))), ((int)(((byte)(247)))));
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(108)))), ((int)(((byte)(247)))));
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.IconSize = 46;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(0, 9);
            this.iconCurrentChildForm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(46, 50);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            this.iconCurrentChildForm.Click += new System.EventHandler(this.iconCurrentChildForm_Click);
            // 
            // labelTittleChildForm
            // 
            this.labelTittleChildForm.AutoSize = true;
            this.labelTittleChildForm.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTittleChildForm.Location = new System.Drawing.Point(50, 24);
            this.labelTittleChildForm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTittleChildForm.Name = "labelTittleChildForm";
            this.labelTittleChildForm.Size = new System.Drawing.Size(48, 17);
            this.labelTittleChildForm.TabIndex = 1;
            this.labelTittleChildForm.Text = "Home";
            this.labelTittleChildForm.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelTittleChildForm.Click += new System.EventHandler(this.labelTittleChildForm_Click);
            // 
            // formChuQuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1426, 766);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelTittleBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formChuQuan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chủ Quán";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTittleBar.ResumeLayout(false);
            this.panelTittleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton ChamCongBTN;
        private FontAwesome.Sharp.IconButton KhoHangBTN;
        private FontAwesome.Sharp.IconButton ThongKeBTN;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label btnHome;
        private System.Windows.Forms.Panel panelTittleBar;
        private FontAwesome.Sharp.IconPictureBox btnMinimize;
        private FontAwesome.Sharp.IconPictureBox btnMaximize;
        private FontAwesome.Sharp.IconPictureBox btnExit;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label labelTittleChildForm;
        private FontAwesome.Sharp.IconButton iconButtonThucDon;
        private Extra.BlackWhiteButton SignOutButton;
    }
}