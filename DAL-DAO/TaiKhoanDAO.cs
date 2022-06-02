using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ChinhChien.Classes;

namespace ChinhChien.DAL_DAO
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
        
        public DataTable getAccount(string TenTaiKhoan)
        {
            string sql = "EXEC GetAccount @TenTaiKhoan";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@TenTaiKhoan", TenTaiKhoan);
            DataTable account = conn.executeSelectQuery(sql, param);
            return account;
        }
        public bool ThemTaiKhoanDAO(string TenTaiKhoan, string MatKhau, int UIMode, string Email)
        {
            string sql = "EXEC CreateAccount @TenTaiKhoan, @MatKhau, @UIMode, @Email";
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@TenTaiKhoan", TenTaiKhoan);
            param[1] = new SqlParameter("@MatKhau", MatKhau);
            param[2] = new SqlParameter("@UIMode", UIMode);
            param[3] = new SqlParameter("@Email",  Email);
            bool data = conn.executeInsertQuery(sql, param);

            return data;
        }

        public bool GoTaiKhoan(string MaNhanVien)
        {
            string sql = "UPDATE NhanVien set TenTaiKhoan = null WHERE MaNhanVien = @MaNhanVien";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@MaNhanVien", MaNhanVien);
            return conn.executeUpdateQuery(sql,param);
        }
        public bool SuaTaiKhoanDAO(string TenTaiKhoan, string MatKhau, int UIMode, string Email)
        {
            string sql = "EXEC UpdateAccount @TenTaiKhoan, @MatKhau, @UIMode, @Email";
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@TenTaiKhoan", TenTaiKhoan);
            param[1] = new SqlParameter("@MatKhau", MatKhau);
            param[2] = new SqlParameter("@UIMode", UIMode);
            param[3] = new SqlParameter("@Email", Email);
            bool data = conn.executeInsertQuery(sql, param);

            return data;
        }

        public bool XoaTaiKhoanDAO(string TenTaiKhoan)
        {
            string sql = "EXEC DeleteAccount @TenTaiKhoan";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@TenTaiKhoan", TenTaiKhoan);
            bool data = conn.executeInsertQuery(sql, param);

            return data;
        }
      
        public void ThemTaiKhoanDAO(TaiKhoanVO taiKhoanVO)
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
