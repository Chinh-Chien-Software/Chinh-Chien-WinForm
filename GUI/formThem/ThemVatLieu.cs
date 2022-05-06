using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChinChin.Database;

namespace ChinChin.GUI.formThem
{
    public partial class ThemVatLieu : Form
    {
        public ThemVatLieu()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void ThemVatLieu_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            Them.VatLieu(tbcMaVL.Text, tbcTenVL.Text, tbcNhaCC.Text, Convert.ToInt32(tbcSL.Text), float.Parse(tbcGia.Text), tbcDVT.Text);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

        }
    }
}
