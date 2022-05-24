
namespace ChinChin.GUI
{
    partial class BaoCao
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
            this.cRV = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // cRV
            // 
            this.cRV.ActiveViewIndex = -1;
            this.cRV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cRV.Cursor = System.Windows.Forms.Cursors.Default;
            this.cRV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cRV.Location = new System.Drawing.Point(0, 0);
            this.cRV.Name = "cRV";
            this.cRV.Size = new System.Drawing.Size(800, 450);
            this.cRV.TabIndex = 0;
            // 
            // BaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cRV);
            this.Name = "BaoCao";
            this.Text = "BaoCao";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer cRV;
    }
}