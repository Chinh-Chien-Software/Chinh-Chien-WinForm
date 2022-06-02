namespace ChinhChien.UI
{
    partial class ThongTinTaiKhoan
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
            this.pbAvatarNhanVien = new System.Windows.Forms.PictureBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Custom1 = new ChinhChien.Custom.TextBox_Custom();
            this.tbcUserName = new ChinhChien.Custom.TextBox_Custom();
            this.pnlThongTin = new System.Windows.Forms.Panel();
            this.SignInButton = new ChinhChien.Extra.BlackWhiteButton();
            this.blackWhiteButton1 = new ChinhChien.Extra.BlackWhiteButton();
            this.textBox_Custom2 = new ChinhChien.Custom.TextBox_Custom();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatarNhanVien)).BeginInit();
            this.pnlThongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbAvatarNhanVien
            // 
            this.pbAvatarNhanVien.Location = new System.Drawing.Point(13, 10);
            this.pbAvatarNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.pbAvatarNhanVien.Name = "pbAvatarNhanVien";
            this.pbAvatarNhanVien.Size = new System.Drawing.Size(210, 210);
            this.pbAvatarNhanVien.TabIndex = 0;
            this.pbAvatarNhanVien.TabStop = false;
            // 
            // lblUserName
            // 
            this.lblUserName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName.Font = new System.Drawing.Font("Inter", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(11, 22);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(181, 33);
            this.lblUserName.TabIndex = 8;
            this.lblUserName.Text = "Tên tài khoản";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Inter", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 33);
            this.label2.TabIndex = 10;
            this.label2.Text = "Họ và tên";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.BackColor = System.Drawing.Color.Transparent;
            this.lblNgaySinh.Font = new System.Drawing.Font("Inter", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgaySinh.Location = new System.Drawing.Point(14, 193);
            this.lblNgaySinh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(137, 33);
            this.lblNgaySinh.TabIndex = 12;
            this.lblNgaySinh.Text = "Ngày sinh";
            this.lblNgaySinh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(20, 229);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 24);
            this.dateTimePicker1.TabIndex = 13;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Inter", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 267);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 33);
            this.label1.TabIndex = 14;
            this.label1.Text = "Giới tính";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.comboBox1.Location = new System.Drawing.Point(17, 304);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(96, 26);
            this.comboBox1.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Inter", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 350);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 33);
            this.label3.TabIndex = 16;
            this.label3.Text = "Địa chỉ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Inter", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 438);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 33);
            this.label4.TabIndex = 17;
            this.label4.Text = "Số điện thoại";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_Custom1
            // 
            this.textBox_Custom1.ForeColor = System.Drawing.Color.White;
            this.textBox_Custom1.Location = new System.Drawing.Point(16, 138);
            this.textBox_Custom1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox_Custom1.Name = "textBox_Custom1";
            this.textBox_Custom1.PasswordChar = '\0';
            this.textBox_Custom1.Size = new System.Drawing.Size(362, 40);
            this.textBox_Custom1.TabIndex = 11;
            // 
            // tbcUserName
            // 
            this.tbcUserName.BackColor = System.Drawing.Color.White;
            this.tbcUserName.ForeColor = System.Drawing.Color.White;
            this.tbcUserName.Location = new System.Drawing.Point(16, 55);
            this.tbcUserName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbcUserName.Name = "tbcUserName";
            this.tbcUserName.PasswordChar = '\0';
            this.tbcUserName.Size = new System.Drawing.Size(362, 40);
            this.tbcUserName.TabIndex = 9;
            // 
            // pnlThongTin
            // 
            this.pnlThongTin.Controls.Add(this.textBox_Custom2);
            this.pnlThongTin.Controls.Add(this.label4);
            this.pnlThongTin.Controls.Add(this.lblUserName);
            this.pnlThongTin.Controls.Add(this.label3);
            this.pnlThongTin.Controls.Add(this.tbcUserName);
            this.pnlThongTin.Controls.Add(this.comboBox1);
            this.pnlThongTin.Controls.Add(this.label2);
            this.pnlThongTin.Controls.Add(this.label1);
            this.pnlThongTin.Controls.Add(this.textBox_Custom1);
            this.pnlThongTin.Controls.Add(this.dateTimePicker1);
            this.pnlThongTin.Controls.Add(this.lblNgaySinh);
            this.pnlThongTin.Location = new System.Drawing.Point(242, 12);
            this.pnlThongTin.Name = "pnlThongTin";
            this.pnlThongTin.Size = new System.Drawing.Size(385, 553);
            this.pnlThongTin.TabIndex = 18;
            // 
            // SignInButton
            // 
            this.SignInButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SignInButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(108)))), ((int)(((byte)(247)))));
            this.SignInButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(108)))), ((int)(((byte)(247)))));
            this.SignInButton.BorderColor = System.Drawing.Color.Black;
            this.SignInButton.BorderRadius = 0;
            this.SignInButton.BorderSize = 0;
            this.SignInButton.FlatAppearance.BorderSize = 0;
            this.SignInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignInButton.Font = new System.Drawing.Font("Inter", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInButton.ForeColor = System.Drawing.Color.White;
            this.SignInButton.Location = new System.Drawing.Point(475, 638);
            this.SignInButton.Margin = new System.Windows.Forms.Padding(2);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(258, 50);
            this.SignInButton.TabIndex = 19;
            this.SignInButton.Text = "Cập Nhật Thông Tin";
            this.SignInButton.TextColor = System.Drawing.Color.White;
            this.SignInButton.UseVisualStyleBackColor = false;
            // 
            // blackWhiteButton1
            // 
            this.blackWhiteButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.blackWhiteButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(108)))), ((int)(((byte)(247)))));
            this.blackWhiteButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(108)))), ((int)(((byte)(247)))));
            this.blackWhiteButton1.BorderColor = System.Drawing.Color.Black;
            this.blackWhiteButton1.BorderRadius = 0;
            this.blackWhiteButton1.BorderSize = 0;
            this.blackWhiteButton1.FlatAppearance.BorderSize = 0;
            this.blackWhiteButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.blackWhiteButton1.Font = new System.Drawing.Font("Inter", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blackWhiteButton1.ForeColor = System.Drawing.Color.White;
            this.blackWhiteButton1.Location = new System.Drawing.Point(475, 692);
            this.blackWhiteButton1.Margin = new System.Windows.Forms.Padding(2);
            this.blackWhiteButton1.Name = "blackWhiteButton1";
            this.blackWhiteButton1.Size = new System.Drawing.Size(258, 50);
            this.blackWhiteButton1.TabIndex = 20;
            this.blackWhiteButton1.Text = "Đổi mật khẩu";
            this.blackWhiteButton1.TextColor = System.Drawing.Color.White;
            this.blackWhiteButton1.UseVisualStyleBackColor = false;
            // 
            // textBox_Custom2
            // 
            this.textBox_Custom2.ForeColor = System.Drawing.Color.White;
            this.textBox_Custom2.Location = new System.Drawing.Point(16, 385);
            this.textBox_Custom2.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.textBox_Custom2.Name = "textBox_Custom2";
            this.textBox_Custom2.PasswordChar = '\0';
            this.textBox_Custom2.Size = new System.Drawing.Size(362, 39);
            this.textBox_Custom2.TabIndex = 18;
            // 
            // ThongTinTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(744, 753);
            this.Controls.Add(this.blackWhiteButton1);
            this.Controls.Add(this.SignInButton);
            this.Controls.Add(this.pbAvatarNhanVien);
            this.Controls.Add(this.pnlThongTin);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ThongTinTaiKhoan";
            this.Text = "Thông Tin Tài Khoản";
            this.Load += new System.EventHandler(this.ThongTinTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatarNhanVien)).EndInit();
            this.pnlThongTin.ResumeLayout(false);
            this.pnlThongTin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbAvatarNhanVien;
        private Custom.TextBox_Custom tbcUserName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label label2;
        private Custom.TextBox_Custom textBox_Custom1;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlThongTin;
        private Extra.BlackWhiteButton SignInButton;
        private Extra.BlackWhiteButton blackWhiteButton1;
        private Custom.TextBox_Custom textBox_Custom2;
    }
}