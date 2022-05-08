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
using ChinChin.Forms_QuanLy;

namespace ChinChin.UI
{
    public partial class MainUI : Form
    {
        public MainUI()
        {
            InitializeComponent();
            
        }
        string TenTaiKhoan;
        string LoaiTaiKhoan;

        public MainUI(string TenTaiKhoan) : this()
        {
            this.TenTaiKhoan = TenTaiKhoan;
        }

        // Hàm cũ trước khi còn trường LoaiTaiKhoan
        public MainUI(string TenTaiKhoan, string LoaiTaiKhoan) : this()
        {
            // Viết hàm khởi tạo này để mang theo dữ liệu khi chạy Form MainUI
            this.LoaiTaiKhoan = LoaiTaiKhoan;
            this.TenTaiKhoan = TenTaiKhoan;
        }
        private void MainUI_Load(object sender, EventArgs e)
        {
            //this.Text = "";
            this.ControlBox = false;

            ibtn1.Text = "THỐNG KÊ"; ibtn1.IconChar = IconChar.Dashcube;
            ibtn2.Text = "CHẤM CÔNG"; ibtn3.IconChar = IconChar.MoneyCheckAlt;
            ibtn3.Text = "NHẬN ĐƠN"; ibtn1.IconChar = IconChar.Receipt;
            ibtn4.Text = "KHO HÀNG"; ibtn2.IconChar = IconChar.Boxes;
            ibtn5.Text = "THỰC ĐƠN"; ibtn4.IconChar = IconChar.MugHot;
            ibtn6.Text = "LỊCH LÀM"; ibtn3.IconChar = IconChar.Calendar;
            ibtn7.Text = "NHÂN SỰ"; ibtn2.IconChar = IconChar.PeopleCarry;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private Form currentChildForm = null;
        private void ibtn1_Click(object sender, EventArgs e)
        {
            MenuAnimation.ActivateButton(sender, MenuAnimation.RGBColors.color1, iconCurrentChildForm);
            MenuAnimation.OpenChildForm(new FormsChuQuan.FormThongKe(), ref currentChildForm, pnlChildForm, labelTittleChildForm);
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
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void DangXuat_Click(object sender, EventArgs e)
        {
            LogIn logout = new LogIn();
            logout.Show();
            this.Hide();
        }

        private void mnsiCaiDat_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Đang mở Cài Đặt, đợi xíu");
            MenuAnimation.OpenChildForm(new CaiDat(), ref currentChildForm, pnlChildForm, labelTittleChildForm);
        }

        private void mnsiThongTinTaiKhoan_Click(object sender, EventArgs e)
        {
            MenuAnimation.OpenChildForm(new ThongTinTaiKhoan(), ref currentChildForm, pnlChildForm, labelTittleChildForm);
        }

        private void ibtn2_Click(object sender, EventArgs e)
        {

        }

        private void ibtn4_Click(object sender, EventArgs e)
        {
            MenuAnimation.ActivateButton(sender, MenuAnimation.RGBColors.color2, iconCurrentChildForm);
            MenuAnimation.OpenChildForm(new KhoHang(), ref currentChildForm, pnlChildForm, labelTittleChildForm);
        }

        private void ibtn5_Click(object sender, EventArgs e)
        {
            MenuAnimation.ActivateButton(sender, MenuAnimation.RGBColors.color3, iconCurrentChildForm);
            MenuAnimation.OpenChildForm
                (new ChinChin.Forms_ChuQuan.FormThucDon(), ref currentChildForm, pnlChildForm, labelTittleChildForm);
        }

        private void ibtn7_Click(object sender, EventArgs e)
        {
            MenuAnimation.ActivateButton(sender, MenuAnimation.RGBColors.color4, iconCurrentChildForm);
            MenuAnimation.OpenChildForm
                (new ChinChin.GUI.NhanSu(), ref currentChildForm, pnlChildForm, labelTittleChildForm);
        }

        private void ibtn3_Click(object sender, EventArgs e)
        {
            MenuAnimation.ActivateButton(sender, MenuAnimation.RGBColors.color5, iconCurrentChildForm);
            MenuAnimation.OpenChildForm
                (new ChinChin.Forms_NhanVien.TiepNhanDonHang(), ref currentChildForm, pnlChildForm, labelTittleChildForm);
        }
    }
}
