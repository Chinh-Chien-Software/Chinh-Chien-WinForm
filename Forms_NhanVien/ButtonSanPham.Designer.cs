
namespace ChinChin.Forms_NhanVien
{
    partial class ButtonSanPham
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTenSanPham = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTenSanPham
            // 
            this.labelTenSanPham.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTenSanPham.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenSanPham.Location = new System.Drawing.Point(0, 0);
            this.labelTenSanPham.Name = "labelTenSanPham";
            this.labelTenSanPham.Size = new System.Drawing.Size(148, 149);
            this.labelTenSanPham.TabIndex = 0;
            this.labelTenSanPham.Text = "Tên Sản Phẩm";
            this.labelTenSanPham.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTenSanPham.Click += new System.EventHandler(this.labelTenSanPham_Click);
            // 
            // ButtonSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.labelTenSanPham);
            this.Name = "ButtonSanPham";
            this.Size = new System.Drawing.Size(148, 148);
            this.MouseEnter += new System.EventHandler(this.ButtonSanPham_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ButtonSanPham_MouseLeave);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTenSanPham;
    }
}
