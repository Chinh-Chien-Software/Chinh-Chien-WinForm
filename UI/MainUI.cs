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
using System.Runtime.InteropServices;

namespace ChinChin.UI
{
    public partial class MainUI : Form
    {
        public MainUI()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }
        string TenTaiKhoan;
        string LoaiTaiKhoan;
        public MainUI(string TenTaiKhoan, string LoaiTaiKhoan) : this()
        {
            // Viết hàm khởi tạo này để mang theo dữ liệu khi chạy Form MainUI
            this.LoaiTaiKhoan = LoaiTaiKhoan;
            this.TenTaiKhoan = TenTaiKhoan;
        }
        private void MainUI_Load(object sender, EventArgs e)
        {
            /*
            if (WindowState == FormWindowState.Normal)
            {
                btnMaximize.IconChar = IconChar.WindowMaximize;
            }
            else
            {
                btnMaximize.IconChar = IconChar.WindowMinimize;
            }*/
            if (LoaiTaiKhoan == "chuquan")
            {
                lblHomeButton_Role.Text = "Chủ Quán";
                ibtn1.Text = "THỐNG KÊ"; ibtn1.IconChar = IconChar.Dashcube;
                ibtn2.Text = "KHO HÀNG"; ibtn2.IconChar = IconChar.Boxes;
                ibtn3.Text = "CHẤM CÔNG"; ibtn3.IconChar = IconChar.MoneyCheckAlt;
                ibtn4.Text = "THỰC ĐƠN"; ibtn4.IconChar = IconChar.MugHot;
            }
            else if (LoaiTaiKhoan == "quanly")
            {
                lblHomeButton_Role.Text = "Quản Lý";
                ibtn1.Text = "THỐNG KÊ"; ibtn1.IconChar = IconChar.Dashcube;
                ibtn2.Text = "KHO HÀNG"; ibtn2.IconChar = IconChar.Boxes;
                ibtn3.Text = "LỊCH LÀM"; ibtn3.IconChar = IconChar.Calendar;
                ibtn4.Visible = false;
            }
            else if (LoaiTaiKhoan == "thungan")
            {
                lblHomeButton_Role.Text = "Thu Ngân";
                ibtn1.Text = "NHẬN ĐƠN"; ibtn1.IconChar = IconChar.Receipt;
                ibtn2.Text = "KẾT CA"; ibtn2.IconChar = IconChar.HourglassEnd;
                ibtn3.Visible = false;
                ibtn4.Visible = false;
            }
            else if (LoaiTaiKhoan == "phache")
            {
                lblHomeButton_Role.Text = "Quản Lý";
                ibtn1.Text = "KHO QUẦY"; ibtn1.IconChar = IconChar.Store;
                ibtn2.Visible = false;
                ibtn3.Visible = false;
                ibtn4.Visible = false;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private Form currentChildForm = null;
        private void ibtn1_Click(object sender, EventArgs e)
        {
            if (LoaiTaiKhoan == "chuquan" || LoaiTaiKhoan == "quanly")
            {
                MenuAnimation.ActivateButton(sender, MenuAnimation.RGBColors.color1, iconCurrentChildForm);
                MenuAnimation.OpenChildForm(new FormsChuQuan.FormThongKe(), ref currentChildForm, panelDesktop, labelTittleChildForm);
            }
            else if (LoaiTaiKhoan == "thungan")
            {
                ibtn1.Text = "NHẬN ĐƠN";
            }
            else if (LoaiTaiKhoan == "phache")
            {
                ibtn1.Text = "KHO QUẦY";
            }
        }

        // Drag The Form - using System.Runtime.InteropServices;
        [DllImport("user32")]
        private static extern bool ReleaseCapture();
        [DllImport("user32")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wp, int lp);
        private void panelTittleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
                btnMaximize.IconChar = IconChar.WindowRestore;
            }
            else
            {
                WindowState = FormWindowState.Normal;
                btnMaximize.IconChar = IconChar.WindowMaximize;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void ĐăngXuất_Click(object sender, EventArgs e)
        {
            SignIn logout = new SignIn();
            logout.Show();
            this.Hide();
        }
    }
}
