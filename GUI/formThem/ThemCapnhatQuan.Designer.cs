namespace ChinChin.GUI.formThem
{
    partial class ThemCapnhatQuan
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
            this.pnlMoveAndTitle = new System.Windows.Forms.Panel();
            this.btnExit = new FontAwesome.Sharp.IconPictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblMaQuan = new System.Windows.Forms.Label();
            this.lblTenQuan = new System.Windows.Forms.Label();
            this.tbcMaQuan = new ChinChin.Custom.TextBox_Custom();
            this.tbcTenQuan = new ChinChin.Custom.TextBox_Custom();
            this.btnTao = new ChinChin.Extra.BlackWhiteButton();
            this.pnlMoveAndTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMoveAndTitle
            // 
            this.pnlMoveAndTitle.Controls.Add(this.btnExit);
            this.pnlMoveAndTitle.Controls.Add(this.lblTitle);
            this.pnlMoveAndTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMoveAndTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlMoveAndTitle.Name = "pnlMoveAndTitle";
            this.pnlMoveAndTitle.Size = new System.Drawing.Size(416, 55);
            this.pnlMoveAndTitle.TabIndex = 32;
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
            this.btnExit.Location = new System.Drawing.Point(368, 2);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(46, 48);
            this.btnExit.TabIndex = 29;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTitle.Font = new System.Drawing.Font("Cascadia Code", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(363, 55);
            this.lblTitle.TabIndex = 30;
            this.lblTitle.Text = "Thêm Cập nhật Quán";
            // 
            // lblMaQuan
            // 
            this.lblMaQuan.AutoSize = true;
            this.lblMaQuan.BackColor = System.Drawing.Color.Transparent;
            this.lblMaQuan.Font = new System.Drawing.Font("Inter", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaQuan.Location = new System.Drawing.Point(11, 71);
            this.lblMaQuan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaQuan.Name = "lblMaQuan";
            this.lblMaQuan.Size = new System.Drawing.Size(122, 33);
            this.lblMaQuan.TabIndex = 33;
            this.lblMaQuan.Text = "Mã quán";
            this.lblMaQuan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTenQuan
            // 
            this.lblTenQuan.AutoSize = true;
            this.lblTenQuan.BackColor = System.Drawing.Color.Transparent;
            this.lblTenQuan.Font = new System.Drawing.Font("Inter", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenQuan.Location = new System.Drawing.Point(11, 152);
            this.lblTenQuan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenQuan.Name = "lblTenQuan";
            this.lblTenQuan.Size = new System.Drawing.Size(159, 33);
            this.lblTenQuan.TabIndex = 35;
            this.lblTenQuan.Text = "Tên hiển thị";
            this.lblTenQuan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbcMaQuan
            // 
            this.tbcMaQuan.BackColor = System.Drawing.Color.White;
            this.tbcMaQuan.ForeColor = System.Drawing.Color.White;
            this.tbcMaQuan.Location = new System.Drawing.Point(17, 108);
            this.tbcMaQuan.Margin = new System.Windows.Forms.Padding(4);
            this.tbcMaQuan.Name = "tbcMaQuan";
            this.tbcMaQuan.PasswordChar = '\0';
            this.tbcMaQuan.Size = new System.Drawing.Size(362, 40);
            this.tbcMaQuan.TabIndex = 34;
            // 
            // tbcTenQuan
            // 
            this.tbcTenQuan.ForeColor = System.Drawing.Color.White;
            this.tbcTenQuan.Location = new System.Drawing.Point(17, 191);
            this.tbcTenQuan.Margin = new System.Windows.Forms.Padding(6);
            this.tbcTenQuan.Name = "tbcTenQuan";
            this.tbcTenQuan.PasswordChar = '\0';
            this.tbcTenQuan.Size = new System.Drawing.Size(362, 40);
            this.tbcTenQuan.TabIndex = 36;
            // 
            // btnTao
            // 
            this.btnTao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(108)))), ((int)(((byte)(247)))));
            this.btnTao.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(108)))), ((int)(((byte)(247)))));
            this.btnTao.BorderColor = System.Drawing.Color.Black;
            this.btnTao.BorderRadius = 0;
            this.btnTao.BorderSize = 0;
            this.btnTao.FlatAppearance.BorderSize = 0;
            this.btnTao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTao.Font = new System.Drawing.Font("Inter", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTao.ForeColor = System.Drawing.Color.White;
            this.btnTao.Location = new System.Drawing.Point(217, 252);
            this.btnTao.Margin = new System.Windows.Forms.Padding(2);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(162, 50);
            this.btnTao.TabIndex = 37;
            this.btnTao.Text = "Tạo và Lưu";
            this.btnTao.TextColor = System.Drawing.Color.White;
            this.btnTao.UseVisualStyleBackColor = false;
            this.btnTao.Click += new System.EventHandler(this.btnTaoVaLuu_Click);
            // 
            // ThemCapnhatQuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(416, 328);
            this.ControlBox = false;
            this.Controls.Add(this.btnTao);
            this.Controls.Add(this.lblMaQuan);
            this.Controls.Add(this.tbcMaQuan);
            this.Controls.Add(this.lblTenQuan);
            this.Controls.Add(this.tbcTenQuan);
            this.Controls.Add(this.pnlMoveAndTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ThemCapnhatQuan";
            this.pnlMoveAndTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMoveAndTitle;
        private System.Windows.Forms.Label lblTitle;
        private FontAwesome.Sharp.IconPictureBox btnExit;
        private System.Windows.Forms.Label lblMaQuan;
        private Custom.TextBox_Custom tbcMaQuan;
        private System.Windows.Forms.Label lblTenQuan;
        private Custom.TextBox_Custom tbcTenQuan;
        private Extra.BlackWhiteButton btnTao;
    }
}