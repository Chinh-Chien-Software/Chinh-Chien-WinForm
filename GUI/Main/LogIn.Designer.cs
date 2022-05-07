
namespace ChinChin.UI
{
    partial class LogIn
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.panelBackground = new System.Windows.Forms.Panel();
            this.dgvTaiKhoan = new System.Windows.Forms.DataGridView();
            this.lblNoAccount = new System.Windows.Forms.Label();
            this.SignInButton = new ChinChin.Extra.BlackWhiteButton();
            this.labelThongBao = new System.Windows.Forms.Label();
            this.btnExit = new FontAwesome.Sharp.IconPictureBox();
            this.lblSignIn = new System.Windows.Forms.Label();
            this.ckBxRememberSignIn = new System.Windows.Forms.CheckBox();
            this.panelUsername = new System.Windows.Forms.Panel();
            this.tbcUserName = new ChinChin.Custom.TextBox_Custom();
            this.labelUserName = new System.Windows.Forms.Label();
            this.panelPassword = new System.Windows.Forms.Panel();
            this.iPBxShowHidePasword = new FontAwesome.Sharp.IconPictureBox();
            this.labelPasword = new System.Windows.Forms.Label();
            this.tbcPassword = new ChinChin.Custom.TextBox_Custom();
            this.taiKhoanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taiKhoanDataSet = new ChinChin.DataSets.TaiKhoanDataSet();
            this.quanLyQuanTraSuaDataSetTaiKhoan = new ChinChin.DataSets.QuanLyQuanTraSuaDataSetTaiKhoan();
            this.taiKhoanTableAdapter = new ChinChin.DataSets.QuanLyQuanTraSuaDataSetTaiKhoanTableAdapters.TaiKhoanTableAdapter();
            this.taiKhoanTableAdapter1 = new ChinChin.DataSets.TaiKhoanDataSetTableAdapters.TaiKhoanTableAdapter();
            this.panelBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.panelUsername.SuspendLayout();
            this.panelPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iPBxShowHidePasword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyQuanTraSuaDataSetTaiKhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBackground
            // 
            this.panelBackground.Controls.Add(this.dgvTaiKhoan);
            this.panelBackground.Controls.Add(this.lblNoAccount);
            this.panelBackground.Controls.Add(this.SignInButton);
            this.panelBackground.Controls.Add(this.labelThongBao);
            this.panelBackground.Controls.Add(this.btnExit);
            this.panelBackground.Controls.Add(this.lblSignIn);
            this.panelBackground.Controls.Add(this.ckBxRememberSignIn);
            this.panelBackground.Controls.Add(this.panelUsername);
            this.panelBackground.Controls.Add(this.panelPassword);
            this.panelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackground.Location = new System.Drawing.Point(0, 0);
            this.panelBackground.Margin = new System.Windows.Forms.Padding(2);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Size = new System.Drawing.Size(1134, 611);
            this.panelBackground.TabIndex = 10;
            this.panelBackground.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBackground_Paint);
            // 
            // dgvTaiKhoan
            // 
            this.dgvTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaiKhoan.Location = new System.Drawing.Point(35, 380);
            this.dgvTaiKhoan.Name = "dgvTaiKhoan";
            this.dgvTaiKhoan.Size = new System.Drawing.Size(349, 179);
            this.dgvTaiKhoan.TabIndex = 14;
            // 
            // lblNoAccount
            // 
            this.lblNoAccount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNoAccount.AutoSize = true;
            this.lblNoAccount.BackColor = System.Drawing.Color.Transparent;
            this.lblNoAccount.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoAccount.Location = new System.Drawing.Point(469, 572);
            this.lblNoAccount.Name = "lblNoAccount";
            this.lblNoAccount.Size = new System.Drawing.Size(189, 19);
            this.lblNoAccount.TabIndex = 13;
            this.lblNoAccount.Text = "Bạn chưa có tài khoản?";
            this.lblNoAccount.Click += new System.EventHandler(this.labelNoAccount_Click);
            this.lblNoAccount.MouseLeave += new System.EventHandler(this.lblNoAccount_MouseLeave);
            this.lblNoAccount.MouseHover += new System.EventHandler(this.labelNoAccount_MouseHover);
            // 
            // SignInButton
            // 
            this.SignInButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SignInButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(108)))), ((int)(((byte)(247)))));
            this.SignInButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(108)))), ((int)(((byte)(247)))));
            this.SignInButton.BorderColor = System.Drawing.Color.Black;
            this.SignInButton.BorderRadius = 0;
            this.SignInButton.BorderSize = 0;
            this.SignInButton.FlatAppearance.BorderSize = 0;
            this.SignInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignInButton.Font = new System.Drawing.Font("Inter", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInButton.ForeColor = System.Drawing.Color.White;
            this.SignInButton.Location = new System.Drawing.Point(430, 437);
            this.SignInButton.Margin = new System.Windows.Forms.Padding(2);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(271, 122);
            this.SignInButton.TabIndex = 4;
            this.SignInButton.Text = "ĐĂNG NHẬP";
            this.SignInButton.TextColor = System.Drawing.Color.White;
            this.SignInButton.UseVisualStyleBackColor = false;
            this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click);
            this.SignInButton.MouseHover += new System.EventHandler(this.SignInButton_MouseHover);
            // 
            // labelThongBao
            // 
            this.labelThongBao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelThongBao.AutoSize = true;
            this.labelThongBao.BackColor = System.Drawing.Color.Transparent;
            this.labelThongBao.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelThongBao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelThongBao.Location = new System.Drawing.Point(411, 387);
            this.labelThongBao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelThongBao.Name = "labelThongBao";
            this.labelThongBao.Size = new System.Drawing.Size(322, 19);
            this.labelThongBao.TabIndex = 9;
            this.labelThongBao.Text = "hiện thông báo về mật khẩu và tài khoản";
            this.labelThongBao.Click += new System.EventHandler(this.labelThongBao_Click);
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
            this.btnExit.Location = new System.Drawing.Point(1079, 9);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(46, 48);
            this.btnExit.TabIndex = 8;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblSignIn
            // 
            this.lblSignIn.BackColor = System.Drawing.Color.Transparent;
            this.lblSignIn.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSignIn.Font = new System.Drawing.Font("Inter", 40.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignIn.Location = new System.Drawing.Point(0, 0);
            this.lblSignIn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSignIn.Name = "lblSignIn";
            this.lblSignIn.Size = new System.Drawing.Size(1134, 133);
            this.lblSignIn.TabIndex = 3;
            this.lblSignIn.Text = "Đăng nhập";
            this.lblSignIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ckBxRememberSignIn
            // 
            this.ckBxRememberSignIn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ckBxRememberSignIn.AutoSize = true;
            this.ckBxRememberSignIn.BackColor = System.Drawing.Color.Transparent;
            this.ckBxRememberSignIn.Font = new System.Drawing.Font("Inter", 14F);
            this.ckBxRememberSignIn.Location = new System.Drawing.Point(473, 337);
            this.ckBxRememberSignIn.Margin = new System.Windows.Forms.Padding(2);
            this.ckBxRememberSignIn.Name = "ckBxRememberSignIn";
            this.ckBxRememberSignIn.Size = new System.Drawing.Size(192, 27);
            this.ckBxRememberSignIn.TabIndex = 3;
            this.ckBxRememberSignIn.Text = "Ghi nhớ đăng nhập";
            this.ckBxRememberSignIn.UseVisualStyleBackColor = false;
            this.ckBxRememberSignIn.CheckedChanged += new System.EventHandler(this.ckBxRememberSignIn_CheckedChanged);
            // 
            // panelUsername
            // 
            this.panelUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelUsername.BackColor = System.Drawing.Color.Transparent;
            this.panelUsername.Controls.Add(this.tbcUserName);
            this.panelUsername.Controls.Add(this.labelUserName);
            this.panelUsername.Location = new System.Drawing.Point(2, 176);
            this.panelUsername.Name = "panelUsername";
            this.panelUsername.Size = new System.Drawing.Size(1132, 74);
            this.panelUsername.TabIndex = 11;
            // 
            // tbcUserName
            // 
            this.tbcUserName.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbcUserName.ForeColor = System.Drawing.Color.White;
            this.tbcUserName.Location = new System.Drawing.Point(428, 38);
            this.tbcUserName.Name = "tbcUserName";
            this.tbcUserName.PasswordChar = '\0';
            this.tbcUserName.Size = new System.Drawing.Size(271, 36);
            this.tbcUserName.TabIndex = 1;
            this.tbcUserName.Load += new System.EventHandler(this.tbcUserName_Load);
            // 
            // labelUserName
            // 
            this.labelUserName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelUserName.AutoSize = true;
            this.labelUserName.BackColor = System.Drawing.Color.Transparent;
            this.labelUserName.Font = new System.Drawing.Font("Inter", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.Location = new System.Drawing.Point(422, 2);
            this.labelUserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(133, 33);
            this.labelUserName.TabIndex = 6;
            this.labelUserName.Text = "Tài khoản";
            this.labelUserName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelPassword
            // 
            this.panelPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPassword.BackColor = System.Drawing.Color.Transparent;
            this.panelPassword.Controls.Add(this.iPBxShowHidePasword);
            this.panelPassword.Controls.Add(this.labelPasword);
            this.panelPassword.Controls.Add(this.tbcPassword);
            this.panelPassword.Location = new System.Drawing.Point(0, 253);
            this.panelPassword.Name = "panelPassword";
            this.panelPassword.Size = new System.Drawing.Size(1134, 79);
            this.panelPassword.TabIndex = 12;
            // 
            // iPBxShowHidePasword
            // 
            this.iPBxShowHidePasword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iPBxShowHidePasword.BackColor = System.Drawing.Color.White;
            this.iPBxShowHidePasword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iPBxShowHidePasword.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.iPBxShowHidePasword.IconColor = System.Drawing.SystemColors.ControlText;
            this.iPBxShowHidePasword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iPBxShowHidePasword.IconSize = 25;
            this.iPBxShowHidePasword.Location = new System.Drawing.Point(672, 44);
            this.iPBxShowHidePasword.Margin = new System.Windows.Forms.Padding(2);
            this.iPBxShowHidePasword.Name = "iPBxShowHidePasword";
            this.iPBxShowHidePasword.Size = new System.Drawing.Size(29, 25);
            this.iPBxShowHidePasword.TabIndex = 16;
            this.iPBxShowHidePasword.TabStop = false;
            this.iPBxShowHidePasword.Click += new System.EventHandler(this.iPBxShowHidePasword_Click);
            // 
            // labelPasword
            // 
            this.labelPasword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelPasword.AutoSize = true;
            this.labelPasword.BackColor = System.Drawing.Color.Transparent;
            this.labelPasword.Font = new System.Drawing.Font("Inter", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPasword.Location = new System.Drawing.Point(424, -1);
            this.labelPasword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPasword.Name = "labelPasword";
            this.labelPasword.Size = new System.Drawing.Size(128, 33);
            this.labelPasword.TabIndex = 7;
            this.labelPasword.Text = "Mật khẩu";
            // 
            // tbcPassword
            // 
            this.tbcPassword.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbcPassword.ForeColor = System.Drawing.Color.White;
            this.tbcPassword.Location = new System.Drawing.Point(430, 35);
            this.tbcPassword.Name = "tbcPassword";
            this.tbcPassword.PasswordChar = '*';
            this.tbcPassword.Size = new System.Drawing.Size(271, 36);
            this.tbcPassword.TabIndex = 2;
            // 
            // taiKhoanBindingSource
            // 
            this.taiKhoanBindingSource.DataMember = "TaiKhoan";
            this.taiKhoanBindingSource.DataSource = this.taiKhoanDataSet;
            this.taiKhoanBindingSource.CurrentChanged += new System.EventHandler(this.taiKhoanBindingSource_CurrentChanged);
            // 
            // taiKhoanDataSet
            // 
            this.taiKhoanDataSet.DataSetName = "TaiKhoanDataSet";
            this.taiKhoanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // quanLyQuanTraSuaDataSetTaiKhoan
            // 
            this.quanLyQuanTraSuaDataSetTaiKhoan.DataSetName = "QuanLyQuanTraSuaDataSetTaiKhoan";
            this.quanLyQuanTraSuaDataSetTaiKhoan.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // taiKhoanTableAdapter
            // 
            this.taiKhoanTableAdapter.ClearBeforeFill = true;
            // 
            // taiKhoanTableAdapter1
            // 
            this.taiKhoanTableAdapter1.ClearBeforeFill = true;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1134, 611);
            this.ControlBox = false;
            this.Controls.Add(this.panelBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.SignIn_Load);
            this.panelBackground.ResumeLayout(false);
            this.panelBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.panelUsername.ResumeLayout(false);
            this.panelUsername.PerformLayout();
            this.panelPassword.ResumeLayout(false);
            this.panelPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iPBxShowHidePasword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyQuanTraSuaDataSetTaiKhoan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblSignIn;
        private System.Windows.Forms.CheckBox ckBxRememberSignIn;
        private System.Windows.Forms.Label labelPasword;
        private FontAwesome.Sharp.IconPictureBox btnExit;
        private System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.Label labelThongBao;
        private Extra.BlackWhiteButton SignInButton;
        private System.Windows.Forms.Panel panelUsername;
        private System.Windows.Forms.Panel panelPassword;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label lblNoAccount;
        private System.Windows.Forms.DataGridView dgvTaiKhoan;
        private ChinChin.DataSets.QuanLyQuanTraSuaDataSetTaiKhoan quanLyQuanTraSuaDataSetTaiKhoan;
        private ChinChin.DataSets.QuanLyQuanTraSuaDataSetTaiKhoanTableAdapters.TaiKhoanTableAdapter taiKhoanTableAdapter;
        private ChinChin.DataSets.TaiKhoanDataSet taiKhoanDataSet;
        private System.Windows.Forms.BindingSource taiKhoanBindingSource;
        private ChinChin.DataSets.TaiKhoanDataSetTableAdapters.TaiKhoanTableAdapter taiKhoanTableAdapter1;
        private FontAwesome.Sharp.IconPictureBox iPBxShowHidePasword;
        private Custom.TextBox_Custom tbcUserName;
        private Custom.TextBox_Custom tbcPassword;
    }
}

