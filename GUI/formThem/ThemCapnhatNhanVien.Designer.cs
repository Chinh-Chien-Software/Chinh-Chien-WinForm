namespace ChinChin.GUI.formThem
{
    partial class ThemCapnhatNhanVien
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
            this.lblUserName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.pnlThongTin = new System.Windows.Forms.Panel();
            this.cbbChucVu = new System.Windows.Forms.ComboBox();
            this.lblChucVu = new System.Windows.Forms.Label();
            this.tbcSDT = new ChinChin.Custom.TextBox_Custom();
            this.tbcDC = new ChinChin.Custom.TextBox_Custom();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbGioiTinh = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpNgayVL = new System.Windows.Forms.DateTimePicker();
            this.tbcLuong = new ChinChin.Custom.TextBox_Custom();
            this.tbcMaNV = new ChinChin.Custom.TextBox_Custom();
            this.tbcTenNV = new ChinChin.Custom.TextBox_Custom();
            this.btnExit = new FontAwesome.Sharp.IconPictureBox();
            this.btnLuu = new ChinChin.Extra.BlackWhiteButton();
            this.lblThongBao = new System.Windows.Forms.Label();
            this.pnlMoveAndTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.pnlThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.pnlMoveAndTitle.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(14, 19);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(175, 31);
            this.lblUserName.TabIndex = 8;
            this.lblUserName.Text = "Mã nhân viên";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblUserName.Click += new System.EventHandler(this.lblUserName_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 31);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tên nhân viên";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 273);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 31);
            this.label1.TabIndex = 14;
            this.label1.Text = "Ngày vào làm";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.BackColor = System.Drawing.Color.Transparent;
            this.lblNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgaySinh.Location = new System.Drawing.Point(14, 193);
            this.lblNgaySinh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(186, 31);
            this.lblNgaySinh.TabIndex = 12;
            this.lblNgaySinh.Text = "Lương trên giờ";
            this.lblNgaySinh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblNgaySinh.Click += new System.EventHandler(this.lblNgaySinh_Click);
            // 
            // pnlThongTin
            // 
            this.pnlThongTin.Controls.Add(this.cbbChucVu);
            this.pnlThongTin.Controls.Add(this.lblChucVu);
            this.pnlThongTin.Controls.Add(this.tbcSDT);
            this.pnlThongTin.Controls.Add(this.tbcDC);
            this.pnlThongTin.Controls.Add(this.label5);
            this.pnlThongTin.Controls.Add(this.label6);
            this.pnlThongTin.Controls.Add(this.cbbGioiTinh);
            this.pnlThongTin.Controls.Add(this.label7);
            this.pnlThongTin.Controls.Add(this.dtpNgaySinh);
            this.pnlThongTin.Controls.Add(this.label8);
            this.pnlThongTin.Controls.Add(this.dtpNgayVL);
            this.pnlThongTin.Controls.Add(this.tbcLuong);
            this.pnlThongTin.Controls.Add(this.lblUserName);
            this.pnlThongTin.Controls.Add(this.tbcMaNV);
            this.pnlThongTin.Controls.Add(this.label2);
            this.pnlThongTin.Controls.Add(this.label1);
            this.pnlThongTin.Controls.Add(this.tbcTenNV);
            this.pnlThongTin.Controls.Add(this.lblNgaySinh);
            this.pnlThongTin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlThongTin.Location = new System.Drawing.Point(0, 55);
            this.pnlThongTin.Name = "pnlThongTin";
            this.pnlThongTin.Size = new System.Drawing.Size(830, 454);
            this.pnlThongTin.TabIndex = 30;
            this.pnlThongTin.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlThongTin_Paint);
            // 
            // cbbChucVu
            // 
            this.cbbChucVu.FormattingEnabled = true;
            this.cbbChucVu.Items.AddRange(new object[] {
            "chuquan",
            "quanly",
            "phache",
            "thungan",
            "phucvu"});
            this.cbbChucVu.Location = new System.Drawing.Point(20, 413);
            this.cbbChucVu.Name = "cbbChucVu";
            this.cbbChucVu.Size = new System.Drawing.Size(156, 21);
            this.cbbChucVu.TabIndex = 32;
            this.cbbChucVu.SelectedIndexChanged += new System.EventHandler(this.cbbChucVu_SelectedIndexChanged);
            // 
            // lblChucVu
            // 
            this.lblChucVu.AutoSize = true;
            this.lblChucVu.BackColor = System.Drawing.Color.Transparent;
            this.lblChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChucVu.Location = new System.Drawing.Point(14, 357);
            this.lblChucVu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(114, 31);
            this.lblChucVu.TabIndex = 31;
            this.lblChucVu.Text = "Chức vụ";
            this.lblChucVu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblChucVu.Click += new System.EventHandler(this.lblChucVu_Click);
            // 
            // tbcSDT
            // 
            this.tbcSDT.ForeColor = System.Drawing.Color.White;
            this.tbcSDT.Location = new System.Drawing.Point(449, 398);
            this.tbcSDT.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.tbcSDT.Name = "tbcSDT";
            this.tbcSDT.PasswordChar = '\0';
            this.tbcSDT.Size = new System.Drawing.Size(362, 39);
            this.tbcSDT.TabIndex = 30;
            this.tbcSDT.Load += new System.EventHandler(this.tbcSDT_Load);
            // 
            // tbcDC
            // 
            this.tbcDC.ForeColor = System.Drawing.Color.White;
            this.tbcDC.Location = new System.Drawing.Point(449, 305);
            this.tbcDC.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.tbcDC.Name = "tbcDC";
            this.tbcDC.PasswordChar = '\0';
            this.tbcDC.Size = new System.Drawing.Size(362, 39);
            this.tbcDC.TabIndex = 29;
            this.tbcDC.Load += new System.EventHandler(this.tbcDC_Load);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(443, 357);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 31);
            this.label5.TabIndex = 28;
            this.label5.Text = "Số điện thoại";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(447, 273);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 31);
            this.label6.TabIndex = 27;
            this.label6.Text = "Địa chỉ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // cbbGioiTinh
            // 
            this.cbbGioiTinh.FormattingEnabled = true;
            this.cbbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nu"});
            this.cbbGioiTinh.Location = new System.Drawing.Point(449, 229);
            this.cbbGioiTinh.Name = "cbbGioiTinh";
            this.cbbGioiTinh.Size = new System.Drawing.Size(96, 21);
            this.cbbGioiTinh.TabIndex = 26;
            this.cbbGioiTinh.SelectedIndexChanged += new System.EventHandler(this.cbbGioiTinh_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(443, 193);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 31);
            this.label7.TabIndex = 25;
            this.label7.Text = "Giới tính";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "yyyy-mm-dd";
            this.dtpNgaySinh.Location = new System.Drawing.Point(449, 145);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(200, 20);
            this.dtpNgaySinh.TabIndex = 24;
            this.dtpNgaySinh.ValueChanged += new System.EventHandler(this.dtpNgaySinh_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(443, 100);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 31);
            this.label8.TabIndex = 23;
            this.label8.Text = "Ngày sinh";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // dtpNgayVL
            // 
            this.dtpNgayVL.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayVL.CustomFormat = "yyyy-mm-dd";
            this.dtpNgayVL.Location = new System.Drawing.Point(20, 312);
            this.dtpNgayVL.Name = "dtpNgayVL";
            this.dtpNgayVL.Size = new System.Drawing.Size(200, 20);
            this.dtpNgayVL.TabIndex = 22;
            this.dtpNgayVL.ValueChanged += new System.EventHandler(this.dtpNgayVL_ValueChanged);
            // 
            // tbcLuong
            // 
            this.tbcLuong.ForeColor = System.Drawing.Color.White;
            this.tbcLuong.Location = new System.Drawing.Point(20, 227);
            this.tbcLuong.Margin = new System.Windows.Forms.Padding(6);
            this.tbcLuong.Name = "tbcLuong";
            this.tbcLuong.PasswordChar = '\0';
            this.tbcLuong.Size = new System.Drawing.Size(362, 40);
            this.tbcLuong.TabIndex = 18;
            this.tbcLuong.Load += new System.EventHandler(this.tbcLuong_Load);
            // 
            // tbcMaNV
            // 
            this.tbcMaNV.BackColor = System.Drawing.Color.White;
            this.tbcMaNV.ForeColor = System.Drawing.Color.White;
            this.tbcMaNV.Location = new System.Drawing.Point(20, 54);
            this.tbcMaNV.Margin = new System.Windows.Forms.Padding(4);
            this.tbcMaNV.Name = "tbcMaNV";
            this.tbcMaNV.PasswordChar = '\0';
            this.tbcMaNV.Size = new System.Drawing.Size(362, 40);
            this.tbcMaNV.TabIndex = 9;
            this.tbcMaNV.Load += new System.EventHandler(this.tbcMaNV_Load);
            // 
            // tbcTenNV
            // 
            this.tbcTenNV.ForeColor = System.Drawing.Color.White;
            this.tbcTenNV.Location = new System.Drawing.Point(20, 136);
            this.tbcTenNV.Margin = new System.Windows.Forms.Padding(6);
            this.tbcTenNV.Name = "tbcTenNV";
            this.tbcTenNV.PasswordChar = '\0';
            this.tbcTenNV.Size = new System.Drawing.Size(362, 40);
            this.tbcTenNV.TabIndex = 11;
            this.tbcTenNV.Load += new System.EventHandler(this.tbcTenNV_Load);
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
            this.btnExit.Location = new System.Drawing.Point(782, 6);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(46, 48);
            this.btnExit.TabIndex = 32;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(108)))), ((int)(((byte)(247)))));
            this.btnLuu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(108)))), ((int)(((byte)(247)))));
            this.btnLuu.BorderColor = System.Drawing.Color.Black;
            this.btnLuu.BorderRadius = 0;
            this.btnLuu.BorderSize = 0;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(570, 4);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(258, 50);
            this.btnLuu.TabIndex = 31;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextColor = System.Drawing.Color.White;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // lblThongBao
            // 
            this.lblThongBao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblThongBao.BackColor = System.Drawing.Color.Transparent;
            this.lblThongBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongBao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblThongBao.Location = new System.Drawing.Point(244, 23);
            this.lblThongBao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(322, 19);
            this.lblThongBao.TabIndex = 33;
            this.lblThongBao.Text = "hiện thông báo về mật khẩu và tài khoản";
            this.lblThongBao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblThongBao.Click += new System.EventHandler(this.lblThongBao_Click);
            // 
            // pnlMoveAndTitle
            // 
            this.pnlMoveAndTitle.Controls.Add(this.lblTitle);
            this.pnlMoveAndTitle.Controls.Add(this.btnExit);
            this.pnlMoveAndTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMoveAndTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlMoveAndTitle.Name = "pnlMoveAndTitle";
            this.pnlMoveAndTitle.Size = new System.Drawing.Size(830, 55);
            this.pnlMoveAndTitle.TabIndex = 34;
            this.pnlMoveAndTitle.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMoveAndTitle_Paint);
            this.pnlMoveAndTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlMoveAndTitle_MouseDown);
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTitle.Font = new System.Drawing.Font("Cascadia Code", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(464, 55);
            this.lblTitle.TabIndex = 33;
            this.lblTitle.Text = "Thêm Cập nhật Nhân Viên";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            this.lblTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblTitle_MouseDown);
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btnLuu);
            this.pnlBottom.Controls.Add(this.lblThongBao);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 509);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(830, 56);
            this.pnlBottom.TabIndex = 35;
            this.pnlBottom.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBottom_Paint);
            // 
            // ThemCapnhatNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(830, 565);
            this.Controls.Add(this.pnlThongTin);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlMoveAndTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ThemCapnhatNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThemCapnhatNhanVien";
            this.Load += new System.EventHandler(this.ThemCapnhatNhanVien_Load);
            this.pnlThongTin.ResumeLayout(false);
            this.pnlThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.pnlMoveAndTitle.ResumeLayout(false);
            this.pnlBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Panel pnlThongTin;
        private Custom.TextBox_Custom tbcLuong;
        private Custom.TextBox_Custom tbcMaNV;
        private Custom.TextBox_Custom tbcTenNV;
        private FontAwesome.Sharp.IconPictureBox btnExit;
        private Extra.BlackWhiteButton btnLuu;
        private System.Windows.Forms.DateTimePicker dtpNgayVL;
        private Custom.TextBox_Custom tbcSDT;
        private Custom.TextBox_Custom tbcDC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbGioiTinh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbbChucVu;
        private System.Windows.Forms.Label lblChucVu;
        private System.Windows.Forms.Label lblThongBao;
        private System.Windows.Forms.Panel pnlMoveAndTitle;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Label lblTitle;
    }
}