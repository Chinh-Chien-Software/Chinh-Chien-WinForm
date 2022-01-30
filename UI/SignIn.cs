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
using ChinChin.FormsChuQuan;
using ChinChin.FormsQuanLy;
using ChinChin.Forms_NhanVien;
using ChinChin.Extra;
using System.Windows.Input;
using System.Data.SqlClient;

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
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            //this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }
        // Database
        string chuoiketnoi = @"Data Source=DESKTOP-AN8O8G6\TQK;Initial Catalog=QuanLyQuanTraSua;Integrated Security=True";
        string sqlcode;
        SqlConnection ketnoi;
        SqlCommand thuchien;
        SqlDataReader docdulieu;

        private void CheckUserPassAndSignIn()
        {
            ketnoi = new SqlConnection(chuoiketnoi);

            string username = txtBxUsername.Text;
            string password = txtBxPassword.Text;
            formChuQuan ChuQuan = new formChuQuan();
            QuanLy QuanLy = new QuanLy();
            NhanVienThuNgan NhanVienThuNgan = new NhanVienThuNgan();
            NhanVienPhaChe Barista = new NhanVienPhaChe();

            sqlcode = "SELECT * FROM TaiKhoan WHERE TenTaiKhoan='" + username + "' and MatKhau='" + password + "'";

            // Kiểm tra Mật Khẩu
            ketnoi.Open();
            SqlDataAdapter sda = new SqlDataAdapter(sqlcode, ketnoi);
            DataTable dttb = new DataTable();
            sda.Fill(dttb);
            ketnoi.Close();

            //Kiểm tra LoaiTaiKhoan
            ketnoi.Open();
            thuchien = new SqlCommand(sqlcode, ketnoi);
            docdulieu = thuchien.ExecuteReader();
            docdulieu.Read();

            if (dttb.Rows.Count == 1)
            {
                if (docdulieu[2].ToString() == "chuquan")
                {
                    ChuQuan.Show();
                    this.Hide();
                }
                else if (docdulieu[2].ToString() == "quanly")
                {
                    QuanLy.Show();
                    this.Hide();
                }
                else if (docdulieu[2].ToString() == "thungan")
                {
                    NhanVienThuNgan.Show();
                    this.Hide();
                }
                else if (docdulieu[2].ToString() == "phache")
                {
                    Barista.Show();
                    this.Hide();
                }
            }
            else
            {
                labelThongBao.Text = "Không tìm thấy tài khoản hoặc sai mật khẩu";
            }
            ketnoi.Close();
        }

        private void labelUserName_Click(object sender, EventArgs e)
        {

        }

        private void SignIn_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SignInButton_MouseHover(object sender, EventArgs e)
        {
            SignInButton.BackgroundColor = Color.Black;
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
                CheckUserPassAndSignIn();
        }

        private void txtBxUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckUserPassAndSignIn();
            }
        }

        private void txtBxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckUserPassAndSignIn();
            }
        }

        private void txtBxUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

        
