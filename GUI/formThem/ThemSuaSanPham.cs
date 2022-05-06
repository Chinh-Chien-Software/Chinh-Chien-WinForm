using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChinChin.DAL_DAO;

namespace ChinChin.GUI.formThem
{
    public partial class ThemSuaSanPham : Form
    {
        //int ChucNang = 0;
        public ThemSuaSanPham()
        {
            InitializeComponent();
        }
        public ThemSuaSanPham(int ChucNang)
        {
            InitializeComponent();
            if (ChucNang == 0)
            {
                btnLuu.Text = "Lưu";
            }
            if (ChucNang == 1)
            {
                btnLuu.Text = "Cập nhật";
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            ThemDAL.SanPham(tbcMaSP.Text, tbcTenSP.Text, tbcCT.Text, tbcTPhan.Text, float.Parse(tbcGia.Text), int.Parse(tbcDanhGia.Text));
            this.Close();
        }
    }
}
