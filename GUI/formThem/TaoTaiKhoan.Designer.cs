namespace ChinhChien.GUI.formThem
{
    partial class frmTaoTaiKhoan
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
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnGo = new ChinhChien.Extra.BlackWhiteButton();
            this.btnLuu = new ChinhChien.Extra.BlackWhiteButton();
            this.pnlMoveAndTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnExit = new FontAwesome.Sharp.IconPictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlThongTin = new System.Windows.Forms.Panel();
            this.labelLoi = new System.Windows.Forms.Label();
            this.tbcMk = new ChinhChien.Custom.TextBox_Custom();
            this.tbcEmail = new ChinhChien.Custom.TextBox_Custom();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblTenTaiKhoan = new System.Windows.Forms.Label();
            this.tbcTenTk = new ChinhChien.Custom.TextBox_Custom();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.pnlBottom.SuspendLayout();
            this.pnlMoveAndTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.pnlThongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.White;
            this.pnlBottom.Controls.Add(this.btnGo);
            this.pnlBottom.Controls.Add(this.btnLuu);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 437);
            this.pnlBottom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(723, 69);
            this.pnlBottom.TabIndex = 38;
            // 
            // btnGo
            // 
            this.btnGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(108)))), ((int)(((byte)(247)))));
            this.btnGo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(108)))), ((int)(((byte)(247)))));
            this.btnGo.BorderColor = System.Drawing.Color.Black;
            this.btnGo.BorderRadius = 0;
            this.btnGo.BorderSize = 0;
            this.btnGo.FlatAppearance.BorderSize = 0;
            this.btnGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo.ForeColor = System.Drawing.Color.White;
            this.btnGo.Location = new System.Drawing.Point(9, 5);
            this.btnGo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(344, 62);
            this.btnGo.TabIndex = 32;
            this.btnGo.Text = "Gỡ ";
            this.btnGo.TextColor = System.Drawing.Color.White;
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(108)))), ((int)(((byte)(247)))));
            this.btnLuu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(108)))), ((int)(((byte)(247)))));
            this.btnLuu.BorderColor = System.Drawing.Color.Black;
            this.btnLuu.BorderRadius = 0;
            this.btnLuu.BorderSize = 0;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(376, 5);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(344, 62);
            this.btnLuu.TabIndex = 31;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextColor = System.Drawing.Color.White;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // pnlMoveAndTitle
            // 
            this.pnlMoveAndTitle.BackColor = System.Drawing.Color.White;
            this.pnlMoveAndTitle.Controls.Add(this.lblTitle);
            this.pnlMoveAndTitle.Controls.Add(this.btnExit);
            this.pnlMoveAndTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMoveAndTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlMoveAndTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlMoveAndTitle.Name = "pnlMoveAndTitle";
            this.pnlMoveAndTitle.Size = new System.Drawing.Size(723, 68);
            this.pnlMoveAndTitle.TabIndex = 37;
            this.pnlMoveAndTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlMoveAndTitle_MouseDown);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTitle.Font = new System.Drawing.Font("Cascadia Code", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(619, 68);
            this.lblTitle.TabIndex = 33;
            this.lblTitle.Text = "Tạo tài khoản";
            this.lblTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblTitle_MouseDown);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btnExit.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 59;
            this.btnExit.Location = new System.Drawing.Point(659, 7);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(61, 59);
            this.btnExit.TabIndex = 32;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 38);
            this.label5.TabIndex = 28;
            this.label5.Text = "Mật khẩu";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlThongTin
            // 
            this.pnlThongTin.BackColor = System.Drawing.Color.White;
            this.pnlThongTin.Controls.Add(this.labelLoi);
            this.pnlThongTin.Controls.Add(this.tbcMk);
            this.pnlThongTin.Controls.Add(this.label5);
            this.pnlThongTin.Controls.Add(this.tbcEmail);
            this.pnlThongTin.Controls.Add(this.lblUserName);
            this.pnlThongTin.Controls.Add(this.lblTenTaiKhoan);
            this.pnlThongTin.Controls.Add(this.tbcTenTk);
            this.pnlThongTin.Controls.Add(this.lblNgaySinh);
            this.pnlThongTin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlThongTin.Location = new System.Drawing.Point(0, 0);
            this.pnlThongTin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlThongTin.Name = "pnlThongTin";
            this.pnlThongTin.Size = new System.Drawing.Size(723, 506);
            this.pnlThongTin.TabIndex = 36;
            // 
            // labelLoi
            // 
            this.labelLoi.AutoSize = true;
            this.labelLoi.BackColor = System.Drawing.Color.Transparent;
            this.labelLoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoi.ForeColor = System.Drawing.Color.Red;
            this.labelLoi.Location = new System.Drawing.Point(19, 450);
            this.labelLoi.Name = "labelLoi";
            this.labelLoi.Size = new System.Drawing.Size(0, 38);
            this.labelLoi.TabIndex = 31;
            this.labelLoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbcMk
            // 
            this.tbcMk.ForeColor = System.Drawing.Color.White;
            this.tbcMk.Location = new System.Drawing.Point(24, 366);
            this.tbcMk.Margin = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.tbcMk.Name = "tbcMk";
            this.tbcMk.PasswordChar = '\0';
            this.tbcMk.Size = new System.Drawing.Size(483, 48);
            this.tbcMk.TabIndex = 30;
            this.tbcMk.Tag = "Mật khẩu";
            // 
            // tbcEmail
            // 
            this.tbcEmail.ForeColor = System.Drawing.Color.White;
            this.tbcEmail.Location = new System.Drawing.Point(27, 258);
            this.tbcEmail.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tbcEmail.Name = "tbcEmail";
            this.tbcEmail.PasswordChar = '\0';
            this.tbcEmail.Size = new System.Drawing.Size(483, 49);
            this.tbcEmail.TabIndex = 18;
            this.tbcEmail.Tag = "Email";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(19, 23);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(212, 38);
            this.lblUserName.TabIndex = 8;
            this.lblUserName.Text = "Mã nhân viên";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTenTaiKhoan
            // 
            this.lblTenTaiKhoan.AutoSize = true;
            this.lblTenTaiKhoan.BackColor = System.Drawing.Color.Transparent;
            this.lblTenTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenTaiKhoan.Location = new System.Drawing.Point(19, 103);
            this.lblTenTaiKhoan.Name = "lblTenTaiKhoan";
            this.lblTenTaiKhoan.Size = new System.Drawing.Size(214, 38);
            this.lblTenTaiKhoan.TabIndex = 10;
            this.lblTenTaiKhoan.Text = "Tên tài khoản";
            this.lblTenTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbcTenTk
            // 
            this.tbcTenTk.ForeColor = System.Drawing.Color.White;
            this.tbcTenTk.Location = new System.Drawing.Point(27, 151);
            this.tbcTenTk.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tbcTenTk.Name = "tbcTenTk";
            this.tbcTenTk.PasswordChar = '\0';
            this.tbcTenTk.Size = new System.Drawing.Size(483, 49);
            this.tbcTenTk.TabIndex = 11;
            this.tbcTenTk.Tag = "Tên tài khoản";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.BackColor = System.Drawing.Color.Transparent;
            this.lblNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgaySinh.Location = new System.Drawing.Point(19, 210);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(98, 38);
            this.lblNgaySinh.TabIndex = 12;
            this.lblNgaySinh.Text = "Email";
            this.lblNgaySinh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmTaoTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 506);
            this.ControlBox = false;
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlMoveAndTitle);
            this.Controls.Add(this.pnlThongTin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmTaoTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnlBottom.ResumeLayout(false);
            this.pnlMoveAndTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.pnlThongTin.ResumeLayout(false);
            this.pnlThongTin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBottom;
        private Extra.BlackWhiteButton btnGo;
        private Extra.BlackWhiteButton btnLuu;
        private System.Windows.Forms.Panel pnlMoveAndTitle;
        private System.Windows.Forms.Label lblTitle;
        private FontAwesome.Sharp.IconPictureBox btnExit;
        private Custom.TextBox_Custom tbcMk;
        private System.Windows.Forms.Label label5;
        private Custom.TextBox_Custom tbcEmail;
        private Custom.TextBox_Custom tbcTenTk;
        private System.Windows.Forms.Panel pnlThongTin;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblTenTaiKhoan;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label labelLoi;
    }
}