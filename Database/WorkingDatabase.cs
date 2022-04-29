using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ChinChin.Database
{
    public class WorkingDatabase
    {
        static string connString = Properties.Settings.Default.ChinhChienConnectionString;
        static SqlConnection con = new SqlConnection(connString);
        static SqlCommand cmd;

        public static bool CheckLocalDatabase()
        {
            // Tìm thử xem có tài khoản nào chuquan nào không..
            var sql = "select count(*) from TaiKhoan where LoaiTaiKhoan='chuquan' ";

            con.Open();
            cmd = new SqlCommand(sql, con);
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();

            return (i > 0);
        }
        public static void CreateLocalDatabase()
        {
        }

        public static void CreateAccount(string TenTaiKhoan, string MatKhau, string LoaiTaiKhoan, int UIMode)
        {
            con.Open();
            string sqlCreateAccount = "EXEC CreateAccount '"+ TenTaiKhoan +"', '"+ MatKhau +"', '" + LoaiTaiKhoan +"', '"+ UIMode +"'";
            cmd = new SqlCommand(sqlCreateAccount, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
