using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ChinhChien.DAL_DAO
{
    public class ThemDAO
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
            string sqlAddVatLieu =
                "insert into VatLieu values ('" + MaVatLieu + "', N'" + TenVatLieu + "', N'" + NhaCungCap + "', " + SoLuong + ", " + Gia + ", N'" + DonViTinh + "', '" + MaQuan + "')";
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
            string sqlAddSanPham = "insert into SanPham values ('" + MaSanPham + "', N'" + TenSanPham + "', '" + CongThuc + "', '" + ThanhPhan + "', " + Gia + ", " + DanhGia + ", '" + Loai + "', '" + MaQuan + "')";
            cmd = new SqlCommand(sqlAddSanPham, con);
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
                = "insert into NhanVien values ('" + MaNhanVien + "', N'" + TenNhanVien + "', '" + LuongTrenGio.ToString() + "', " + NgayVaoLam.ToString("yyyy-mm-dd") + ", '" + GioiTinh + "', " + NgaySinh.ToString("yyyy-mm-dd") + ", '" + SoDienThoai + "', N'" + DiaChi + "', '" + LoaiNhanVien + "', '" + MaQuan + "')";
            cmd = new SqlCommand(sqlThemNhanVien, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static void ChiTietHoaDon(string MaSanPham, string MaHoaDon, int SoLuong)
        {
            con.Open();
            string sqlThemThongTinHoaDon
                = "insert into ChiTietHoaDon values ('" + MaSanPham + "', '" + MaHoaDon + "', '" + SoLuong + "')";
            cmd = new SqlCommand(sqlThemThongTinHoaDon, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static void HoaDon(string MaHoaDon, string MaNhanVien, DateTime NgayLap, string MaQuan)
        {
            con.Open();
            string sqlThemHoaDon
                = "insert into HoaDon values ('" + MaHoaDon + "', '" + MaNhanVien + "', '" + NgayLap.ToString("yyyy-mm-dd") + "', '" + MaQuan + "')";
            cmd = new SqlCommand(sqlThemHoaDon, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
