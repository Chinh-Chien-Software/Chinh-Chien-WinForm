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
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTaoQuan_Click(object sender, EventArgs e)
        {
            ChinChin.GUI.Main.TaoQuan taoQuan = new ChinChin.GUI.Main.TaoQuan();
            taoQuan.Show();
        }

        private void btnThamGiaQuan_Click(object sender, EventArgs e)
        {
            btnThamGiaQuan.Text = "Comming soon..";
        }
    }
}
