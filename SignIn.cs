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

namespace ChinChin
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string username = txtBxUsername.Text;
            string password = txtBxPassword.Text;
            formChuQuan f2 = new formChuQuan();
            f2.Show();
            this.Hide();
        }
    }
}

        
