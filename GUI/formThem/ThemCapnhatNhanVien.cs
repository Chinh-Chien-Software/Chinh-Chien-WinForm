using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChinChin.GUI.formThem
{
    public partial class ThemCapnhatNhanVien : Form
    {
        int ChucNang;
        public ThemCapnhatNhanVien()
        {
            InitializeComponent();
            ChucNang = 0;
        }

        public ThemCapnhatNhanVien(
            string MaNhanVien,
            string TenNhanVien,
            int LuongTrenGio,
            DateTime NgayVaoLam,
            string GioiTinh,
            DateTime NgaySinh,
            string SoDienThoai,
            string DiaChi,
            string LoaiNhanVien
            )
        {
            InitializeComponent();
            ChucNang = 1;
            tbcMaNV.Enabled = false;
            tbcMaNV.Text = MaNhanVien;
            tbcTenNV.Text = TenNhanVien;
            tbcLuong.Text = LuongTrenGio.ToString();
            dtpNgayVL.Value = NgayVaoLam;
            cbbGioiTinh.Text = GioiTinh;
            dtpNgaySinh.Value = NgaySinh;
            tbcSDT.Text = SoDienThoai;
            tbcDC.Text = DiaChi;
            cbbChucVu.Text = LoaiNhanVien;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
