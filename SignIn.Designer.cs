
namespace ChinChin
{
    partial class SignIn
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
            this.txtBxUsername = new System.Windows.Forms.TextBox();
            this.txtBxPassword = new System.Windows.Forms.TextBox();
            this.lblSignIn = new System.Windows.Forms.Label();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.ckBxRememberSignIn = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtBxUsername
            // 
            this.txtBxUsername.Location = new System.Drawing.Point(72, 165);
            this.txtBxUsername.Name = "txtBxUsername";
            this.txtBxUsername.Size = new System.Drawing.Size(237, 22);
            this.txtBxUsername.TabIndex = 1;
            // 
            // txtBxPassword
            // 
            this.txtBxPassword.Location = new System.Drawing.Point(72, 209);
            this.txtBxPassword.Name = "txtBxPassword";
            this.txtBxPassword.Size = new System.Drawing.Size(237, 22);
            this.txtBxPassword.TabIndex = 2;
            this.txtBxPassword.Tag = "";
            // 
            // lblSignIn
            // 
            this.lblSignIn.AutoSize = true;
            this.lblSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignIn.Location = new System.Drawing.Point(-8, 23);
            this.lblSignIn.Name = "lblSignIn";
            this.lblSignIn.Size = new System.Drawing.Size(375, 78);
            this.lblSignIn.TabIndex = 3;
            this.lblSignIn.Text = "Đăng nhập";
            this.lblSignIn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSignIn
            // 
            this.btnSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.Location = new System.Drawing.Point(72, 434);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(235, 94);
            this.btnSignIn.TabIndex = 4;
            this.btnSignIn.Text = "Đăng Nhập";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // ckBxRememberSignIn
            // 
            this.ckBxRememberSignIn.AutoSize = true;
            this.ckBxRememberSignIn.Location = new System.Drawing.Point(73, 262);
            this.ckBxRememberSignIn.Name = "ckBxRememberSignIn";
            this.ckBxRememberSignIn.Size = new System.Drawing.Size(152, 21);
            this.ckBxRememberSignIn.TabIndex = 5;
            this.ckBxRememberSignIn.Text = "Ghi nhớ đăng nhập";
            this.ckBxRememberSignIn.UseVisualStyleBackColor = true;
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(379, 567);
            this.Controls.Add(this.ckBxRememberSignIn);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.lblSignIn);
            this.Controls.Add(this.txtBxPassword);
            this.Controls.Add(this.txtBxUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SignIn";
            this.Text = "Đăng Nhập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBxUsername;
        private System.Windows.Forms.TextBox txtBxPassword;
        private System.Windows.Forms.Label lblSignIn;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.CheckBox ckBxRememberSignIn;
    }
}

