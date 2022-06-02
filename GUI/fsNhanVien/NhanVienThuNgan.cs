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
using ChinhChien.UI;

namespace ChinhChien.Forms_NhanVien
{
    public partial class NhanVienThuNgan : Form
    {
        public NhanVienThuNgan()
        {
            InitializeComponent();
            this.Size = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
            // this.WindowState = FormWindowState.Maximized;
            this.Text = string.Empty;
            this.ControlBox = false;
        }
        //Fields
        private Form currentChildForm;

        //Methods
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void SignOutButton_Click_1(object sender, EventArgs e)
        {
            LogIn logout = new LogIn();
            logout.Show();
            this.Hide();
        }

        private void ThongKeBTN_Click(object sender, EventArgs e)
        {
            MenuAnimation.ActivateButton(sender, MenuAnimation.RGBColors.color1, iconCurrentChildForm);
            MenuAnimation.OpenChildForm(new TiepNhanDonHang(), ref currentChildForm, panelDesktop, labelTittleChildForm);
        }

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
    }
}
