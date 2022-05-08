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
    public partial class ThemCapnhatSanPham : Form
    {
        int ChucNang;
        public ThemCapnhatSanPham()
        {
            InitializeComponent();
            btnLuu.Text = "Lưu";
            ChucNang = 0;
        }
        public ThemCapnhatSanPham(
            string MaSanPham,
            string TenSanPham,
            string CongThuc,
            string ThanhPhan,
            float Gia,
            int DanhGia
            )
        {
            InitializeComponent();
            btnLuu.Text = "Cập nhật";
            tbcMaSP.Text = MaSanPham;
            tbcTenSP.Text = TenSanPham;
            tbcCT.Text = CongThuc;
            tbcTPhan.Text = ThanhPhan;
            tbcGia.Text = Gia.ToString();
            tbcDanhGia.Text = DanhGia.ToString();
            ChucNang = 1;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (ChucNang == 0)
            {
                ThemDAL.SanPham
                    (tbcMaSP.Text, tbcTenSP.Text, tbcCT.Text, tbcTPhan.Text, float.Parse(tbcGia.Text), int.Parse(tbcDanhGia.Text));
                this.Close();
            }
            if (ChucNang == 1)
            {
                btnLuu.Text = "Cập nhật";
                CapNhatDAL.SanPham
                    (tbcMaSP.Text, tbcTenSP.Text, tbcCT.Text, tbcTPhan.Text, float.Parse(tbcGia.Text), int.Parse(tbcDanhGia.Text));
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
