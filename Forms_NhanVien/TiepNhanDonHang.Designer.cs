
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
            this.labelHoaDon = new System.Windows.Forms.Label();
            this.listViewThucUong = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelMenu.SuspendLayout();
            this.panelHoaDon.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanelMenuList
            // 
            this.flowLayoutPanelMenuList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanelMenuList.Location = new System.Drawing.Point(0, 103);
            this.flowLayoutPanelMenuList.Name = "flowLayoutPanelMenuList";
            this.flowLayoutPanelMenuList.Size = new System.Drawing.Size(800, 930);
            this.flowLayoutPanelMenuList.TabIndex = 1;
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.labelMenuList);
            this.panelMenu.Controls.Add(this.flowLayoutPanelMenuList);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(800, 1033);
            this.panelMenu.TabIndex = 0;
            // 
            // labelMenuList
            // 
            this.labelMenuList.AutoSize = true;
            this.labelMenuList.Location = new System.Drawing.Point(359, 43);
            this.labelMenuList.Name = "labelMenuList";
            this.labelMenuList.Size = new System.Drawing.Size(48, 17);
            this.labelMenuList.TabIndex = 2;
            this.labelMenuList.Text = "MENU";
            // 
            // panelHoaDon
            // 
            this.panelHoaDon.Controls.Add(this.labelHoaDon);
            this.panelHoaDon.Controls.Add(this.listViewThucUong);
            this.panelHoaDon.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelHoaDon.Location = new System.Drawing.Point(1102, 0);
            this.panelHoaDon.Name = "panelHoaDon";
            this.panelHoaDon.Size = new System.Drawing.Size(500, 1033);
            this.panelHoaDon.TabIndex = 1;
            // 
            // labelHoaDon
            // 
            this.labelHoaDon.AutoSize = true;
            this.labelHoaDon.Location = new System.Drawing.Point(171, 44);
            this.labelHoaDon.Name = "labelHoaDon";
            this.labelHoaDon.Size = new System.Drawing.Size(73, 17);
            this.labelHoaDon.TabIndex = 1;
            this.labelHoaDon.Text = "HÓA ĐƠN";
            // 
            // listViewThucUong
            // 
            this.listViewThucUong.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewThucUong.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listViewThucUong.GridLines = true;
            this.listViewThucUong.HideSelection = false;
            this.listViewThucUong.Location = new System.Drawing.Point(0, 103);
            this.listViewThucUong.Name = "listViewThucUong";
            this.listViewThucUong.Size = new System.Drawing.Size(500, 930);
            this.listViewThucUong.TabIndex = 0;
            this.listViewThucUong.UseCompatibleStateImageBehavior = false;
            this.listViewThucUong.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "S.Lượng";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Giá";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "T.Tiền";
            // 
            // TiepNhanDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1602, 1033);
            this.Controls.Add(this.panelHoaDon);
            this.Controls.Add(this.panelMenu);
            this.Name = "TiepNhanDonHang";
            this.Text = "TiepNhanDonHang";
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelHoaDon.ResumeLayout(false);
            this.panelHoaDon.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMenuList;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelHoaDon;
        private System.Windows.Forms.ListView listViewThucUong;
        private System.Windows.Forms.Label labelHoaDon;
        private System.Windows.Forms.Label labelMenuList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}