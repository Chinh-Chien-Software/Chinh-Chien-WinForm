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

namespace ChinChin.UI
{
    public partial class ThongTinTaiKhoan : Form
    {
        public ThongTinTaiKhoan()
        {
            InitializeComponent();
        }
        public string TenTaiKhoan;
        public ThongTinTaiKhoan(string TenTaiKhoan) : this()
        {
            // Viết hàm khởi tạo này để mang theo dữ liệu khi chạy Form MainUI
            this.TenTaiKhoan = TenTaiKhoan;
        }
        private void ThongTinTaiKhoan_Load(object sender, EventArgs e)
        {
            string sqlcode = "SELECT nv.MaNhanVien, nv.TenNhanVien, nv.GioiTinh,  nv.NgayVaoLam, nv.LuongTrenGio, nv.NgaySinh, nv.DiaChi, nv.SoDienThoai FROM TaiKhoan tk, NhanVien nv WHERE tk.TenTaiKhoan = '"+TenTaiKhoan+"' and tk.MaNhanVien = nv.MaNhanVien";
            DataTable TaiKhoan = new DataTable();
            TaiKhoan = DataProvider.LoadDatabase(sqlcode);

            //tbMaNhanVien.Text = TaiKhoan.Rows[0][0].ToString();
            tbTenNhanVien.Text = TaiKhoan.Rows[0][1].ToString();
            tbGioiTinh.Text = TaiKhoan.Rows[0][2].ToString();
            //tbChucVu.Text = TaiKhoan.Rows[0][3].ToString();
            //tbNgayVaoLam.Text = TaiKhoan.Rows[0][4].ToString();
            //tbTienLuong.Text = TaiKhoan.Rows[0][5].ToString();
            tbNgaySinh.Text = TaiKhoan.Rows[0][6].ToString();
            tbDiaChi.Text = TaiKhoan.Rows[0][7].ToString();
            tbSDT.Text = TaiKhoan.Rows[0][8].ToString();
        }

        private void btDoiMatKhau_Click(object sender, EventArgs e)
        {

        }
    }
}
