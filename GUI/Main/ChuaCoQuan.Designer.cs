namespace ChinChin.GUI.Main
{
    partial class ChuaCoQuan
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnTaoQuan = new System.Windows.Forms.Button();
            this.btnThamGiaQuan = new System.Windows.Forms.Button();
            this.btnExit = new FontAwesome.Sharp.IconPictureBox();
            this.ipbBack = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipbBack)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(245, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bạn chưa có quán!";
            // 
            // btnTaoQuan
            // 
            this.btnTaoQuan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(108)))), ((int)(((byte)(247)))));
            this.btnTaoQuan.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTaoQuan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaoQuan.Font = new System.Drawing.Font("Cascadia Code", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoQuan.Location = new System.Drawing.Point(216, 220);
            this.btnTaoQuan.Name = "btnTaoQuan";
            this.btnTaoQuan.Size = new System.Drawing.Size(150, 150);
            this.btnTaoQuan.TabIndex = 1;
            this.btnTaoQuan.Text = "Tạo Quán Mới";
            this.btnTaoQuan.UseVisualStyleBackColor = false;
            this.btnTaoQuan.Click += new System.EventHandler(this.btnTaoQuan_Click);
            // 
            // btnThamGiaQuan
            // 
            this.btnThamGiaQuan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(108)))), ((int)(((byte)(247)))));
            this.btnThamGiaQuan.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnThamGiaQuan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThamGiaQuan.Font = new System.Drawing.Font("Cascadia Code", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThamGiaQuan.Location = new System.Drawing.Point(403, 220);
            this.btnThamGiaQuan.Name = "btnThamGiaQuan";
            this.btnThamGiaQuan.Size = new System.Drawing.Size(150, 150);
            this.btnThamGiaQuan.TabIndex = 2;
            this.btnThamGiaQuan.Text = "Tham Gia Quán";
            this.btnThamGiaQuan.UseVisualStyleBackColor = false;
            this.btnThamGiaQuan.Click += new System.EventHandler(this.btnThamGiaQuan_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btnExit.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 46;
            this.btnExit.Location = new System.Drawing.Point(743, 11);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(46, 48);
            this.btnExit.TabIndex = 10;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ipbBack
            // 
            this.ipbBack.BackColor = System.Drawing.Color.Transparent;
            this.ipbBack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ipbBack.IconChar = FontAwesome.Sharp.IconChar.LongArrowAltLeft;
            this.ipbBack.IconColor = System.Drawing.SystemColors.ControlText;
            this.ipbBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ipbBack.IconSize = 46;
            this.ipbBack.Location = new System.Drawing.Point(11, 11);
            this.ipbBack.Margin = new System.Windows.Forms.Padding(2);
            this.ipbBack.Name = "ipbBack";
            this.ipbBack.Size = new System.Drawing.Size(46, 48);
            this.ipbBack.TabIndex = 11;
            this.ipbBack.TabStop = false;
            this.ipbBack.Click += new System.EventHandler(this.ipbBack_Click);
            // 
            // ChuaCoQuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ipbBack);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnThamGiaQuan);
            this.Controls.Add(this.btnTaoQuan);
            this.Controls.Add(this.label1);
            this.Name = "ChuaCoQuan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TaoQuan";
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipbBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTaoQuan;
        private System.Windows.Forms.Button btnThamGiaQuan;
        private FontAwesome.Sharp.IconPictureBox btnExit;
        private FontAwesome.Sharp.IconPictureBox ipbBack;
    }
}