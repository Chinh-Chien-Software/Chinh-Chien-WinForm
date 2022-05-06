using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ChinChin.Database
{
    public class Them
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
            string DonViTinh
            )
        {
            con.Open();
            string sqlAddVatLieu = "insert into VatLieu values ('" + MaVatLieu + "', '" + TenVatLieu + "', '" + NhaCungCap + "', " + SoLuong + ", " + Gia + ", '" + DonViTinh + "')";
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
            int DanhGia
            )
        {
            con.Open();
            string sqlAddSanPham = "insert into VatLieu values ('" + MaSanPham + "', '" + TenSanPham + "', '" + CongThuc + "', '" + ThanhPhan + "', " + Gia + ", " + DanhGia + ")";
            cmd = new SqlCommand(sqlAddSanPham, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
