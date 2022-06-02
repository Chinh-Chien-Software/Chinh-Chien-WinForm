namespace ChinhChien.GUI.Main
{
    partial class TaoQuan
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
            this.tbcMaQuan = new ChinhChien.Custom.TextBox_Custom();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbcTenQuan = new ChinhChien.Custom.TextBox_Custom();
            this.iPBCheckMaQuan = new FontAwesome.Sharp.IconPictureBox();
            this.btnTao = new ChinhChien.Extra.BlackWhiteButton();
            ((System.ComponentModel.ISupportInitialize)(this.iPBCheckMaQuan)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcMaQuan
            // 
            this.tbcMaQuan.ForeColor = System.Drawing.Color.White;
            this.tbcMaQuan.Location = new System.Drawing.Point(12, 43);
            this.tbcMaQuan.Name = "tbcMaQuan";
            this.tbcMaQuan.PasswordChar = '\0';
            this.tbcMaQuan.Size = new System.Drawing.Size(271, 36);
            this.tbcMaQuan.TabIndex = 10;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Inter", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(11, 9);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(122, 33);
            this.lblUsername.TabIndex = 9;
            this.lblUsername.Text = "Mã quán";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Inter", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(11, 106);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(130, 33);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "Tên quán";
            this.lblEmail.Click += new System.EventHandler(this.lblEmail_Click);
            // 
            // tbcTenQuan
            // 
            this.tbcTenQuan.ForeColor = System.Drawing.Color.White;
            this.tbcTenQuan.Location = new System.Drawing.Point(12, 142);
            this.tbcTenQuan.Name = "tbcTenQuan";
            this.tbcTenQuan.PasswordChar = '\0';
            this.tbcTenQuan.Size = new System.Drawing.Size(271, 36);
            this.tbcTenQuan.TabIndex = 12;
            // 
            // iPBCheckMaQuan
            // 
            this.iPBCheckMaQuan.BackColor = System.Drawing.Color.White;
            this.iPBCheckMaQuan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iPBCheckMaQuan.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.iPBCheckMaQuan.IconColor = System.Drawing.SystemColors.ControlText;
            this.iPBCheckMaQuan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iPBCheckMaQuan.IconSize = 25;
            this.iPBCheckMaQuan.Location = new System.Drawing.Point(252, 51);
            this.iPBCheckMaQuan.Margin = new System.Windows.Forms.Padding(2);
            this.iPBCheckMaQuan.Name = "iPBCheckMaQuan";
            this.iPBCheckMaQuan.Size = new System.Drawing.Size(29, 25);
            this.iPBCheckMaQuan.TabIndex = 18;
            this.iPBCheckMaQuan.TabStop = false;
            this.iPBCheckMaQuan.Visible = false;
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
            this.btnTao.Location = new System.Drawing.Point(148, 195);
            this.btnTao.Margin = new System.Windows.Forms.Padding(2);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(136, 50);
            this.btnTao.TabIndex = 32;
            this.btnTao.Text = "Tạo";
            this.btnTao.TextColor = System.Drawing.Color.White;
            this.btnTao.UseVisualStyleBackColor = false;
            this.btnTao.Click += new System.EventHandler(this.btnTao_Click);
            // 
            // TaoQuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 256);
            this.Controls.Add(this.btnTao);
            this.Controls.Add(this.iPBCheckMaQuan);
            this.Controls.Add(this.tbcMaQuan);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.tbcTenQuan);
            this.Name = "TaoQuan";
            this.Text = "TaoQuan";
            ((System.ComponentModel.ISupportInitialize)(this.iPBCheckMaQuan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Custom.TextBox_Custom tbcMaQuan;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblEmail;
        private Custom.TextBox_Custom tbcTenQuan;
        private FontAwesome.Sharp.IconPictureBox iPBCheckMaQuan;
        private Extra.BlackWhiteButton btnTao;
    }
}