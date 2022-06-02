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
using ChinhChien.UI;
using ChinhChien.DAL_DAO;

namespace ChinhChien.Forms_NhanVien
{
    public partial class NhanVienPhaChe : Form
    {
        public NhanVienPhaChe()
        {
            InitializeComponent();
            this.Size = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
            // this.WindowState = FormWindowState.Maximized;

            //Forms - Custom Tittle Bar
            this.Text = string.Empty;
            this.ControlBox = false;
        }

        //Fields
        public static Form currentChildForm;

        //Methods

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SignOutButton_Click_1(object sender, EventArgs e)
        {
            frmLogIn logout = new frmLogIn();
            logout.Show();
            this.Hide();
        }

        private void KhoQuayBTN_Click(object sender, EventArgs e)
        {
            MenuAnimation.ActivateButton(sender, MenuAnimation.RGBColors.color5, iconCurrentChildForm);
            MenuAnimation.OpenChildForm(new KiemSoatLuongTonHang(), ref currentChildForm, panelDesktop, labelTittleChildForm);
        }

        private void TaiKhoanBTN_Click(object sender, EventArgs e)
        {

        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
                WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //Drag my Software
        [DllImport("user32")]
        private static extern bool ReleaseCapture();

        [DllImport("user32")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wp, int lp);
        private void panelTittleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            MenuAnimation.Reset(iconCurrentChildForm, labelTittleChildForm);
        }



        private void NhanVienPhaChe_Load(object sender, EventArgs e)
        {
            string sqlcode = "SELECT nv.TenNhanVien FROM TaiKhoan tk, NhanVien nv WHERE tk.TenTaiKhoan = '" + ChinhChien.UI.frmLogIn.username + "' AND tk.MatKhau = '" + ChinhChien.UI.frmLogIn.password + "' AND nv.MaNhanVien = tk.MaNhanVien";
            DataTable TaiKhoan = new DataTable();
            TaiKhoan = DataProvider.ReturnDataTable(sqlcode);
            //MnsTaiKhoan.Text = TaiKhoan.Rows[0][0].ToString();
        }
    }
}
