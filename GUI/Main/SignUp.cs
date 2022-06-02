using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using ChinhChien.Database;
using ChinhChien.UI;
using ChinhChien.BUS;
using ChinhChien.Classes;

namespace ChinhChien.UI
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblNoAccount_Click(object sender, EventArgs e)
        {
            frmLogIn LogIn = new frmLogIn();
            LogIn.Show();
            this.Hide();
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            if (tbcPassword.Text != tbcRewritePassword.Text)
            {
                lblThongBao.Visible = true;
                lblThongBao.Text = "Mật khẩu không khớp";
            }
            else if (WorkingDatabase.CheckUsername(tbcUsername.Text))
            {
                WorkingDatabase.CreateAccount(tbcUsername.Text, tbcPassword.Text, tbcEmail.Text, 1);
                TaiKhoanBUS taiKhoanBUS = new TaiKhoanBUS();


                string TenTaiKhoan = tbcUsername.Text;
                string MatKhau = tbcPassword.Text;
                string Email = tbcEmail.Text;
                int UIMode = 1;

                taiKhoanBUS.ThemTaiKhoanBUS(TenTaiKhoan, MatKhau, UIMode, Email);
                TaiKhoanVO taiKhoanOBJ = new TaiKhoanVO();

                taiKhoanOBJ.TenTaiKhoan = tbcUsername.Text;
                taiKhoanOBJ.MatKhau = tbcPassword.Text;
                taiKhoanOBJ.Email = tbcEmail.Text;
                taiKhoanOBJ.UIMode = 1;

                taiKhoanBUS.ThemTaiKhoanBUS(taiKhoanOBJ);
                ChinhChien.GUI.formThem.ThemCapnhatQuan taoQuan = new ChinhChien.GUI.formThem.ThemCapnhatQuan();
                taoQuan.Show();
                this.Hide();
            }
            else
            {
                lblThongBao.Visible = true;
                lblThongBao.Text = "Tên người dùng đã sử dụng";
            }
        }

        private void iPBxShowHidePasword_Click(object sender, EventArgs e)
        {
            if (tbcPassword.PasswordChar == '\0')
            {
                tbcPassword.PasswordChar = '*';
                iPBxShowHidePasword.IconChar = IconChar.Eye;
            }
            else
            {
                tbcPassword.PasswordChar = '\0';
                iPBxShowHidePasword.IconChar = IconChar.EyeSlash;
            }
        }

        private void iPBxShowHideRewritePasword_Click(object sender, EventArgs e)
        {
            if (tbcRewritePassword.PasswordChar == '\0')
            {
                tbcRewritePassword.PasswordChar = '*';
                iPBxShowHideRewritePasword.IconChar = IconChar.Eye;
            }
            else
            {
                tbcRewritePassword.PasswordChar = '\0';
                iPBxShowHideRewritePasword.IconChar = IconChar.EyeSlash;
            }
        }

        private void tbcUsername_TextChanged(object sender, EventArgs e)
        {
            bool KetQua = WorkingDatabase.CheckUsername(tbcUsername.Text);
            if (KetQua)
            {
                iPBCheckUsername.Visible = true;
                iPBCheckUsername.IconChar = IconChar.Check;
                iPBCheckUsername.IconColor = Color.FromArgb(80, 108, 247);
            }
            else
            {
                iPBCheckUsername.IconChar = IconChar.Times;
                iPBCheckUsername.IconColor = Color.Red;
            }
        }

        private void lblYesAccount_MouseHover(object sender, EventArgs e)
        {
            lblYesAccount.Font = new Font("Cascadia Code", 12, ((FontStyle)((FontStyle.Bold | FontStyle.Underline))));
        }

        private void lblYesAccount_MouseLeave(object sender, EventArgs e)
        {
            lblYesAccount.Font = new Font("Cascadia Code", 12, FontStyle.Bold);
        }
    }
}
