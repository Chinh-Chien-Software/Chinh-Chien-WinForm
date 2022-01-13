
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.labelMenuList = new System.Windows.Forms.Label();
            this.panelHoaDon = new System.Windows.Forms.Panel();
            this.dataGridViewDanhSanhHoaDon = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelHoaDon = new System.Windows.Forms.Label();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.labelTenSanPham = new System.Windows.Forms.Label();
            this.labelSoLuong = new System.Windows.Forms.Label();
            this.textBoxSoLuong = new System.Windows.Forms.TextBox();
            this.flowLayoutPanelMenuList = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhSanhHoaDon)).BeginInit();
            this.panelButtons.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenu.Controls.Add(this.flowLayoutPanelMenuList);
            this.panelMenu.Controls.Add(this.labelMenuList);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(744, 1033);
            this.panelMenu.TabIndex = 0;
            // 
            // labelMenuList
            // 
            this.labelMenuList.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelMenuList.Font = new System.Drawing.Font("Cascadia Code", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenuList.Location = new System.Drawing.Point(0, 0);
            this.labelMenuList.Name = "labelMenuList";
            this.labelMenuList.Size = new System.Drawing.Size(742, 49);
            this.labelMenuList.TabIndex = 2;
            this.labelMenuList.Text = "MENU";
            this.labelMenuList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelHoaDon
            // 
            this.panelHoaDon.Controls.Add(this.dataGridViewDanhSanhHoaDon);
            this.panelHoaDon.Controls.Add(this.labelHoaDon);
            this.panelHoaDon.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelHoaDon.Location = new System.Drawing.Point(834, 0);
            this.panelHoaDon.Name = "panelHoaDon";
            this.panelHoaDon.Size = new System.Drawing.Size(768, 1033);
            this.panelHoaDon.TabIndex = 1;
            // 
            // dataGridViewDanhSanhHoaDon
            // 
            this.dataGridViewDanhSanhHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDanhSanhHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.Ten,
            this.SoLuong,
            this.Gia,
            this.TongTien});
            this.dataGridViewDanhSanhHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDanhSanhHoaDon.Location = new System.Drawing.Point(0, 50);
            this.dataGridViewDanhSanhHoaDon.Name = "dataGridViewDanhSanhHoaDon";
            this.dataGridViewDanhSanhHoaDon.RowHeadersWidth = 51;
            this.dataGridViewDanhSanhHoaDon.RowTemplate.Height = 24;
            this.dataGridViewDanhSanhHoaDon.Size = new System.Drawing.Size(768, 983);
            this.dataGridViewDanhSanhHoaDon.TabIndex = 2;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.ToolTipText = "Số Thứ Tự";
            this.STT.Width = 50;
            // 
            // Ten
            // 
            this.Ten.HeaderText = "Tên";
            this.Ten.MinimumWidth = 6;
            this.Ten.Name = "Ten";
            this.Ten.Width = 125;
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "S.Lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ToolTipText = "Số Lượng";
            this.SoLuong.Width = 65;
            // 
            // Gia
            // 
            this.Gia.HeaderText = "Giá";
            this.Gia.MinimumWidth = 6;
            this.Gia.Name = "Gia";
            this.Gia.Width = 125;
            // 
            // TongTien
            // 
            this.TongTien.HeaderText = "T.Tiền";
            this.TongTien.MinimumWidth = 6;
            this.TongTien.Name = "TongTien";
            this.TongTien.Width = 125;
            // 
            // labelHoaDon
            // 
            this.labelHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelHoaDon.Font = new System.Drawing.Font("Cascadia Code", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHoaDon.Location = new System.Drawing.Point(0, 0);
            this.labelHoaDon.Name = "labelHoaDon";
            this.labelHoaDon.Size = new System.Drawing.Size(768, 50);
            this.labelHoaDon.TabIndex = 1;
            this.labelHoaDon.Text = "HÓA ĐƠN";
            this.labelHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelButtons
            // 
            this.panelButtons.AutoSize = true;
            this.panelButtons.Controls.Add(this.panel1);
            this.panelButtons.Controls.Add(this.labelTenSanPham);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelButtons.Location = new System.Drawing.Point(744, 0);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(90, 1033);
            this.panelButtons.TabIndex = 2;
            // 
            // labelTenSanPham
            // 
            this.labelTenSanPham.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTenSanPham.Font = new System.Drawing.Font("Cascadia Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenSanPham.Location = new System.Drawing.Point(0, 0);
            this.labelTenSanPham.Name = "labelTenSanPham";
            this.labelTenSanPham.Size = new System.Drawing.Size(90, 266);
            this.labelTenSanPham.TabIndex = 0;
            this.labelTenSanPham.Text = "Tên Sản Phẩm";
            this.labelTenSanPham.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // labelSoLuong
            // 
            this.labelSoLuong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelSoLuong.AutoSize = true;
            this.labelSoLuong.Location = new System.Drawing.Point(-58, 6);
            this.labelSoLuong.Name = "labelSoLuong";
            this.labelSoLuong.Size = new System.Drawing.Size(25, 17);
            this.labelSoLuong.TabIndex = 1;
            this.labelSoLuong.Text = "SL";
            // 
            // textBoxSoLuong
            // 
            this.textBoxSoLuong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxSoLuong.Location = new System.Drawing.Point(-28, 3);
            this.textBoxSoLuong.Name = "textBoxSoLuong";
            this.textBoxSoLuong.Size = new System.Drawing.Size(151, 22);
            this.textBoxSoLuong.TabIndex = 2;
            // 
            // flowLayoutPanelMenuList
            // 
            this.flowLayoutPanelMenuList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelMenuList.Location = new System.Drawing.Point(0, 49);
            this.flowLayoutPanelMenuList.Name = "flowLayoutPanelMenuList";
            this.flowLayoutPanelMenuList.Size = new System.Drawing.Size(742, 982);
            this.flowLayoutPanelMenuList.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxSoLuong);
            this.panel1.Controls.Add(this.labelSoLuong);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 266);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(90, 767);
            this.panel1.TabIndex = 3;
            // 
            // TiepNhanDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1602, 1033);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.panelHoaDon);
            this.Controls.Add(this.panelMenu);
            this.Name = "TiepNhanDonHang";
            this.Text = "TiepNhanDonHang";
            this.panelMenu.ResumeLayout(false);
            this.panelHoaDon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhSanhHoaDon)).EndInit();
            this.panelButtons.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelHoaDon;
        private System.Windows.Forms.Label labelHoaDon;
        private System.Windows.Forms.Label labelMenuList;
        private System.Windows.Forms.DataGridView dataGridViewDanhSanhHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Label labelTenSanPham;
        private System.Windows.Forms.Label labelSoLuong;
        private System.Windows.Forms.TextBox textBoxSoLuong;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMenuList;
        private System.Windows.Forms.Panel panel1;
    }
}