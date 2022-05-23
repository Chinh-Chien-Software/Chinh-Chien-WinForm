using ChinChin.DAL_DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChinChin.Classes;

namespace ChinChin.BUS
{
    internal class NhanVienBUS
    {
        private NhanVienDAO NhanVienDAO;
         
        public NhanVienBUS()
        {
            NhanVienDAO = new NhanVienDAO();
        }

        public DataTable getNhanVienBUS(string MaQuan)
        {
            return NhanVienDAO.getNhanVien(MaQuan);
        }

        public bool ThemNhanVienBUS(string MaNhanVien,
            string TenNhanVien,
            int LuongTrenGio,
            DateTime NgayVaoLam,
            string GioiTinh,
            DateTime NgaySinh,
            string SoDienThoai,
            string DiaChi,
            string LoaiNhanVien,
            string MaQuan)
        {
            return NhanVienDAO.ThemNhanVienDAO(MaNhanVien,
            TenNhanVien,
            LuongTrenGio,
            NgayVaoLam,
            GioiTinh,
            NgaySinh,
            SoDienThoai,
            DiaChi,
            LoaiNhanVien,
            MaQuan);
        }

        public bool SuaNhanVienBUS(string MaNhanVien,
            string TenNhanVien,
            int LuongTrenGio,
            DateTime NgayVaoLam,
            string GioiTinh,
            DateTime NgaySinh,
            string SoDienThoai,
            string DiaChi,
            string LoaiNhanVien,
            string MaQuan, string TenTaiKhoan)
        {
            return NhanVienDAO.SuaNhanVienDAO(MaNhanVien,
            TenNhanVien,
            LuongTrenGio,
            NgayVaoLam,
            GioiTinh,
            NgaySinh,
            SoDienThoai,
            DiaChi,
            LoaiNhanVien,
            MaQuan, TenTaiKhoan);
        }

        public bool XoaNhanVienBUS(string MaNhanVien)
        {
            return NhanVienDAO.XoaNhanVienDAO(MaNhanVien);
        }

        public bool ThemTaiKhoanBUS(string TenTaiKhoan,string MaNhanVien)
        {
            return NhanVienDAO.ThemTaiKhoan(TenTaiKhoan,MaNhanVien);
        }
    }
}
