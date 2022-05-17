
namespace ChinChin.FormsChuQuan
{
    partial class FormThongKe
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
            this.pnlDoanhThu = new System.Windows.Forms.Panel();
            this.lblSanPham = new System.Windows.Forms.Label();
            this.pnlLoiNhuan = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlDoanhThu.SuspendLayout();
            this.pnlLoiNhuan.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDoanhThu
            // 
            this.pnlDoanhThu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(108)))), ((int)(((byte)(247)))));
            this.pnlDoanhThu.Controls.Add(this.lblSanPham);
            this.pnlDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlDoanhThu.Location = new System.Drawing.Point(12, 12);
            this.pnlDoanhThu.Name = "pnlDoanhThu";
            this.pnlDoanhThu.Size = new System.Drawing.Size(200, 100);
            this.pnlDoanhThu.TabIndex = 0;
            // 
            // lblSanPham
            // 
            this.lblSanPham.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSanPham.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSanPham.ForeColor = System.Drawing.Color.White;
            this.lblSanPham.Location = new System.Drawing.Point(0, 0);
            this.lblSanPham.Name = "lblSanPham";
            this.lblSanPham.Size = new System.Drawing.Size(200, 40);
            this.lblSanPham.TabIndex = 0;
            this.lblSanPham.Text = "Sản phẩm bán chạy";
            this.lblSanPham.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlLoiNhuan
            // 
            this.pnlLoiNhuan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(108)))), ((int)(((byte)(247)))));
            this.pnlLoiNhuan.Controls.Add(this.label1);
            this.pnlLoiNhuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlLoiNhuan.Location = new System.Drawing.Point(231, 12);
            this.pnlLoiNhuan.Name = "pnlLoiNhuan";
            this.pnlLoiNhuan.Size = new System.Drawing.Size(200, 100);
            this.pnlLoiNhuan.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lợi Nhuận";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(686, 433);
            this.Controls.Add(this.pnlLoiNhuan);
            this.Controls.Add(this.pnlDoanhThu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormThongKe";
            this.Text = "Xem Thống Kê";
            this.Load += new System.EventHandler(this.FormThongKe_Load);
            this.pnlDoanhThu.ResumeLayout(false);
            this.pnlLoiNhuan.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDoanhThu;
        private System.Windows.Forms.Label lblSanPham;
        private System.Windows.Forms.Panel pnlLoiNhuan;
        private System.Windows.Forms.Label label1;
    }
}