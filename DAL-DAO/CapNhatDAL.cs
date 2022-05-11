using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ChinChin.DAL_DAO
{
    internal class CapNhatDAL
    {
        static string connString = Properties.Settings.Default.ChinhChienConnectionString;
        static SqlConnection con = new SqlConnection(connString);
        static SqlCommand cmd;

        public static void VatLieu(
            string MaVatLieu,
            string TenVatLieu,
            string NhaCungCap,
            int SoLuong,
            float Gia,
            string DonViTinh,
            string MaQuan
            )
        {
            con.Open();
            string sqlAddVatLieu
                = "update VatLieu set TenVatLieu = N'" + TenVatLieu + "', NhaCungCap = N'" + NhaCungCap + "', SoLuong = " + SoLuong + ", Gia = " + Gia + ", DonViTinh = N'" + DonViTinh + "', MaQuan = '" + MaQuan + "' where MaVatLieu = '" + MaVatLieu + "'";
            cmd = new SqlCommand(sqlAddVatLieu, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        
        public static void SanPham(
            string MaSanPham,
            string TenSanPham,
            string CongThuc,
            string ThanhPhan,
            float Gia,
            int DanhGia,
            string Loai,
            string MaQuan
            )
        {
            con.Open();
            string sqlAddVatLieu 
                = "update SanPham set TenSanPham = N'" + TenSanPham + "', CongThuc = N'" + CongThuc + "', ThanhPhan = '" + ThanhPhan + "', Gia = " + Gia + ", DanhGia = " + DanhGia + ", Loai = '"+ Loai + "', MaQuan = '" + Loai + "' where MaSanPham = '" + MaSanPham + "'";
            cmd = new SqlCommand(sqlAddVatLieu, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        
        public static void NhanVien(
            string MaNhanVien,
            string TenNhanVien,
            int LuongTrenGio,
            DateTime NgayVaoLam,
            string GioiTinh,
            DateTime NgaySinh,
            string SoDienThoai,
            string DiaChi,
            string LoaiNhanVien,
            string MaQuan
            )
        {
            con.Open();
            string sqlThemNhanVien
                = "update NhanVien set TenNhanVien = N'" + TenNhanVien + "', LuongTrenGio = '" + LuongTrenGio.ToString() + "', NgayVaoLam = '" + NgayVaoLam + "', GioiTinh = '" + GioiTinh + "', NgaySinh = '" + NgaySinh + "', SoDienThoai = '" + SoDienThoai + "', DiaChi = N'" + DiaChi + "', LoaiNhanVien = '" + LoaiNhanVien + "', MaQuan = '" + MaQuan + "' where MaNhanVien = '" + MaNhanVien + "'";
            cmd = new SqlCommand(sqlThemNhanVien, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
