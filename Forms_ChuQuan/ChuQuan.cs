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


namespace ChinChin.FormsChuQuan
{
    public partial class formChuQuan : Form
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

        //Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        public formChuQuan()
        {
            InitializeComponent();
            this.Size = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
            this.WindowState = FormWindowState.Maximized;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 100);
            panelMenu.Controls.Add(leftBorderBtn);

            //Forms - Custom Tittle Bar
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        

        //Structs
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 188, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 241);
        }

        //Methods
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                currentBtn.Size = new Size(498, 100);

                //left border button
                //leftBorderBtn.BackColor = color;
                //leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                //leftBorderBtn.Visible = true;
                //leftBorderBtn.BringToFront();

                //Icon Current Child Form
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(255, 255, 255);
                currentBtn.ForeColor = Color.Black;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Black;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
                currentBtn.Size = new Size(498, 100);
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                //Open Only Form
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelTittleChildForm.Text = childForm.Text;
        }
        private void ThongKeBTN_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new FormsChuQuan.FormThongKe());
        }

        private void KhoHangBTN_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new FormsChuQuan.FormKhoHang());
        }
        private void ChamCongBTN_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new FormsChuQuan.FormChamCong());
        }
        private void btnHome_Click_1(object sender, EventArgs e)
        {
            currentChildForm.Close();
            Reset();
        }
        private void Reset()
        {
            DisableButton();
            //leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.MediumPurple;
            labelTittleChildForm.Text = "Home";
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
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new Forms_ChuQuan.FormThucDon());
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
            SignIn logout = new SignIn();
            logout.Show();
            this.Hide();
        }
    }
}
