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
    public partial class ThemSuaSanPham : Form
    {
        int ChucNang = 0;
        public ThemSuaSanPham()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            Them.SanPham(tbcMaSP.Text, tbcTenSP.Text, tbcCT.Text, tbcTPhan.Text, float.Parse(tbcGia.Text), int.Parse(tbcDanhGia.Text));
            this.Close();
        }
    }
}
