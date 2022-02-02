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
using ChinChin.UI;

namespace ChinChin.FormsQuanLy
{
    public partial class QuanLy : Form
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

        private Form currentChildForm;

        public QuanLy()
        {
            InitializeComponent();
            this.Size = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
            this.WindowState = FormWindowState.Maximized;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            //leftBorderBtn = new Panel();
            //leftBorderBtn.Size = new Size(7, 100);
            //panelMenu.Controls.Add(leftBorderBtn);

            //Forms - Custom Tittle Bar
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            MenuAnimation.Reset(iconCurrentChildForm, labelTittleChildForm);
        }

        //Drag my Software
        [DllImport("user32")]
        private static extern bool ReleaseCapture();

        [DllImport("user32")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wp, int lp);

        private void btnHome_Click_1(object sender, EventArgs e)
        {

        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click_1(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
                WindowState = FormWindowState.Normal;
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            SignIn logout = new SignIn();
            logout.Show();
            this.Hide();
        }

        private void KhoHangBTN_Click_1(object sender, EventArgs e)
        {
            MenuAnimation.ActivateButton(sender, MenuAnimation.RGBColors.color2, iconCurrentChildForm);
            MenuAnimation.OpenChildForm(new Forms_QuanLy.QuanLyKhoHang(), ref currentChildForm, panelDesktop, labelTittleChildForm);
        }

        private void ChamCongBTN_Click(object sender, EventArgs e)
        {
            MenuAnimation.ActivateButton(sender, MenuAnimation.RGBColors.color1, iconCurrentChildForm);
            MenuAnimation.OpenChildForm(new Forms_QuanLy.QuanLyLichLam(), ref currentChildForm, panelDesktop, labelTittleChildForm);
        }

        private void panelTittleBar_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void ThongKeBTN_Click(object sender, EventArgs e)
        {
            MenuAnimation.ActivateButton(sender, MenuAnimation.RGBColors.color4, iconCurrentChildForm);
            MenuAnimation.OpenChildForm(new Forms_QuanLy.BaoCaoDoanhThu(), ref currentChildForm, panelDesktop, labelTittleChildForm);
        }
    }
}
