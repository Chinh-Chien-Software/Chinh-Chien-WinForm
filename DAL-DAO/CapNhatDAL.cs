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
            string DonViTinh
            )
        {
            con.Open();
            string sqlAddVatLieu = "update VatLieu set TenVatLieu = N'" + TenVatLieu + "', NhaCungCap = N'" + NhaCungCap + "', SoLuong = " + SoLuong + ", Gia = " + Gia + ", DonViTinh = N'" + DonViTinh + "' where MaVatLieu = '" + MaVatLieu + "'";
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
            string sqlAddVatLieu 
                = "update SanPham set TenSanPham = N'" + TenSanPham + "', CongThuc = N'" + CongThuc + "', ThanhPhan = '" + ThanhPhan + "', Gia = " + Gia + ", DanhGia = " + DanhGia + " where MaSanPham = '" + MaSanPham + "'";
            cmd = new SqlCommand(sqlAddVatLieu, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
