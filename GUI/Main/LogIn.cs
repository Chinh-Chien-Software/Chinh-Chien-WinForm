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
using ChinChin.DAL_DAO;
using ChinChin.UI;
using System.IO;

namespace ChinChin.UI
{
    public partial class LogIn : Form
    {
        SqlConnection conn;
        string connStr = Properties.Settings.Default.ChinhChienConnectionString;
        SqlDataAdapter adapter;
        DataSet dsTaiKhoan = new DataSet();
        string strSqlTaiKhoan = "SELECT * FROM TaiKhoan";
        public static string folderAPPDATA = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        public static string specificFolder = Path.Combine(folderAPPDATA, "ChinhChien");
        static string fileName = "SavedUsername.txt";
        string pathString = System.IO.Path.Combine(specificFolder, fileName);

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
            //this.FormBorderStyle = FormBorderStyle.None;

            this.ActiveControl = tbcUserName;

            // Cho cửa sổ có kích thước vừa đẹp với màn hình làm việc
            this.Size = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
        }

        private void CheckUserPassAndSignIn()
        {
            username = tbcUserName.Text;
            password = tbcPassword.Text;

            string sqlcode = "SELECT * FROM TaiKhoan WHERE TenTaiKhoan = '" + username + "' AND MatKhau = '" + password + "'";
            DataTable TaiKhoan = new DataTable();
            TaiKhoan = DataProvider.ReturnDataTable(sqlcode);

            // Điều kiện Kiểm tra LoaiTaiKhoan
            if (TaiKhoan.Rows.Count == 1)
            {
                if (ckBxRememberSignIn.Checked)
                {
                    // Dẫn tới thứ mục %appdata% => the roaming current user 
                    
                    Directory.CreateDirectory(specificFolder);

                    if (!System.IO.File.Exists(pathString))
                    {
                        using (System.IO.FileStream fs = System.IO.File.Create(pathString))
                        {
                            File.Create(pathString).Close();
                        }
                    }
                    else
                    {
                        File.WriteAllText(Path.Combine(specificFolder, "SavedUsername.txt"), tbcUserName.Text);
                    }
                }
                else
                {
                    if (!System.IO.File.Exists(pathString))
                    {
                        using (System.IO.FileStream fs = System.IO.File.Create(pathString))
                        {
                            File.Create(pathString).Close();
                        }
                    }
                    else
                    {
                        File.WriteAllText(Path.Combine(specificFolder, "SavedUsername.txt"), "");
                    }
                }
                QuanDAO quan = new QuanDAO();
                DataTable dt = quan.searchQuanByTenTaiKhoan(username);

                MainUI MainUI = new MainUI();
                MainUI.TenTaiKhoan = username;
                MainUI.TenQuan = dt.Rows[0]["TenQuan"].ToString();
                MainUI.Show();
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
            // #91 - Đọc file

            // Console.WriteLine(System.IO.File.ReadLines(pathString));
            
            // Kiểm Tra Database
            if (Database.WorkingDatabase.CheckLocalDatabase())
            {
                conn = new SqlConnection(connStr);

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                adapter = new SqlDataAdapter(strSqlTaiKhoan, conn);
                adapter.Fill(dsTaiKhoan, "TAIKHOAN");
                dgvTaiKhoan.DataSource = dsTaiKhoan.Tables[0];
            }
            else
            {
                MessageBox.Show("Không có Database hoặc Dữ liệu bé ơi", "Oh My God", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //string usernameSaved = System.IO.File.ReadAllText(pathString);
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

        private void labelThongBao_Click(object sender, EventArgs e)
        {

        }

        private void ckBxRememberSignIn_CheckedChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(ckBxRememberSignIn.Checked.ToString());
            //string pathString = @"%appdata%\ChinhChien";
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
        private void tbcUserName_Load(object sender, EventArgs e)
        {

        }
    }
}