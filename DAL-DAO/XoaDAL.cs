using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ChinChin.DAL_DAO
{
    internal class XoaDAL
    {
        static string connString = Properties.Settings.Default.ChinhChienConnectionString;
        static SqlConnection con = new SqlConnection(connString);
        static SqlCommand cmd;

        public static void VatLieu(string MaVatLieu)
        {
            con.Open();
            string sqlXoaVatLieu = "DELETE FROM VATLIEU WHERE MaVatLieu = '" + MaVatLieu + "'";
            cmd = new SqlCommand(sqlXoaVatLieu, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static void SanPham(string MaSanPham)
        {
            con.Open();
            string sqlXoaSanPham = "DELETE FROM SanPham WHERE MaSanPham = '" + MaSanPham + "'";
            cmd = new SqlCommand(sqlXoaSanPham, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
