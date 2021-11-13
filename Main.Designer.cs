
namespace ChinChin
{
    partial class Main
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.ChamCongBTN = new FontAwesome.Sharp.IconButton();
            this.KhoHangBTN = new FontAwesome.Sharp.IconButton();
            this.ThongKeBTN = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.labelName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.panelMenu.Controls.Add(this.ChamCongBTN);
            this.panelMenu.Controls.Add(this.KhoHangBTN);
            this.panelMenu.Controls.Add(this.ThongKeBTN);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.ForeColor = System.Drawing.Color.Coral;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(250, 628);
            this.panelMenu.TabIndex = 0;
            // 
            // ChamCongBTN
            // 
            this.ChamCongBTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.ChamCongBTN.FlatAppearance.BorderSize = 0;
            this.ChamCongBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChamCongBTN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ChamCongBTN.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckAlt;
            this.ChamCongBTN.IconColor = System.Drawing.Color.YellowGreen;
            this.ChamCongBTN.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ChamCongBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ChamCongBTN.Location = new System.Drawing.Point(0, 245);
            this.ChamCongBTN.Name = "ChamCongBTN";
            this.ChamCongBTN.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ChamCongBTN.Size = new System.Drawing.Size(250, 60);
            this.ChamCongBTN.TabIndex = 3;
            this.ChamCongBTN.Text = "CHẤM CÔNG";
            this.ChamCongBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ChamCongBTN.UseVisualStyleBackColor = true;
            // 
            // KhoHangBTN
            // 
            this.KhoHangBTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.KhoHangBTN.FlatAppearance.BorderSize = 0;
            this.KhoHangBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KhoHangBTN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.KhoHangBTN.IconChar = FontAwesome.Sharp.IconChar.Boxes;
            this.KhoHangBTN.IconColor = System.Drawing.Color.YellowGreen;
            this.KhoHangBTN.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.KhoHangBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.KhoHangBTN.Location = new System.Drawing.Point(0, 185);
            this.KhoHangBTN.Name = "KhoHangBTN";
            this.KhoHangBTN.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.KhoHangBTN.Size = new System.Drawing.Size(250, 60);
            this.KhoHangBTN.TabIndex = 2;
            this.KhoHangBTN.Text = "KHO HÀNG";
            this.KhoHangBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.KhoHangBTN.UseVisualStyleBackColor = true;
            // 
            // ThongKeBTN
            // 
            this.ThongKeBTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.ThongKeBTN.FlatAppearance.BorderSize = 0;
            this.ThongKeBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ThongKeBTN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ThongKeBTN.IconChar = FontAwesome.Sharp.IconChar.Dashcube;
            this.ThongKeBTN.IconColor = System.Drawing.Color.YellowGreen;
            this.ThongKeBTN.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ThongKeBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ThongKeBTN.Location = new System.Drawing.Point(0, 125);
            this.ThongKeBTN.Name = "ThongKeBTN";
            this.ThongKeBTN.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ThongKeBTN.Size = new System.Drawing.Size(250, 60);
            this.ThongKeBTN.TabIndex = 1;
            this.ThongKeBTN.Text = "THỐNG KÊ";
            this.ThongKeBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ThongKeBTN.UseVisualStyleBackColor = true;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panelLogo.Controls.Add(this.labelName);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 125);
            this.panelLogo.TabIndex = 0;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("MV Boli", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.Black;
            this.labelName.Location = new System.Drawing.Point(12, 29);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(215, 63);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "ChinChin";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(250, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(925, 50);
            this.panel2.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1175, 628);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Panel panel2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private FontAwesome.Sharp.IconButton ChamCongBTN;
        private FontAwesome.Sharp.IconButton KhoHangBTN;
        private FontAwesome.Sharp.IconButton ThongKeBTN;
    }
}

