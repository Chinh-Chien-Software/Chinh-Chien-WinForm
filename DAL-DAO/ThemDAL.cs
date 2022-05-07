using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ChinChin.DAL_DAO
{
    public class ThemDAL
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
            string sqlAddVatLieu = "insert into VatLieu values ('" + MaVatLieu + "', N'" + TenVatLieu + "', '" + NhaCungCap + "', " + SoLuong + ", " + Gia + ", '" + DonViTinh + "')";
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
            string sqlAddSanPham = "insert into SanPham values ('" + MaSanPham + "', N'" + TenSanPham + "', '" + CongThuc + "', '" + ThanhPhan + "', " + Gia + ", " + DanhGia + ")";
            cmd = new SqlCommand(sqlAddSanPham, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
