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
using ChinChin.DAL_DAO;

namespace ChinChin.UI
{
    public partial class MainUI : Form
    {
        public MainUI()
        {
            InitializeComponent();
        }
        public string TenTaiKhoan
        {
            get;
            set;
        }
        public string TenQuan
        {
            get;
            set;
        }
        public string MaQuan
        {
            get;
            set;
        }
        public MainUI(string TenTaiKhoan) : this()
        {
            this.TenTaiKhoan = TenTaiKhoan;
        }

        // Hàm cũ trước khi còn trường LoaiTaiKhoan
        public MainUI(string TenTaiKhoan, string LoaiTaiKhoan) : this()
        {
            // Viết hàm khởi tạo này để mang theo dữ liệu khi chạy Form MainUI
            //this.LoaiTaiKhoan = LoaiTaiKhoan;
            this.TenTaiKhoan = TenTaiKhoan;
        }
        private void MainUI_Load(object sender, EventArgs e)
        {
            //this.Text = "";
            this.ControlBox = false;
            mnsiIconTaiKhoan.Text = TenTaiKhoan;
            lblTenQuan.Text = TenQuan;

            ibtnThongKe.Text = "THỐNG KÊ"; ibtnThongKe.IconChar = IconChar.Dashcube;
            //ibtn2.Text = "CHẤM CÔNG"; ibtnNhanDon.IconChar = IconChar.MoneyCheckAlt;
            ibtnNhanDon.Text = "NHẬN ĐƠN"; ibtnThongKe.IconChar = IconChar.Receipt;
            ibtnVatTu.Text = "KHO HÀNG"; //ibtn2.IconChar = IconChar.Boxes;
            ibtnThucDon.Text = "THỰC ĐƠN"; ibtnVatTu.IconChar = IconChar.MugHot;
            //ibtn6.Text = "LỊCH LÀM";
            ibtnNhanDon.IconChar = IconChar.Calendar;
            ibtnNhanSu.Text = "NHÂN SỰ"; //ibtn2.IconChar = IconChar.PeopleCarry;
            ShowQuanInCbbChuyenQuan();
        }

        /// <method>
        ///  Hàm để hiện thị các quán khi click vào Chuyển quán
        /// </method>
        void ShowQuanInCbbChuyenQuan()
        {
            // Đổ dữ liệu vào cbbChuyenQuan
            QuanDAO quan = new QuanDAO();
            DataTable dt = quan.searchQuanByTenTaiKhoan(this.TenTaiKhoan);
            cbbChuyenQuan.DataSource = dt;
            cbbChuyenQuan.DisplayMember = "TenQuan";
            cbbChuyenQuan.ValueMember = "MaQuan";
            cbbChuyenQuan.Text = "Chuyển quán";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private Form currentChildForm = null;
        private void ibtnThongKe_Click(object sender, EventArgs e)
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

        private void ibtnVatTu_Click(object sender, EventArgs e)
        {
            MenuAnimation.ActivateButton(sender, MenuAnimation.RGBColors.color2, iconCurrentChildForm);
            MenuAnimation.OpenChildForm(new KhoHang(), ref currentChildForm, pnlChildForm, labelTittleChildForm);
        }

        private void ibtnThucDon_Click(object sender, EventArgs e)
        {
            MenuAnimation.ActivateButton(sender, MenuAnimation.RGBColors.color3, iconCurrentChildForm);
            MenuAnimation.OpenChildForm
                (new ChinChin.Forms_ChuQuan.FormThucDon(), ref currentChildForm, pnlChildForm, labelTittleChildForm);
        }

        private void ibtnNhanSu_Click(object sender, EventArgs e)
        {
            MenuAnimation.ActivateButton(sender, MenuAnimation.RGBColors.color4, iconCurrentChildForm);
            MenuAnimation.OpenChildForm
                (new ChinChin.GUI.NhanSu(), ref currentChildForm, pnlChildForm, labelTittleChildForm);
        }

        private void ibtnNhanDon_Click(object sender, EventArgs e)
        {
            MenuAnimation.ActivateButton(sender, MenuAnimation.RGBColors.color5, iconCurrentChildForm);
            MenuAnimation.OpenChildForm
                (new ChinChin.Forms_NhanVien.TiepNhanDonHang(), ref currentChildForm, pnlChildForm, labelTittleChildForm);
        }
    }
}
