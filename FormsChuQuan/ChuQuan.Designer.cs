
namespace ChinChin.FormsChuQuan
{
    partial class ChuQuan
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
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.ChamCongBTN = new FontAwesome.Sharp.IconButton();
            this.KhoHangBTN = new FontAwesome.Sharp.IconButton();
            this.ThongKeBTN = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lblVersion = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Label();
            this.panelTittleBar = new System.Windows.Forms.Panel();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.btnMaximize = new FontAwesome.Sharp.IconPictureBox();
            this.btnExit = new FontAwesome.Sharp.IconPictureBox();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.labelTittleChildForm = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTittleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(188, 41);
            this.panelDesktop.Margin = new System.Windows.Forms.Padding(2);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(612, 409);
            this.panelDesktop.TabIndex = 5;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.panelMenu.Controls.Add(this.ChamCongBTN);
            this.panelMenu.Controls.Add(this.KhoHangBTN);
            this.panelMenu.Controls.Add(this.ThongKeBTN);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.ForeColor = System.Drawing.Color.Coral;
            this.panelMenu.Location = new System.Drawing.Point(0, 41);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(188, 409);
            this.panelMenu.TabIndex = 3;
            // 
            // ChamCongBTN
            // 
            this.ChamCongBTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.ChamCongBTN.FlatAppearance.BorderSize = 0;
            this.ChamCongBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChamCongBTN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ChamCongBTN.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckAlt;
            this.ChamCongBTN.IconColor = System.Drawing.Color.YellowGreen;
            this.ChamCongBTN.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ChamCongBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ChamCongBTN.Location = new System.Drawing.Point(0, 200);
            this.ChamCongBTN.Margin = new System.Windows.Forms.Padding(2);
            this.ChamCongBTN.Name = "ChamCongBTN";
            this.ChamCongBTN.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.ChamCongBTN.Size = new System.Drawing.Size(188, 49);
            this.ChamCongBTN.TabIndex = 3;
            this.ChamCongBTN.Text = "CHẤM CÔNG";
            this.ChamCongBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ChamCongBTN.UseVisualStyleBackColor = true;
            // 
            // KhoHangBTN
            // 
            this.KhoHangBTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.KhoHangBTN.FlatAppearance.BorderSize = 0;
            this.KhoHangBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KhoHangBTN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.KhoHangBTN.IconChar = FontAwesome.Sharp.IconChar.Boxes;
            this.KhoHangBTN.IconColor = System.Drawing.Color.YellowGreen;
            this.KhoHangBTN.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.KhoHangBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.KhoHangBTN.Location = new System.Drawing.Point(0, 151);
            this.KhoHangBTN.Margin = new System.Windows.Forms.Padding(2);
            this.KhoHangBTN.Name = "KhoHangBTN";
            this.KhoHangBTN.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.KhoHangBTN.Size = new System.Drawing.Size(188, 49);
            this.KhoHangBTN.TabIndex = 2;
            this.KhoHangBTN.Text = "KHO HÀNG";
            this.KhoHangBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.KhoHangBTN.UseVisualStyleBackColor = true;
            // 
            // ThongKeBTN
            // 
            this.ThongKeBTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.ThongKeBTN.FlatAppearance.BorderSize = 0;
            this.ThongKeBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ThongKeBTN.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThongKeBTN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ThongKeBTN.IconChar = FontAwesome.Sharp.IconChar.Dashcube;
            this.ThongKeBTN.IconColor = System.Drawing.Color.YellowGreen;
            this.ThongKeBTN.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ThongKeBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ThongKeBTN.Location = new System.Drawing.Point(0, 102);
            this.ThongKeBTN.Margin = new System.Windows.Forms.Padding(2);
            this.ThongKeBTN.Name = "ThongKeBTN";
            this.ThongKeBTN.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.ThongKeBTN.Size = new System.Drawing.Size(188, 49);
            this.ThongKeBTN.TabIndex = 1;
            this.ThongKeBTN.Text = "THỐNG KÊ";
            this.ThongKeBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ThongKeBTN.UseVisualStyleBackColor = true;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panelLogo.Controls.Add(this.lblVersion);
            this.panelLogo.Controls.Add(this.btnHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(188, 102);
            this.panelLogo.TabIndex = 0;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.ForeColor = System.Drawing.Color.Black;
            this.lblVersion.Location = new System.Drawing.Point(3, 7);
            this.lblVersion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(60, 13);
            this.lblVersion.TabIndex = 1;
            this.lblVersion.Text = "Version 0.2";
            // 
            // btnHome
            // 
            this.btnHome.AutoSize = true;
            this.btnHome.Font = new System.Drawing.Font("MV Boli", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.Black;
            this.btnHome.Location = new System.Drawing.Point(26, 21);
            this.btnHome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(133, 50);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Owner";
            // 
            // panelTittleBar
            // 
            this.panelTittleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panelTittleBar.Controls.Add(this.iconPictureBox3);
            this.panelTittleBar.Controls.Add(this.btnMaximize);
            this.panelTittleBar.Controls.Add(this.btnExit);
            this.panelTittleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTittleBar.Controls.Add(this.labelTittleChildForm);
            this.panelTittleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTittleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTittleBar.Margin = new System.Windows.Forms.Padding(2);
            this.panelTittleBar.Name = "panelTittleBar";
            this.panelTittleBar.Size = new System.Drawing.Size(800, 41);
            this.panelTittleBar.TabIndex = 4;
            // 
            // iconPictureBox3
            // 
            this.iconPictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconPictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.iconPictureBox3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.MinusCircle;
            this.iconPictureBox3.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox3.IconSize = 24;
            this.iconPictureBox3.Location = new System.Drawing.Point(717, 1);
            this.iconPictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(24, 26);
            this.iconPictureBox3.TabIndex = 4;
            this.iconPictureBox3.TabStop = false;
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnMaximize.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.ExpandArrowsAlt;
            this.btnMaximize.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximize.IconSize = 24;
            this.btnMaximize.Location = new System.Drawing.Point(746, 1);
            this.btnMaximize.Margin = new System.Windows.Forms.Padding(2);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(24, 26);
            this.btnMaximize.TabIndex = 3;
            this.btnMaximize.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btnExit.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 24;
            this.btnExit.Location = new System.Drawing.Point(774, 1);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(24, 26);
            this.btnExit.TabIndex = 2;
            this.btnExit.TabStop = false;
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.White;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.IconSize = 24;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(10, 7);
            this.iconCurrentChildForm.Margin = new System.Windows.Forms.Padding(2);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(24, 26);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // labelTittleChildForm
            // 
            this.labelTittleChildForm.AutoSize = true;
            this.labelTittleChildForm.Location = new System.Drawing.Point(33, 12);
            this.labelTittleChildForm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTittleChildForm.Name = "labelTittleChildForm";
            this.labelTittleChildForm.Size = new System.Drawing.Size(35, 13);
            this.labelTittleChildForm.TabIndex = 1;
            this.labelTittleChildForm.Text = "Home";
            this.labelTittleChildForm.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ChuQuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelTittleBar);
            this.Name = "ChuQuan";
            this.Text = "ChuQuan";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTittleBar.ResumeLayout(false);
            this.panelTittleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
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
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private FontAwesome.Sharp.IconPictureBox btnMaximize;
        private FontAwesome.Sharp.IconPictureBox btnExit;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label labelTittleChildForm;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}