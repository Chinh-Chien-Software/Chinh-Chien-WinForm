using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChinChin.GUI.Main
{
    public partial class ChuaCoQuan : Form
    {
        public ChuaCoQuan()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTaoQuan_Click(object sender, EventArgs e)
        {
            ChinChin.GUI.formThem.ThemCapnhatQuan taoQuan = new ChinChin.GUI.formThem.ThemCapnhatQuan();
            taoQuan.Show();
        }

        private void btnThamGiaQuan_Click(object sender, EventArgs e)
        {
            btnThamGiaQuan.Text = "Comming soon..";
        }

        private void ipbBack_Click(object sender, EventArgs e)
        {
            ChinChin.UI.LogIn LogIn = new ChinChin.UI.LogIn();
            LogIn.Show();
            this.Hide();
        }
    }
}
