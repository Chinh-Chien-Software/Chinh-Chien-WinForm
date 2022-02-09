
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
            this.panelDoanhThu = new System.Windows.Forms.Panel();
            this.labelDoanhThu = new System.Windows.Forms.Label();
            this.panelDoanhThu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDoanhThu
            // 
            this.panelDoanhThu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelDoanhThu.Controls.Add(this.labelDoanhThu);
            this.panelDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelDoanhThu.Location = new System.Drawing.Point(238, 150);
            this.panelDoanhThu.Name = "panelDoanhThu";
            this.panelDoanhThu.Size = new System.Drawing.Size(200, 100);
            this.panelDoanhThu.TabIndex = 0;
            // 
            // labelDoanhThu
            // 
            this.labelDoanhThu.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDoanhThu.Location = new System.Drawing.Point(0, 0);
            this.labelDoanhThu.Name = "labelDoanhThu";
            this.labelDoanhThu.Size = new System.Drawing.Size(200, 40);
            this.labelDoanhThu.TabIndex = 0;
            this.labelDoanhThu.Text = "DOANH THU";
            this.labelDoanhThu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 433);
            this.Controls.Add(this.panelDoanhThu);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormThongKe";
            this.Text = "Xem Thống Kê";
            this.Load += new System.EventHandler(this.FormThongKe_Load);
            this.panelDoanhThu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDoanhThu;
        private System.Windows.Forms.Label labelDoanhThu;
    }
}