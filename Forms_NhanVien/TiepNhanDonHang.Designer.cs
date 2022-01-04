
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
            this.panelHoaDon = new System.Windows.Forms.Panel();
            this.listViewThucUong = new System.Windows.Forms.ListView();
            this.labelHoaDon = new System.Windows.Forms.Label();
            this.labelMenuList = new System.Windows.Forms.Label();
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
            // listViewThucUong
            // 
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
            // labelHoaDon
            // 
            this.labelHoaDon.AutoSize = true;
            this.labelHoaDon.Location = new System.Drawing.Point(171, 44);
            this.labelHoaDon.Name = "labelHoaDon";
            this.labelHoaDon.Size = new System.Drawing.Size(73, 17);
            this.labelHoaDon.TabIndex = 1;
            this.labelHoaDon.Text = "HÓA ĐƠN";
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
    }
}