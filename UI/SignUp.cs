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

namespace ChinChin.UI
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
            lblThongBao.Visible = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Size = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblNoAccount_Click(object sender, EventArgs e)
        {
            LogIn LogIn = new LogIn();
            LogIn.Show();
            this.Hide();
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            ChinChin.Database.WorkingDatabase.CreateAccount(tbcUsername.TB_Text, tbcPassword.TB_Text, "", 1);
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

        private void iPBxShowHideRewritePasword_Click(object sender, EventArgs e)
        {
            if (tbcRewritePassword.PasswordChar == '\0')
            {
                tbcRewritePassword.PasswordChar = '*';
                iPBxShowHideRewritePasword.IconChar = IconChar.Eye;
            }
            else
            {
                tbcRewritePassword.PasswordChar = '\0';
                iPBxShowHideRewritePasword.IconChar = IconChar.EyeSlash;
            }
        }
    }
}
