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
            this.btnTaoQuan = new System.Windows.Forms.Button();
            this.btnThamGiaQuan = new System.Windows.Forms.Button();
            this.ipbBack = new FontAwesome.Sharp.IconPictureBox();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.pnlMoveAndTitle = new System.Windows.Forms.Panel();
            this.btnExit = new FontAwesome.Sharp.IconPictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ipbBack)).BeginInit();
            this.pnlButtons.SuspendLayout();
            this.pnlMoveAndTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTaoQuan
            // 
            this.btnTaoQuan.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTaoQuan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(108)))), ((int)(((byte)(247)))));
            this.btnTaoQuan.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTaoQuan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaoQuan.Font = new System.Drawing.Font("Cascadia Code", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoQuan.Location = new System.Drawing.Point(3, 3);
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
            this.btnThamGiaQuan.Location = new System.Drawing.Point(159, 3);
            this.btnThamGiaQuan.Name = "btnThamGiaQuan";
            this.btnThamGiaQuan.Size = new System.Drawing.Size(150, 150);
            this.btnThamGiaQuan.TabIndex = 2;
            this.btnThamGiaQuan.Text = "Tham Gia Quán";
            this.btnThamGiaQuan.UseVisualStyleBackColor = false;
            this.btnThamGiaQuan.Click += new System.EventHandler(this.btnThamGiaQuan_Click);
            // 
            // ipbBack
            // 
            this.ipbBack.BackColor = System.Drawing.Color.Transparent;
            this.ipbBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.ipbBack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ipbBack.IconChar = FontAwesome.Sharp.IconChar.LongArrowAltLeft;
            this.ipbBack.IconColor = System.Drawing.SystemColors.ControlText;
            this.ipbBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ipbBack.IconSize = 46;
            this.ipbBack.Location = new System.Drawing.Point(0, 0);
            this.ipbBack.Margin = new System.Windows.Forms.Padding(2);
            this.ipbBack.Name = "ipbBack";
            this.ipbBack.Size = new System.Drawing.Size(46, 55);
            this.ipbBack.TabIndex = 11;
            this.ipbBack.TabStop = false;
            this.ipbBack.Click += new System.EventHandler(this.ipbBack_Click);
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnThamGiaQuan);
            this.pnlButtons.Controls.Add(this.btnTaoQuan);
            this.pnlButtons.Location = new System.Drawing.Point(54, 61);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(314, 158);
            this.pnlButtons.TabIndex = 12;
            // 
            // pnlMoveAndTitle
            // 
            this.pnlMoveAndTitle.Controls.Add(this.btnExit);
            this.pnlMoveAndTitle.Controls.Add(this.lblTitle);
            this.pnlMoveAndTitle.Controls.Add(this.ipbBack);
            this.pnlMoveAndTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMoveAndTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlMoveAndTitle.Name = "pnlMoveAndTitle";
            this.pnlMoveAndTitle.Size = new System.Drawing.Size(438, 55);
            this.pnlMoveAndTitle.TabIndex = 33;
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
            this.btnExit.Location = new System.Drawing.Point(390, 2);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(46, 48);
            this.btnExit.TabIndex = 29;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Cascadia Code", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(46, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(392, 55);
            this.lblTitle.TabIndex = 30;
            this.lblTitle.Text = "Bạn chưa có quán!";
            // 
            // ChuaCoQuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(438, 239);
            this.ControlBox = false;
            this.Controls.Add(this.pnlMoveAndTitle);
            this.Controls.Add(this.pnlButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ChuaCoQuan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.ipbBack)).EndInit();
            this.pnlButtons.ResumeLayout(false);
            this.pnlMoveAndTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnTaoQuan;
        private System.Windows.Forms.Button btnThamGiaQuan;
        private FontAwesome.Sharp.IconPictureBox ipbBack;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Panel pnlMoveAndTitle;
        private FontAwesome.Sharp.IconPictureBox btnExit;
        private System.Windows.Forms.Label lblTitle;
    }
}