
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
            this.labelThongKe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelThongKe
            // 
            this.labelThongKe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelThongKe.AutoSize = true;
            this.labelThongKe.Location = new System.Drawing.Point(312, 171);
            this.labelThongKe.Name = "labelThongKe";
            this.labelThongKe.Size = new System.Drawing.Size(139, 17);
            this.labelThongKe.TabIndex = 0;
            this.labelThongKe.Text = "Thống Kê Lại Tất Cà";
            // 
            // FormThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 533);
            this.Controls.Add(this.labelThongKe);
            this.Name = "FormThongKe";
            this.Text = "ThongKe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelThongKe;
    }
}