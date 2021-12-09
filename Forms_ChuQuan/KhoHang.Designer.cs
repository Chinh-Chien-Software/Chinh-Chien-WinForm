
namespace ChinChin.FormsChuQuan
{
    partial class FormKhoHang
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
            this.labelKhoHang = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelKhoHang
            // 
            this.labelKhoHang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelKhoHang.AutoSize = true;
            this.labelKhoHang.Location = new System.Drawing.Point(293, 72);
            this.labelKhoHang.Name = "labelKhoHang";
            this.labelKhoHang.Size = new System.Drawing.Size(154, 17);
            this.labelKhoHang.TabIndex = 1;
            this.labelKhoHang.Text = "Kho Hàng Chứa Tất Cà";
            // 
            // FormKhoHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelKhoHang);
            this.Name = "FormKhoHang";
            this.Text = "KhoHang";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelKhoHang;
    }
}