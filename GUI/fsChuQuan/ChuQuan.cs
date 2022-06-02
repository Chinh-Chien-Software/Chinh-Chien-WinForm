using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using FontAwesome.Sharp;
using ChinhChien.UI;


namespace ChinhChien.FormsChuQuan
{
    public partial class formChuQuan : Form
    {

        /*[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // width of ellipse
           int nHeightEllipse // height of ellipse
        );*/

        private Form currentChildForm = null;

        public formChuQuan()
        {
            InitializeComponent();
            // Full Màn Hình => #35 trên Github
            this.Size = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
            // this.WindowState = FormWindowState.Maximized;
            /*Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 100);
            panelMenu.Controls.Add(leftBorderBtn);*/

            //Forms - Custom Tittle Bar
            this.Text = string.Empty;
            this.ControlBox = false;

            //this.DoubleBuffered = true;
            //this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        
        //Methods
        
        private void ThongKeBTN_Click_1(object sender, EventArgs e)
        {
            MenuAnimation.ActivateButton(sender, MenuAnimation.RGBColors.color1, iconCurrentChildForm);
            MenuAnimation.OpenChildForm(new FormsChuQuan.FormThongKe(), ref currentChildForm, panelDesktop, labelTittleChildForm);
        }

        private void KhoHangBTN_Click_1(object sender, EventArgs e)
        {
            MenuAnimation.ActivateButton(sender, MenuAnimation.RGBColors.color2, iconCurrentChildForm);
            MenuAnimation.OpenChildForm(new FormsChuQuan.FormKhoHang(),ref currentChildForm, panelDesktop, labelTittleChildForm);
        }
        private void ChamCongBTN_Click_1(object sender, EventArgs e)
        {
            MenuAnimation.ActivateButton(sender, MenuAnimation.RGBColors.color3, iconCurrentChildForm);
            MenuAnimation.OpenChildForm(new FormsChuQuan.FormChamCong(),ref currentChildForm, panelDesktop, labelTittleChildForm);
        }
        private void btnHome_Click_1(object sender, EventArgs e)
        {
            currentChildForm.Close();
            MenuAnimation.Reset(iconCurrentChildForm, labelTittleChildForm);
        }
        


        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void btnMinimize_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }



        private void iconButtonThucDon_Click(object sender, EventArgs e)
        {
            MenuAnimation.ActivateButton(sender, MenuAnimation.RGBColors.color3, iconCurrentChildForm);
            MenuAnimation.OpenChildForm(new Forms_ChuQuan.QuanLyMenu(),ref currentChildForm, panelDesktop, labelTittleChildForm);
        }

        private void panelTittleBar_Paint(object sender, PaintEventArgs e)
        {

        }

        //Drag my Software
        [DllImport("user32")]
        private static extern bool ReleaseCapture();

        [DllImport("user32")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wp, int lp);
        private void panelTittleBar_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelTittleBar_DoubleClick(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
                WindowState = FormWindowState.Normal;
        }

        private void panelTittleBar_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
                WindowState = FormWindowState.Normal;
        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconCurrentChildForm_Click(object sender, EventArgs e)
        {

        }

        private void labelTittleChildForm_Click(object sender, EventArgs e)
        {

        }

        private void SignOutButton_Click(object sender, EventArgs e)
        {
            frmLogIn logout = new frmLogIn();
            logout.Show();
            this.Hide();
        }
    }
}
