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
using ChinChin.FormsChuQuan;
using ChinChin.FormsQuanLy;
using ChinChin.Extra;

namespace ChinChin
{
    public partial class SignIn : Form
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

        public SignIn()
        {
            InitializeComponent();
            labelThongBao.Text = "";
            this.Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.WorkingArea.Height);
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            //this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        

        private void labelUserName_Click(object sender, EventArgs e)
        {

        }

        private void SignIn_Load(object sender, EventArgs e)
        {

        }

        private void labelPasword_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SignInButton_MouseHover(object sender, EventArgs e)
        {
            SignInButton.BackgroundColor = Color.Black;
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            string username = txtBxUsername.Text;
            string password = txtBxPassword.Text;
            formChuQuan f2 = new formChuQuan();
            QuanLy f3 = new QuanLy();
            if (username == "chuquan")
            {
                f2.Show();
                this.Hide();
            }
            else if (username == "quanly")
            {
                f3.Show();
                this.Hide();
            }
            else if (username == "")
            {
                labelThongBao.Text = "Chưa Nhập Nội Dung";
            }
        }
    }
}

        
