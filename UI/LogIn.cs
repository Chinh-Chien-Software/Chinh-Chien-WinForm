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
using ChinChin.UI;

namespace ChinChin
{
    public partial class LogIn : Form
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
        public static string username;
        public static string password;
        public LogIn()
        {
            InitializeComponent();
            labelThongBao.Text = "";
            this.FormBorderStyle = FormBorderStyle.None;

            // Cho cửa sổ có kích thước vừa đẹp với màn hình làm việc
            this.Size = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);

            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void CheckUserPassAndSignIn()
        {
            username = tbcUserName.TB_Text;
            password = tbcPassword.TB_Text;

            /*
            formChuQuan ChuQuan = new formChuQuan();
            QuanLy QuanLy = new QuanLy();
            NhanVienThuNgan NhanVienThuNgan = new NhanVienThuNgan();
            NhanVienPhaChe Barista = new NhanVienPhaChe();
            */

            string sqlcode = "SELECT * FROM TaiKhoan WHERE TenTaiKhoan = '" + username + "' AND MatKhau = '" + password + "'";
            DataTable TaiKhoan = new DataTable();
            TaiKhoan = DataProvider.LoadDatabase(sqlcode);
            
            // Điều kiện Kiểm tra LoaiTaiKhoan
            if (TaiKhoan.Rows.Count == 1)
            {
                MainUI MainUIcq = new MainUI(TaiKhoan.Rows[0][1].ToString(), TaiKhoan.Rows[0][2].ToString());
                MainUIcq.Show();
                this.Hide();
            }
            else
            {
                labelThongBao.Visible = true; // Cho phép hiện thông báo lỗi,kết thúc hiệu lực của txtBxUsername_Enter và txtBxPassword_Enter
                labelThongBao.Text = "Không tìm thấy tài khoản hoặc sai mật khẩu";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Kết thúc phần mềm
            Application.Exit();
        }

        private void SignInButton_MouseHover(object sender, EventArgs e)
        {
            // Tắt việc chuyển cái nút của mình thành màu đen khi rơ chuột lên nút Đăng Nhập
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
                tbcPassword.Focus();
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

        private void SignIn_Load(object sender, EventArgs e)
        {
            // Kiểm Tra Database
            if (Database.WorkingDatabase.CheckLocalDatabase())
            {
                //RegistryKey rk = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server");
                //String[] instances = (String[])rk.GetValue("InstalledInstances");

                // TODO: This line of code loads data into the 'taiKhoanDataSet.TaiKhoan' table. You can move, or remove it, as needed.
                this.taiKhoanTableAdapter1.Fill(this.taiKhoanDataSet.TaiKhoan);
                // TODO: This line of code loads data into the 'quanLyQuanTraSuaDataSetTaiKhoan.TaiKhoan' table. You can move, or remove it, as needed.
                // this.taiKhoanTableAdapter.Fill(this.quanLyQuanTraSuaDataSetTaiKhoan.TaiKhoan);
                // khong chay duoc tren may tinh khac ngoai` Khoi.
            }
            else
            {
                MessageBox.Show("Không có Database hoặc Dữ liệu bé ơi", "Oh My God", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void labelNoAccount_Click(object sender, EventArgs e)
        {
            SignUp SignUp = new SignUp();
            SignUp.Show();
            this.Hide();
        }

        private void labelNoAccount_MouseHover(object sender, EventArgs e)
        {
            lblNoAccount.Font = new Font("Inter", 12, ((FontStyle)((FontStyle.Bold | FontStyle.Underline))));
        }

        private void lblNoAccount_MouseLeave(object sender, EventArgs e)
        {
            lblNoAccount.Font = new Font("Inter", 12, FontStyle.Bold);
        }

        private void panelBackground_Paint(object sender, PaintEventArgs e)
        {

        }

        private void taiKhoanBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void lblSignIn_Click(object sender, EventArgs e)
        {

        }

        private void labelThongBao_Click(object sender, EventArgs e)
        {

        }

        private void ckBxRememberSignIn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panelUsername_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelUserName_Click(object sender, EventArgs e)
        {

        }

        private void panelPassword_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iPBxShowHidePasword_Click(object sender, EventArgs e)
        {

        }

        private void labelPasword_Click(object sender, EventArgs e)
        {

        }

        private void tbcUserName_Load(object sender, EventArgs e)
        {

        }

        private void tbcPassword_Load(object sender, EventArgs e)
        {

        }
    }
}