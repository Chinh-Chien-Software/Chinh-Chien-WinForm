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

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (ChucNang == 0)
            {
                ThemDAL.NhanVien
                    (tbcMaNV.Text, tbcTenNV.Text, int.Parse(tbcLuong.Text), dtpNgayVL.Value,
                    cbbGioiTinh.Text, dtpNgaySinh.Value, tbcSDT.Text, tbcDC.Text, cbbChucVu.Text, "quanchinhchien");
                var f = (NhanSu)this.Owner;
                f.RefreshDGV();
                this.Close();
            }
            else if (ChucNang == 1)
            {
                btnLuu.Text = "Cập nhật";
                CapNhatDAL.NhanVien
                    (tbcMaNV.Text, tbcTenNV.Text, int.Parse(tbcLuong.Text), dtpNgayVL.Value,
                    cbbGioiTinh.Text, dtpNgaySinh.Value, tbcSDT.Text, tbcDC.Text, cbbChucVu.Text, "quanchinhchien");
                var f1 = (NhanSu)this.Owner;
                f1.RefreshDGV();
                this.Close();
            }
        }
    }
}
