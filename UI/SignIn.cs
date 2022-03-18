using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Windows.Input;
using System.Data.SqlClient;
using ChinChin.FormsChuQuan;
using ChinChin.FormsQuanLy;
using ChinChin.Forms_NhanVien;
using ChinChin.Extra;
using ChinChin.Database;

namespace ChinChin
{
    public partial class SignIn : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // width of ellipse
           int nHeightEllipse // height of ellipse
        );

        public SignIn()
        {
            InitializeComponent();
            labelThongBao.Text = "";
            this.Size = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void CheckUserPassAndSignIn()
        {

            string username = txtBxUsername.Text;
            string password = txtBxPassword.Text;
            formChuQuan ChuQuan = new formChuQuan();
            QuanLy QuanLy = new QuanLy();
            NhanVienThuNgan NhanVienThuNgan = new NhanVienThuNgan();
            NhanVienPhaChe Barista = new NhanVienPhaChe();

            string sqlcode = "SELECT * FROM TaiKhoan WHERE TenTaiKhoan='" + username + "' and MatKhau='" + password + "'";
            DataTable TaiKhoan = new DataTable();
            TaiKhoan = DataProvider.LoadDatabase(sqlcode);
            // Kiểm tra Mật Khẩu
            //Kiểm tra LoaiTaiKhoan
            if (TaiKhoan.Rows.Count == 1)
            {
                if (TaiKhoan.Rows[0][0].ToString() == "chuquan")
                {
                    ChuQuan.Show();
                    this.Hide();
                }
                else if (TaiKhoan.Rows[0][0].ToString()  == "quanly")
                {
                    QuanLy.Show();
                    this.Hide();
                }
                else if (TaiKhoan.Rows[0][0].ToString() == "thungan")
                {
                    NhanVienThuNgan.Show();
                    this.Hide();
                }
                else if (TaiKhoan.Rows[0][0].ToString() == "phache")
                {
                    Barista.Show();
                    this.Hide();
                }
            }
            else
            {
                labelThongBao.Visible = true;
                labelThongBao.Text = "Không tìm thấy tài khoản hoặc sai mật khẩu";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SignInButton_MouseHover(object sender, EventArgs e)
        {
            //SignInButton.BackgroundColor = Color.Black;
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
                CheckUserPassAndSignIn();
        }

        private void txtBxUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtBxPassword.Focus();
            }
        }

        private void txtBxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckUserPassAndSignIn();
            }
        }

        private void txtBxUsername_Enter(object sender, EventArgs e)
        {
            labelThongBao.Visible = false;
        }

        private void txtBxPassword_Enter(object sender, EventArgs e)
        {
            labelThongBao.Visible = false;
        }
    }
}

        
