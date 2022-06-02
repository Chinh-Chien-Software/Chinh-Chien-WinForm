
namespace ChinhChien.FormsChuQuan
{
    partial class FormChamCong
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
            this.labelChamCong = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelChamCong
            // 
            this.labelChamCong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelChamCong.AutoSize = true;
            this.labelChamCong.Location = new System.Drawing.Point(308, 52);
            this.labelChamCong.Name = "labelChamCong";
            this.labelChamCong.Size = new System.Drawing.Size(178, 17);
            this.labelChamCong.TabIndex = 1;
            this.labelChamCong.Text = "Chấm Công cho Nhân Viên";
            // 
            // FormChamCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelChamCong);
            this.Name = "FormChamCong";
            this.Text = "Chấm Công";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelChamCong;
    }
}