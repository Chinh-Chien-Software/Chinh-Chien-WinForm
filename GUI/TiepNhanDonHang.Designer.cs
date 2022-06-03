
namespace ChinhChien.Forms_NhanVien
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
            this.components = new System.ComponentModel.Container();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlChonMon = new System.Windows.Forms.Panel();
            this.lvSanPhamTheoLoai = new System.Windows.Forms.ListView();
            this.chTenSP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fpnlLoai = new System.Windows.Forms.FlowLayoutPanel();
            this.btnTypeTraSua = new ChinhChien.Extra.BlackWhiteButton();
            this.btnTypeCaPhe = new ChinhChien.Extra.BlackWhiteButton();
            this.btnTypeTopping = new ChinhChien.Extra.BlackWhiteButton();
            this.labelMenuList = new System.Windows.Forms.Label();
            this.pnlHoaDon = new System.Windows.Forms.Panel();
            this.lblThongBao = new System.Windows.Forms.Label();
            this.btnThanhTien = new System.Windows.Forms.Button();
            this.lvThongTinHoaDon = new System.Windows.Forms.ListView();
            this.chTenSanPham = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chGia1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSoLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelHoaDon = new System.Windows.Forms.Label();
            this.tmDisableThongBao = new System.Windows.Forms.Timer(this.components);
            this.pnlMenu.SuspendLayout();
            this.pnlChonMon.SuspendLayout();
            this.fpnlLoai.SuspendLayout();
            this.pnlHoaDon.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.pnlChonMon);
            this.pnlMenu.Controls.Add(this.labelMenuList);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(743, 639);
            this.pnlMenu.TabIndex = 0;
            // 
            // pnlChonMon
            // 
            this.pnlChonMon.Controls.Add(this.lvSanPhamTheoLoai);
            this.pnlChonMon.Controls.Add(this.fpnlLoai);
            this.pnlChonMon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChonMon.Location = new System.Drawing.Point(0, 49);
            this.pnlChonMon.Margin = new System.Windows.Forms.Padding(4);
            this.pnlChonMon.Name = "pnlChonMon";
            this.pnlChonMon.Size = new System.Drawing.Size(743, 590);
            this.pnlChonMon.TabIndex = 3;
            // 
            // lvSanPhamTheoLoai
            // 
            this.lvSanPhamTheoLoai.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvSanPhamTheoLoai.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chTenSP,
            this.chGia});
            this.lvSanPhamTheoLoai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvSanPhamTheoLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvSanPhamTheoLoai.FullRowSelect = true;
            this.lvSanPhamTheoLoai.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvSanPhamTheoLoai.HideSelection = false;
            this.lvSanPhamTheoLoai.Location = new System.Drawing.Point(267, 0);
            this.lvSanPhamTheoLoai.Margin = new System.Windows.Forms.Padding(4);
            this.lvSanPhamTheoLoai.Name = "lvSanPhamTheoLoai";
            this.lvSanPhamTheoLoai.Size = new System.Drawing.Size(476, 590);
            this.lvSanPhamTheoLoai.TabIndex = 1;
            this.lvSanPhamTheoLoai.UseCompatibleStateImageBehavior = false;
            this.lvSanPhamTheoLoai.View = System.Windows.Forms.View.Details;
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
            // fpnlLoai
            // 
            this.fpnlLoai.BackColor = System.Drawing.Color.White;
            this.fpnlLoai.Controls.Add(this.btnTypeTraSua);
            this.fpnlLoai.Controls.Add(this.btnTypeCaPhe);
            this.fpnlLoai.Controls.Add(this.btnTypeTopping);
            this.fpnlLoai.Dock = System.Windows.Forms.DockStyle.Left;
            this.fpnlLoai.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.fpnlLoai.Location = new System.Drawing.Point(0, 0);
            this.fpnlLoai.Margin = new System.Windows.Forms.Padding(4);
            this.fpnlLoai.Name = "fpnlLoai";
            this.fpnlLoai.Size = new System.Drawing.Size(267, 590);
            this.fpnlLoai.TabIndex = 0;
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
            this.btnTypeTraSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTypeTraSua.ForeColor = System.Drawing.Color.White;
            this.btnTypeTraSua.Location = new System.Drawing.Point(3, 2);
            this.btnTypeTraSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTypeTraSua.Name = "btnTypeTraSua";
            this.btnTypeTraSua.Size = new System.Drawing.Size(264, 98);
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
            this.btnTypeCaPhe.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTypeCaPhe.ForeColor = System.Drawing.Color.White;
            this.btnTypeCaPhe.Location = new System.Drawing.Point(3, 104);
            this.btnTypeCaPhe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTypeCaPhe.Name = "btnTypeCaPhe";
            this.btnTypeCaPhe.Size = new System.Drawing.Size(264, 98);
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
            this.btnTypeTopping.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTypeTopping.ForeColor = System.Drawing.Color.White;
            this.btnTypeTopping.Location = new System.Drawing.Point(3, 206);
            this.btnTypeTopping.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTypeTopping.Name = "btnTypeTopping";
            this.btnTypeTopping.Size = new System.Drawing.Size(264, 98);
            this.btnTypeTopping.TabIndex = 13;
            this.btnTypeTopping.Text = "TOPPING";
            this.btnTypeTopping.TextColor = System.Drawing.Color.White;
            this.btnTypeTopping.UseVisualStyleBackColor = false;
            this.btnTypeTopping.Click += new System.EventHandler(this.btnTypeTopping_Click);
            // 
            // labelMenuList
            // 
            this.labelMenuList.BackColor = System.Drawing.Color.White;
            this.labelMenuList.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelMenuList.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenuList.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelMenuList.Location = new System.Drawing.Point(0, 0);
            this.labelMenuList.Name = "labelMenuList";
            this.labelMenuList.Size = new System.Drawing.Size(743, 49);
            this.labelMenuList.TabIndex = 2;
            this.labelMenuList.Text = "THỰC ĐƠN";
            this.labelMenuList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlHoaDon
            // 
            this.pnlHoaDon.BackColor = System.Drawing.Color.White;
            this.pnlHoaDon.Controls.Add(this.lblThongBao);
            this.pnlHoaDon.Controls.Add(this.btnThanhTien);
            this.pnlHoaDon.Controls.Add(this.lvThongTinHoaDon);
            this.pnlHoaDon.Controls.Add(this.labelHoaDon);
            this.pnlHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHoaDon.Location = new System.Drawing.Point(743, 0);
            this.pnlHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlHoaDon.Name = "pnlHoaDon";
            this.pnlHoaDon.Size = new System.Drawing.Size(793, 639);
            this.pnlHoaDon.TabIndex = 1;
            // 
            // lblThongBao
            // 
            this.lblThongBao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblThongBao.BackColor = System.Drawing.Color.Transparent;
            this.lblThongBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongBao.ForeColor = System.Drawing.Color.Red;
            this.lblThongBao.Location = new System.Drawing.Point(7, 592);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(642, 30);
            this.lblThongBao.TabIndex = 10;
            this.lblThongBao.Text = "hiện thông báo về mật khẩu và tài khoản";
            this.lblThongBao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblThongBao.Visible = false;
            // 
            // btnThanhTien
            // 
            this.btnThanhTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThanhTien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(108)))), ((int)(((byte)(247)))));
            this.btnThanhTien.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(108)))), ((int)(((byte)(247)))));
            this.btnThanhTien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhTien.ForeColor = System.Drawing.Color.White;
            this.btnThanhTien.Location = new System.Drawing.Point(656, 573);
            this.btnThanhTien.Margin = new System.Windows.Forms.Padding(4);
            this.btnThanhTien.Name = "btnThanhTien";
            this.btnThanhTien.Size = new System.Drawing.Size(133, 62);
            this.btnThanhTien.TabIndex = 5;
            this.btnThanhTien.Text = "Thành Tiền";
            this.btnThanhTien.UseVisualStyleBackColor = false;
            this.btnThanhTien.Click += new System.EventHandler(this.btnThanhTien_Click);
            // 
            // lvThongTinHoaDon
            // 
            this.lvThongTinHoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvThongTinHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvThongTinHoaDon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chTenSanPham,
            this.chGia1,
            this.chSoLuong,
            this.chTien});
            this.lvThongTinHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvThongTinHoaDon.FullRowSelect = true;
            this.lvThongTinHoaDon.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvThongTinHoaDon.HideSelection = false;
            this.lvThongTinHoaDon.Location = new System.Drawing.Point(7, 54);
            this.lvThongTinHoaDon.Margin = new System.Windows.Forms.Padding(4);
            this.lvThongTinHoaDon.MultiSelect = false;
            this.lvThongTinHoaDon.Name = "lvThongTinHoaDon";
            this.lvThongTinHoaDon.Size = new System.Drawing.Size(781, 511);
            this.lvThongTinHoaDon.TabIndex = 4;
            this.lvThongTinHoaDon.UseCompatibleStateImageBehavior = false;
            this.lvThongTinHoaDon.View = System.Windows.Forms.View.Details;
            this.lvThongTinHoaDon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvThongTinHoaDon_MouseDoubleClick);
            // 
            // chTenSanPham
            // 
            this.chTenSanPham.Text = "Tên Sản Phẩm";
            this.chTenSanPham.Width = 340;
            // 
            // chGia1
            // 
            this.chGia1.Text = "Giá";
            this.chGia1.Width = 128;
            // 
            // chSoLuong
            // 
            this.chSoLuong.Text = "Số lượng";
            this.chSoLuong.Width = 132;
            // 
            // chTien
            // 
            this.chTien.Text = "Tiền";
            this.chTien.Width = 135;
            // 
            // labelHoaDon
            // 
            this.labelHoaDon.BackColor = System.Drawing.Color.White;
            this.labelHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelHoaDon.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHoaDon.Location = new System.Drawing.Point(0, 0);
            this.labelHoaDon.Name = "labelHoaDon";
            this.labelHoaDon.Size = new System.Drawing.Size(793, 50);
            this.labelHoaDon.TabIndex = 1;
            this.labelHoaDon.Text = "HÓA ĐƠN";
            this.labelHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmDisableThongBao
            // 
            this.tmDisableThongBao.Interval = 2000;
            this.tmDisableThongBao.Tick += new System.EventHandler(this.tmDisableThongBao_Tick);
            // 
            // TiepNhanDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1536, 639);
            this.Controls.Add(this.pnlHoaDon);
            this.Controls.Add(this.pnlMenu);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TiepNhanDonHang";
            this.Text = "TiepNhanDonHang";
            this.pnlMenu.ResumeLayout(false);
            this.pnlChonMon.ResumeLayout(false);
            this.fpnlLoai.ResumeLayout(false);
            this.pnlHoaDon.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlHoaDon;
        private System.Windows.Forms.Label labelHoaDon;
        private System.Windows.Forms.Label labelMenuList;
        private System.Windows.Forms.Panel pnlChonMon;
        private System.Windows.Forms.FlowLayoutPanel fpnlLoai;
        private Extra.BlackWhiteButton btnTypeTraSua;
        private Extra.BlackWhiteButton btnTypeCaPhe;
        private Extra.BlackWhiteButton btnTypeTopping;
        private System.Windows.Forms.ListView lvSanPhamTheoLoai;
        private System.Windows.Forms.ColumnHeader chTenSP;
        private System.Windows.Forms.ColumnHeader chGia;
        private System.Windows.Forms.ListView lvThongTinHoaDon;
        private System.Windows.Forms.ColumnHeader chTenSanPham;
        private System.Windows.Forms.ColumnHeader chGia1;
        private System.Windows.Forms.ColumnHeader chSoLuong;
        private System.Windows.Forms.Button btnThanhTien;
        private System.Windows.Forms.ColumnHeader chTien;
        private System.Windows.Forms.Label lblThongBao;
        private System.Windows.Forms.Timer tmDisableThongBao;
    }
}