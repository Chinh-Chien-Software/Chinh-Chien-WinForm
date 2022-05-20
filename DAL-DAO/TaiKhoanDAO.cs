using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ChinChin.Classes;

namespace ChinChin.DAL_DAO
{
    public class TaiKhoanDAO
    {
        // Database Access Layer - làm việc trực tiếp với Database
        private dbConnection conn;

        public TaiKhoanDAO() {
            conn = new dbConnection();
        }

        public bool DangNhap(string tenDangNhap, string matKhau)
        {
            return true;
        }
        
        public void Create(TaiKhoanVO taiKhoanVO)
        {
            string sql = "INSERT INTO TaiKhoan(TenTaiKhoan, MatKhau, UIMode, Email) VALUES(@TenTaiKhoan, @MatKhau, @UIMode, @Email)";
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@TenTaiKhoan", taiKhoanVO.TenTaiKhoan);
            param[1] = new SqlParameter("@MatKhau", taiKhoanVO.MatKhau);
            param[2] = new SqlParameter("@UIMode", taiKhoanVO.UIMode);
            param[3] = new SqlParameter("@Email", taiKhoanVO.Email);
            conn.executeInsertQuery(sql, param);
        }
    }
}
