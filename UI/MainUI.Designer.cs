namespace ChinChin.UI
{
    partial class MainUI
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
            this.pnlChildForm = new System.Windows.Forms.Panel();
            this.pnlBorderOfForm = new System.Windows.Forms.Panel();
            this.panelTittleBar = new System.Windows.Forms.Panel();
            this.pnlTaiKhoanVaButtons = new System.Windows.Forms.Panel();
            this.mnsTaiKhoan = new System.Windows.Forms.MenuStrip();
            this.mnsiIconTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsiThongTinTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsiCaiDat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsiDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExit = new FontAwesome.Sharp.IconPictureBox();
            this.btnMaximize = new FontAwesome.Sharp.IconPictureBox();
            this.btnMinimize = new FontAwesome.Sharp.IconPictureBox();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.labelTittleChildForm = new System.Windows.Forms.Label();
            this.panelLeftSidebar = new System.Windows.Forms.Panel();
            this.ibtn4 = new FontAwesome.Sharp.IconButton();
            this.ibtn3 = new FontAwesome.Sharp.IconButton();
            this.ibtn2 = new FontAwesome.Sharp.IconButton();
            this.ibtn1 = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lblHomeButton_Role = new System.Windows.Forms.Label();
            this.pnlBorderOfForm.SuspendLayout();
            this.panelTittleBar.SuspendLayout();
            this.pnlTaiKhoanVaButtons.SuspendLayout();
            this.mnsTaiKhoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.panelLeftSidebar.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlChildForm
            // 
            this.pnlChildForm.BackColor = System.Drawing.Color.White;
            this.pnlChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChildForm.Location = new System.Drawing.Point(376, 70);
            this.pnlChildForm.Margin = new System.Windows.Forms.Padding(2);
            this.pnlChildForm.Name = "pnlChildForm";
            this.pnlChildForm.Size = new System.Drawing.Size(601, 539);
            this.pnlChildForm.TabIndex = 14;
            // 
            // pnlBorderOfForm
            // 
            this.pnlBorderOfForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBorderOfForm.Controls.Add(this.pnlChildForm);
            this.pnlBorderOfForm.Controls.Add(this.panelLeftSidebar);
            this.pnlBorderOfForm.Controls.Add(this.panelTittleBar);
            this.pnlBorderOfForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBorderOfForm.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlBorderOfForm.Location = new System.Drawing.Point(0, 0);
            this.pnlBorderOfForm.Name = "pnlBorderOfForm";
            this.pnlBorderOfForm.Size = new System.Drawing.Size(979, 611);
            this.pnlBorderOfForm.TabIndex = 0;
            // 
            // panelTittleBar
            // 
            this.panelTittleBar.BackColor = System.Drawing.Color.White;
            this.panelTittleBar.Controls.Add(this.pnlTaiKhoanVaButtons);
            this.panelTittleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTittleBar.Controls.Add(this.labelTittleChildForm);
            this.panelTittleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTittleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTittleBar.Margin = new System.Windows.Forms.Padding(2);
            this.panelTittleBar.Name = "panelTittleBar";
            this.panelTittleBar.Size = new System.Drawing.Size(977, 70);
            this.panelTittleBar.TabIndex = 16;
            this.panelTittleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTittleBar_MouseDown);
            // 
            // pnlTaiKhoanVaButtons
            // 
            this.pnlTaiKhoanVaButtons.Controls.Add(this.mnsTaiKhoan);
            this.pnlTaiKhoanVaButtons.Controls.Add(this.btnExit);
            this.pnlTaiKhoanVaButtons.Controls.Add(this.btnMaximize);
            this.pnlTaiKhoanVaButtons.Controls.Add(this.btnMinimize);
            this.pnlTaiKhoanVaButtons.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlTaiKhoanVaButtons.Location = new System.Drawing.Point(731, 0);
            this.pnlTaiKhoanVaButtons.Name = "pnlTaiKhoanVaButtons";
            this.pnlTaiKhoanVaButtons.Size = new System.Drawing.Size(246, 70);
            this.pnlTaiKhoanVaButtons.TabIndex = 17;
            // 
            // mnsTaiKhoan
            // 
            this.mnsTaiKhoan.Dock = System.Windows.Forms.DockStyle.None;
            this.mnsTaiKhoan.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsiIconTaiKhoan});
            this.mnsTaiKhoan.Location = new System.Drawing.Point(0, 1);
            this.mnsTaiKhoan.Name = "mnsTaiKhoan";
            this.mnsTaiKhoan.Size = new System.Drawing.Size(77, 70);
            this.mnsTaiKhoan.TabIndex = 16;
            this.mnsTaiKhoan.Text = "msTaiKhoan";
            // 
            // mnsiIconTaiKhoan
            // 
            this.mnsiIconTaiKhoan.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnsiIconTaiKhoan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsiThongTinTaiKhoan,
            this.mnsiCaiDat,
            this.mnsiDangXuat});
            this.mnsiIconTaiKhoan.Image = global::ChinChin.Properties.Resources.image;
            this.mnsiIconTaiKhoan.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mnsiIconTaiKhoan.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnsiIconTaiKhoan.Name = "mnsiIconTaiKhoan";
            this.mnsiIconTaiKhoan.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mnsiIconTaiKhoan.RightToLeftAutoMirrorImage = true;
            this.mnsiIconTaiKhoan.Size = new System.Drawing.Size(69, 66);
            this.mnsiIconTaiKhoan.Text = "Tài khoản";
            this.mnsiIconTaiKhoan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mnsiIconTaiKhoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // mnsiThongTinTaiKhoan
            // 
            this.mnsiThongTinTaiKhoan.Name = "mnsiThongTinTaiKhoan";
            this.mnsiThongTinTaiKhoan.Size = new System.Drawing.Size(181, 22);
            this.mnsiThongTinTaiKhoan.Text = "Thông Tin Tài Khoản";
            this.mnsiThongTinTaiKhoan.Click += new System.EventHandler(this.mnsiThongTinTaiKhoan_Click);
            // 
            // mnsiCaiDat
            // 
            this.mnsiCaiDat.Name = "mnsiCaiDat";
            this.mnsiCaiDat.Size = new System.Drawing.Size(181, 22);
            this.mnsiCaiDat.Text = "Cài đặt";
            this.mnsiCaiDat.Click += new System.EventHandler(this.mnsiCaiDat_Click);
            // 
            // mnsiDangXuat
            // 
            this.mnsiDangXuat.Name = "mnsiDangXuat";
            this.mnsiDangXuat.Size = new System.Drawing.Size(181, 22);
            this.mnsiDangXuat.Text = "Đăng Xuất";
            this.mnsiDangXuat.Click += new System.EventHandler(this.DangXuat_Click);
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
            this.btnExit.Location = new System.Drawing.Point(197, 2);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(47, 50);
            this.btnExit.TabIndex = 2;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.White;
            this.btnMaximize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(108)))), ((int)(((byte)(247)))));
            this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMaximize.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(108)))), ((int)(((byte)(247)))));
            this.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximize.IconSize = 49;
            this.btnMaximize.Location = new System.Drawing.Point(143, 1);
            this.btnMaximize.Margin = new System.Windows.Forms.Padding(2);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(50, 49);
            this.btnMaximize.TabIndex = 3;
            this.btnMaximize.TabStop = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
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
            this.btnMinimize.Location = new System.Drawing.Point(93, 1);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(46, 50);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.Transparent;
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(108)))), ((int)(((byte)(247)))));
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(108)))), ((int)(((byte)(247)))));
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.IconSize = 46;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(0, 11);
            this.iconCurrentChildForm.Margin = new System.Windows.Forms.Padding(2);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(46, 50);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // labelTittleChildForm
            // 
            this.labelTittleChildForm.AutoSize = true;
            this.labelTittleChildForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTittleChildForm.Location = new System.Drawing.Point(50, 21);
            this.labelTittleChildForm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTittleChildForm.Name = "labelTittleChildForm";
            this.labelTittleChildForm.Size = new System.Drawing.Size(49, 17);
            this.labelTittleChildForm.TabIndex = 1;
            this.labelTittleChildForm.Text = "Home";
            this.labelTittleChildForm.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelLeftSidebar
            // 
            this.panelLeftSidebar.BackColor = System.Drawing.Color.White;
            this.panelLeftSidebar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLeftSidebar.Controls.Add(this.ibtn4);
            this.panelLeftSidebar.Controls.Add(this.ibtn3);
            this.panelLeftSidebar.Controls.Add(this.ibtn2);
            this.panelLeftSidebar.Controls.Add(this.ibtn1);
            this.panelLeftSidebar.Controls.Add(this.panelLogo);
            this.panelLeftSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftSidebar.ForeColor = System.Drawing.Color.Coral;
            this.panelLeftSidebar.Location = new System.Drawing.Point(0, 70);
            this.panelLeftSidebar.Margin = new System.Windows.Forms.Padding(2);
            this.panelLeftSidebar.Name = "panelLeftSidebar";
            this.panelLeftSidebar.Size = new System.Drawing.Size(376, 539);
            this.panelLeftSidebar.TabIndex = 17;
            // 
            // ibtn4
            // 
            this.ibtn4.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtn4.FlatAppearance.BorderSize = 0;
            this.ibtn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtn4.Font = new System.Drawing.Font("Cascadia Code", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtn4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ibtn4.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckAlt;
            this.ibtn4.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(108)))), ((int)(((byte)(247)))));
            this.ibtn4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtn4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtn4.Location = new System.Drawing.Point(0, 424);
            this.ibtn4.Margin = new System.Windows.Forms.Padding(2);
            this.ibtn4.Name = "ibtn4";
            this.ibtn4.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.ibtn4.Size = new System.Drawing.Size(374, 102);
            this.ibtn4.TabIndex = 10;
            this.ibtn4.Text = "Nút 4";
            this.ibtn4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtn4.UseVisualStyleBackColor = true;
            // 
            // ibtn3
            // 
            this.ibtn3.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtn3.FlatAppearance.BorderSize = 0;
            this.ibtn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtn3.Font = new System.Drawing.Font("Cascadia Code", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtn3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ibtn3.IconChar = FontAwesome.Sharp.IconChar.MugHot;
            this.ibtn3.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(108)))), ((int)(((byte)(247)))));
            this.ibtn3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtn3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtn3.Location = new System.Drawing.Point(0, 322);
            this.ibtn3.Margin = new System.Windows.Forms.Padding(2);
            this.ibtn3.Name = "ibtn3";
            this.ibtn3.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.ibtn3.Size = new System.Drawing.Size(374, 102);
            this.ibtn3.TabIndex = 9;
            this.ibtn3.Text = "Nút 3";
            this.ibtn3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtn3.UseVisualStyleBackColor = true;
            // 
            // ibtn2
            // 
            this.ibtn2.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtn2.FlatAppearance.BorderSize = 0;
            this.ibtn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtn2.Font = new System.Drawing.Font("Cascadia Code", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtn2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ibtn2.IconChar = FontAwesome.Sharp.IconChar.Dashcube;
            this.ibtn2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(108)))), ((int)(((byte)(247)))));
            this.ibtn2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtn2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtn2.Location = new System.Drawing.Point(0, 222);
            this.ibtn2.Margin = new System.Windows.Forms.Padding(2);
            this.ibtn2.Name = "ibtn2";
            this.ibtn2.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.ibtn2.Size = new System.Drawing.Size(374, 100);
            this.ibtn2.TabIndex = 8;
            this.ibtn2.Text = "Nút 2";
            this.ibtn2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtn2.UseVisualStyleBackColor = true;
            this.ibtn2.Click += new System.EventHandler(this.ibtn2_Click);
            // 
            // ibtn1
            // 
            this.ibtn1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtn1.FlatAppearance.BorderSize = 0;
            this.ibtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtn1.Font = new System.Drawing.Font("Cascadia Code", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtn1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ibtn1.IconChar = FontAwesome.Sharp.IconChar.ObjectGroup;
            this.ibtn1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(108)))), ((int)(((byte)(247)))));
            this.ibtn1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtn1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtn1.Location = new System.Drawing.Point(0, 122);
            this.ibtn1.Margin = new System.Windows.Forms.Padding(2);
            this.ibtn1.Name = "ibtn1";
            this.ibtn1.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.ibtn1.Size = new System.Drawing.Size(374, 100);
            this.ibtn1.TabIndex = 7;
            this.ibtn1.Text = "Nút 1";
            this.ibtn1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtn1.UseVisualStyleBackColor = true;
            this.ibtn1.Click += new System.EventHandler(this.ibtn1_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.Transparent;
            this.panelLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLogo.Controls.Add(this.lblHomeButton_Role);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(374, 122);
            this.panelLogo.TabIndex = 0;
            // 
            // lblHomeButton_Role
            // 
            this.lblHomeButton_Role.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHomeButton_Role.Font = new System.Drawing.Font("Inter", 29.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomeButton_Role.ForeColor = System.Drawing.Color.Black;
            this.lblHomeButton_Role.Location = new System.Drawing.Point(0, 0);
            this.lblHomeButton_Role.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHomeButton_Role.Name = "lblHomeButton_Role";
            this.lblHomeButton_Role.Size = new System.Drawing.Size(372, 120);
            this.lblHomeButton_Role.TabIndex = 0;
            this.lblHomeButton_Role.Text = "Role";
            this.lblHomeButton_Role.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 611);
            this.Controls.Add(this.pnlBorderOfForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainUI";
            this.Text = "MainUI";
            this.Load += new System.EventHandler(this.MainUI_Load);
            this.pnlBorderOfForm.ResumeLayout(false);
            this.panelTittleBar.ResumeLayout(false);
            this.panelTittleBar.PerformLayout();
            this.pnlTaiKhoanVaButtons.ResumeLayout(false);
            this.pnlTaiKhoanVaButtons.PerformLayout();
            this.mnsTaiKhoan.ResumeLayout(false);
            this.mnsTaiKhoan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.panelLeftSidebar.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlChildForm;
        private System.Windows.Forms.Panel pnlBorderOfForm;
        private System.Windows.Forms.Panel panelLeftSidebar;
        private FontAwesome.Sharp.IconButton ibtn4;
        private FontAwesome.Sharp.IconButton ibtn3;
        private FontAwesome.Sharp.IconButton ibtn2;
        private FontAwesome.Sharp.IconButton ibtn1;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label lblHomeButton_Role;
        private System.Windows.Forms.Panel panelTittleBar;
        private System.Windows.Forms.Panel pnlTaiKhoanVaButtons;
        private System.Windows.Forms.MenuStrip mnsTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem mnsiIconTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem mnsiThongTinTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem mnsiCaiDat;
        private System.Windows.Forms.ToolStripMenuItem mnsiDangXuat;
        private FontAwesome.Sharp.IconPictureBox btnExit;
        private FontAwesome.Sharp.IconPictureBox btnMaximize;
        private FontAwesome.Sharp.IconPictureBox btnMinimize;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label labelTittleChildForm;
    }
}