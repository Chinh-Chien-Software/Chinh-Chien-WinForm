
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
            this.flowLayoutPanelMenuList = new System.Windows.Forms.FlowLayoutPanel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.labelMenuList = new System.Windows.Forms.Label();
            this.panelHoaDon = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelHoaDon = new System.Windows.Forms.Label();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanelMenuList
            // 
            this.flowLayoutPanelMenuList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanelMenuList.Location = new System.Drawing.Point(0, 103);
            this.flowLayoutPanelMenuList.Name = "flowLayoutPanelMenuList";
            this.flowLayoutPanelMenuList.Size = new System.Drawing.Size(526, 930);
            this.flowLayoutPanelMenuList.TabIndex = 1;
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.labelMenuList);
            this.panelMenu.Controls.Add(this.flowLayoutPanelMenuList);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(526, 1033);
            this.panelMenu.TabIndex = 0;
            // 
            // labelMenuList
            // 
            this.labelMenuList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMenuList.Location = new System.Drawing.Point(0, 0);
            this.labelMenuList.Name = "labelMenuList";
            this.labelMenuList.Size = new System.Drawing.Size(526, 103);
            this.labelMenuList.TabIndex = 2;
            this.labelMenuList.Text = "MENU";
            // 
            // panelHoaDon
            // 
            this.panelHoaDon.Controls.Add(this.dataGridView1);
            this.panelHoaDon.Controls.Add(this.labelHoaDon);
            this.panelHoaDon.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelHoaDon.Location = new System.Drawing.Point(728, 0);
            this.panelHoaDon.Name = "panelHoaDon";
            this.panelHoaDon.Size = new System.Drawing.Size(874, 1033);
            this.panelHoaDon.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.Ten,
            this.SoLuong,
            this.Gia,
            this.TongTien});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(874, 983);
            this.dataGridView1.TabIndex = 2;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.ToolTipText = "Số Thứ Tự";
            this.STT.Width = 125;
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
            this.SoLuong.Width = 125;
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
            this.labelHoaDon.Location = new System.Drawing.Point(0, 0);
            this.labelHoaDon.Name = "labelHoaDon";
            this.labelHoaDon.Size = new System.Drawing.Size(874, 50);
            this.labelHoaDon.TabIndex = 1;
            this.labelHoaDon.Text = "HÓA ĐƠN";
            // 
            // panelButtons
            // 
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelButtons.Location = new System.Drawing.Point(526, 0);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(202, 1033);
            this.panelButtons.TabIndex = 2;
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMenuList;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelHoaDon;
        private System.Windows.Forms.Label labelHoaDon;
        private System.Windows.Forms.Label labelMenuList;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.Panel panelButtons;
    }
}