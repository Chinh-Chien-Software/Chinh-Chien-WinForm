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
        public static bool CheckLocalDatabase()
        {
            var connString = Properties.Settings.Default.ChinhChienConnectionString;
            // Tìm thử xem có tài khoản nào chuquan nào không..
            var cmdText = "select count(*) from TaiKhoan where LoaiTaiKhoan='chuquan' ";

            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd = new SqlCommand(cmdText, con);
            
            return (Convert.ToInt32(cmd.ExecuteScalar()) > 0);
        }
        public void CreateLocalDatabase()
        {

        }
    }
}
