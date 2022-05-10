
namespace ChinChin.Forms_NhanVien
{
    partial class TiepNhanDonHang
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlChonMon = new System.Windows.Forms.Panel();
            this.lvSanPhamTheoLoai = new System.Windows.Forms.ListView();
            this.chTenSP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.flpnlLoai = new System.Windows.Forms.FlowLayoutPanel();
            this.labelMenuList = new System.Windows.Forms.Label();
            this.panelHoaDon = new System.Windows.Forms.Panel();
            this.labelHoaDon = new System.Windows.Forms.Label();
            this.lvThongTinHoaDon = new System.Windows.Forms.ListView();
            this.chTenSanPham = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chGia1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSoLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.btnTypeTraSua = new ChinChin.Extra.BlackWhiteButton();
            this.btnTypeCaPhe = new ChinChin.Extra.BlackWhiteButton();
            this.btnTypeTopping = new ChinChin.Extra.BlackWhiteButton();
            this.blackWhiteButton3 = new ChinChin.Extra.BlackWhiteButton();
            this.blackWhiteButton4 = new ChinChin.Extra.BlackWhiteButton();
            this.blackWhiteButton5 = new ChinChin.Extra.BlackWhiteButton();
            this.pnlMenu.SuspendLayout();
            this.pnlChonMon.SuspendLayout();
            this.flpnlLoai.SuspendLayout();
            this.panelHoaDon.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMenu.Controls.Add(this.pnlChonMon);
            this.pnlMenu.Controls.Add(this.labelMenuList);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(558, 839);
            this.pnlMenu.TabIndex = 0;
            // 
            // pnlChonMon
            // 
            this.pnlChonMon.Controls.Add(this.lvSanPhamTheoLoai);
            this.pnlChonMon.Controls.Add(this.flpnlLoai);
            this.pnlChonMon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChonMon.Location = new System.Drawing.Point(0, 40);
            this.pnlChonMon.Name = "pnlChonMon";
            this.pnlChonMon.Size = new System.Drawing.Size(556, 797);
            this.pnlChonMon.TabIndex = 3;
            // 
            // lvSanPhamTheoLoai
            // 
            this.lvSanPhamTheoLoai.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chTenSP,
            this.chGia});
            this.lvSanPhamTheoLoai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvSanPhamTheoLoai.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvSanPhamTheoLoai.HideSelection = false;
            this.lvSanPhamTheoLoai.Location = new System.Drawing.Point(200, 0);
            this.lvSanPhamTheoLoai.Name = "lvSanPhamTheoLoai";
            this.lvSanPhamTheoLoai.Size = new System.Drawing.Size(356, 797);
            this.lvSanPhamTheoLoai.TabIndex = 1;
            this.lvSanPhamTheoLoai.UseCompatibleStateImageBehavior = false;
            this.lvSanPhamTheoLoai.View = System.Windows.Forms.View.Details;
            this.lvSanPhamTheoLoai.SelectedIndexChanged += new System.EventHandler(this.lvSanPhamTheoLoai_SelectedIndexChanged);
            this.lvSanPhamTheoLoai.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvSanPhamTheoLoai_MouseDoubleClick);
            // 
            // chTenSP
            // 
            this.chTenSP.Text = "Tên Sản Phẩm";
            this.chTenSP.Width = 265;
            // 
            // chGia
            // 
            this.chGia.Text = "Giá";
            this.chGia.Width = 95;
            // 
            // flpnlLoai
            // 
            this.flpnlLoai.BackColor = System.Drawing.Color.White;
            this.flpnlLoai.Controls.Add(this.btnTypeTraSua);
            this.flpnlLoai.Controls.Add(this.btnTypeCaPhe);
            this.flpnlLoai.Controls.Add(this.btnTypeTopping);
            this.flpnlLoai.Controls.Add(this.blackWhiteButton3);
            this.flpnlLoai.Controls.Add(this.blackWhiteButton4);
            this.flpnlLoai.Controls.Add(this.blackWhiteButton5);
            this.flpnlLoai.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpnlLoai.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpnlLoai.Location = new System.Drawing.Point(0, 0);
            this.flpnlLoai.Name = "flpnlLoai";
            this.flpnlLoai.Size = new System.Drawing.Size(200, 797);
            this.flpnlLoai.TabIndex = 0;
            // 
            // labelMenuList
            // 
            this.labelMenuList.BackColor = System.Drawing.Color.White;
            this.labelMenuList.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelMenuList.Font = new System.Drawing.Font("Cascadia Code", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenuList.Location = new System.Drawing.Point(0, 0);
            this.labelMenuList.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMenuList.Name = "labelMenuList";
            this.labelMenuList.Size = new System.Drawing.Size(556, 40);
            this.labelMenuList.TabIndex = 2;
            this.labelMenuList.Text = "MENU";
            this.labelMenuList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelHoaDon
            // 
            this.panelHoaDon.BackColor = System.Drawing.Color.White;
            this.panelHoaDon.Controls.Add(this.button1);
            this.panelHoaDon.Controls.Add(this.lvThongTinHoaDon);
            this.panelHoaDon.Controls.Add(this.labelHoaDon);
            this.panelHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHoaDon.Location = new System.Drawing.Point(558, 0);
            this.panelHoaDon.Margin = new System.Windows.Forms.Padding(2);
            this.panelHoaDon.Name = "panelHoaDon";
            this.panelHoaDon.Size = new System.Drawing.Size(644, 839);
            this.panelHoaDon.TabIndex = 1;
            // 
            // labelHoaDon
            // 
            this.labelHoaDon.BackColor = System.Drawing.Color.White;
            this.labelHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelHoaDon.Font = new System.Drawing.Font("Cascadia Code", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHoaDon.Location = new System.Drawing.Point(0, 0);
            this.labelHoaDon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHoaDon.Name = "labelHoaDon";
            this.labelHoaDon.Size = new System.Drawing.Size(644, 41);
            this.labelHoaDon.TabIndex = 1;
            this.labelHoaDon.Text = "HÓA ĐƠN";
            this.labelHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lvThongTinHoaDon
            // 
            this.lvThongTinHoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvThongTinHoaDon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chTenSanPham,
            this.chGia1,
            this.chSoLuong});
            this.lvThongTinHoaDon.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvThongTinHoaDon.HideSelection = false;
            this.lvThongTinHoaDon.Location = new System.Drawing.Point(5, 44);
            this.lvThongTinHoaDon.Name = "lvThongTinHoaDon";
            this.lvThongTinHoaDon.Size = new System.Drawing.Size(636, 736);
            this.lvThongTinHoaDon.TabIndex = 4;
            this.lvThongTinHoaDon.UseCompatibleStateImageBehavior = false;
            this.lvThongTinHoaDon.View = System.Windows.Forms.View.Details;
            // 
            // chTenSanPham
            // 
            this.chTenSanPham.Text = "Tên Sản Phẩm";
            this.chTenSanPham.Width = 265;
            // 
            // chGia1
            // 
            this.chGia1.Text = "Giá";
            this.chGia1.Width = 95;
            // 
            // chSoLuong
            // 
            this.chSoLuong.Text = "Số lượng";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(108)))), ((int)(((byte)(247)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(108)))), ((int)(((byte)(247)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(541, 786);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 50);
            this.button1.TabIndex = 5;
            this.button1.Text = "Thành Tiền";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnTypeTraSua
            // 
            this.btnTypeTraSua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTypeTraSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(108)))), ((int)(((byte)(247)))));
            this.btnTypeTraSua.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(108)))), ((int)(((byte)(247)))));
            this.btnTypeTraSua.BorderColor = System.Drawing.Color.Black;
            this.btnTypeTraSua.BorderRadius = 0;
            this.btnTypeTraSua.BorderSize = 0;
            this.btnTypeTraSua.FlatAppearance.BorderSize = 0;
            this.btnTypeTraSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTypeTraSua.Font = new System.Drawing.Font("Inter", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTypeTraSua.ForeColor = System.Drawing.Color.White;
            this.btnTypeTraSua.Location = new System.Drawing.Point(2, 2);
            this.btnTypeTraSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnTypeTraSua.Name = "btnTypeTraSua";
            this.btnTypeTraSua.Size = new System.Drawing.Size(198, 80);
            this.btnTypeTraSua.TabIndex = 11;
            this.btnTypeTraSua.Text = "TRÀ SỮA";
            this.btnTypeTraSua.TextColor = System.Drawing.Color.White;
            this.btnTypeTraSua.UseVisualStyleBackColor = false;
            this.btnTypeTraSua.Click += new System.EventHandler(this.btnTypeTraSua_Click);
            // 
            // btnTypeCaPhe
            // 
            this.btnTypeCaPhe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTypeCaPhe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(108)))), ((int)(((byte)(247)))));
            this.btnTypeCaPhe.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(108)))), ((int)(((byte)(247)))));
            this.btnTypeCaPhe.BorderColor = System.Drawing.Color.Black;
            this.btnTypeCaPhe.BorderRadius = 0;
            this.btnTypeCaPhe.BorderSize = 0;
            this.btnTypeCaPhe.FlatAppearance.BorderSize = 0;
            this.btnTypeCaPhe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTypeCaPhe.Font = new System.Drawing.Font("Inter", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTypeCaPhe.ForeColor = System.Drawing.Color.White;
            this.btnTypeCaPhe.Location = new System.Drawing.Point(2, 86);
            this.btnTypeCaPhe.Margin = new System.Windows.Forms.Padding(2);
            this.btnTypeCaPhe.Name = "btnTypeCaPhe";
            this.btnTypeCaPhe.Size = new System.Drawing.Size(198, 80);
            this.btnTypeCaPhe.TabIndex = 12;
            this.btnTypeCaPhe.Text = "CÀ PHÊ";
            this.btnTypeCaPhe.TextColor = System.Drawing.Color.White;
            this.btnTypeCaPhe.UseVisualStyleBackColor = false;
            this.btnTypeCaPhe.Click += new System.EventHandler(this.btnTypeCaPhe_Click);
            // 
            // btnTypeTopping
            // 
            this.btnTypeTopping.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTypeTopping.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(108)))), ((int)(((byte)(247)))));
            this.btnTypeTopping.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(108)))), ((int)(((byte)(247)))));
            this.btnTypeTopping.BorderColor = System.Drawing.Color.Black;
            this.btnTypeTopping.BorderRadius = 0;
            this.btnTypeTopping.BorderSize = 0;
            this.btnTypeTopping.FlatAppearance.BorderSize = 0;
            this.btnTypeTopping.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTypeTopping.Font = new System.Drawing.Font("Inter", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTypeTopping.ForeColor = System.Drawing.Color.White;
            this.btnTypeTopping.Location = new System.Drawing.Point(2, 170);
            this.btnTypeTopping.Margin = new System.Windows.Forms.Padding(2);
            this.btnTypeTopping.Name = "btnTypeTopping";
            this.btnTypeTopping.Size = new System.Drawing.Size(198, 80);
            this.btnTypeTopping.TabIndex = 13;
            this.btnTypeTopping.Text = "TOPPING";
            this.btnTypeTopping.TextColor = System.Drawing.Color.White;
            this.btnTypeTopping.UseVisualStyleBackColor = false;
            // 
            // blackWhiteButton3
            // 
            this.blackWhiteButton3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.blackWhiteButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(108)))), ((int)(((byte)(247)))));
            this.blackWhiteButton3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(108)))), ((int)(((byte)(247)))));
            this.blackWhiteButton3.BorderColor = System.Drawing.Color.Black;
            this.blackWhiteButton3.BorderRadius = 0;
            this.blackWhiteButton3.BorderSize = 0;
            this.blackWhiteButton3.FlatAppearance.BorderSize = 0;
            this.blackWhiteButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.blackWhiteButton3.Font = new System.Drawing.Font("Inter", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blackWhiteButton3.ForeColor = System.Drawing.Color.White;
            this.blackWhiteButton3.Location = new System.Drawing.Point(2, 254);
            this.blackWhiteButton3.Margin = new System.Windows.Forms.Padding(2);
            this.blackWhiteButton3.Name = "blackWhiteButton3";
            this.blackWhiteButton3.Size = new System.Drawing.Size(198, 80);
            this.blackWhiteButton3.TabIndex = 14;
            this.blackWhiteButton3.Text = "Loại 1";
            this.blackWhiteButton3.TextColor = System.Drawing.Color.White;
            this.blackWhiteButton3.UseVisualStyleBackColor = false;
            // 
            // blackWhiteButton4
            // 
            this.blackWhiteButton4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.blackWhiteButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(108)))), ((int)(((byte)(247)))));
            this.blackWhiteButton4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(108)))), ((int)(((byte)(247)))));
            this.blackWhiteButton4.BorderColor = System.Drawing.Color.Black;
            this.blackWhiteButton4.BorderRadius = 0;
            this.blackWhiteButton4.BorderSize = 0;
            this.blackWhiteButton4.FlatAppearance.BorderSize = 0;
            this.blackWhiteButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.blackWhiteButton4.Font = new System.Drawing.Font("Inter", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blackWhiteButton4.ForeColor = System.Drawing.Color.White;
            this.blackWhiteButton4.Location = new System.Drawing.Point(2, 338);
            this.blackWhiteButton4.Margin = new System.Windows.Forms.Padding(2);
            this.blackWhiteButton4.Name = "blackWhiteButton4";
            this.blackWhiteButton4.Size = new System.Drawing.Size(198, 80);
            this.blackWhiteButton4.TabIndex = 15;
            this.blackWhiteButton4.Text = "Loại 1";
            this.blackWhiteButton4.TextColor = System.Drawing.Color.White;
            this.blackWhiteButton4.UseVisualStyleBackColor = false;
            // 
            // blackWhiteButton5
            // 
            this.blackWhiteButton5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.blackWhiteButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(108)))), ((int)(((byte)(247)))));
            this.blackWhiteButton5.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(108)))), ((int)(((byte)(247)))));
            this.blackWhiteButton5.BorderColor = System.Drawing.Color.Black;
            this.blackWhiteButton5.BorderRadius = 0;
            this.blackWhiteButton5.BorderSize = 0;
            this.blackWhiteButton5.FlatAppearance.BorderSize = 0;
            this.blackWhiteButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.blackWhiteButton5.Font = new System.Drawing.Font("Inter", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blackWhiteButton5.ForeColor = System.Drawing.Color.White;
            this.blackWhiteButton5.Location = new System.Drawing.Point(2, 422);
            this.blackWhiteButton5.Margin = new System.Windows.Forms.Padding(2);
            this.blackWhiteButton5.Name = "blackWhiteButton5";
            this.blackWhiteButton5.Size = new System.Drawing.Size(198, 80);
            this.blackWhiteButton5.TabIndex = 16;
            this.blackWhiteButton5.Text = "Loại 1";
            this.blackWhiteButton5.TextColor = System.Drawing.Color.White;
            this.blackWhiteButton5.UseVisualStyleBackColor = false;
            // 
            // TiepNhanDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 839);
            this.Controls.Add(this.panelHoaDon);
            this.Controls.Add(this.pnlMenu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TiepNhanDonHang";
            this.Text = "TiepNhanDonHang";
            this.pnlMenu.ResumeLayout(false);
            this.pnlChonMon.ResumeLayout(false);
            this.flpnlLoai.ResumeLayout(false);
            this.panelHoaDon.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel panelHoaDon;
        private System.Windows.Forms.Label labelHoaDon;
        private System.Windows.Forms.Label labelMenuList;
        private System.Windows.Forms.Panel pnlChonMon;
        private System.Windows.Forms.FlowLayoutPanel flpnlLoai;
        private Extra.BlackWhiteButton btnTypeTraSua;
        private Extra.BlackWhiteButton btnTypeCaPhe;
        private Extra.BlackWhiteButton btnTypeTopping;
        private Extra.BlackWhiteButton blackWhiteButton3;
        private Extra.BlackWhiteButton blackWhiteButton4;
        private Extra.BlackWhiteButton blackWhiteButton5;
        private System.Windows.Forms.ListView lvSanPhamTheoLoai;
        private System.Windows.Forms.ColumnHeader chTenSP;
        private System.Windows.Forms.ColumnHeader chGia;
        private System.Windows.Forms.ListView lvThongTinHoaDon;
        private System.Windows.Forms.ColumnHeader chTenSanPham;
        private System.Windows.Forms.ColumnHeader chGia1;
        private System.Windows.Forms.ColumnHeader chSoLuong;
        private System.Windows.Forms.Button button1;
    }
}