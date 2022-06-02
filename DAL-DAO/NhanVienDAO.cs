using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChinhChien.Classes;

namespace ChinhChien.DAL_DAO
{
    internal class NhanVienDAO
    {
        private dbConnection conn;

        public NhanVienDAO()
        {
            conn = new dbConnection();
        }


        public DataTable getNhanVien(string MaQuan)
        {
            string sql = "EXEC GetListEmployeeByShopId @MaQuan";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@MaQuan", MaQuan);
            DataTable account = conn.executeSelectQuery(sql, param);
            return account;
        }
        public bool ThemNhanVienDAO(string MaNhanVien,
            string TenNhanVien,
            int LuongTrenGio,
            DateTime NgayVaoLam,
            string GioiTinh,
            DateTime NgaySinh,
            string SoDienThoai,
            string DiaChi,
            string LoaiNhanVien,
            string MaQuan)
        {
            string sql = "EXEC TaoNhanVien @MaNhanVien, @TenNhanVien, @LuongTrenGio, @NgayVaoLam, @GioiTinh, @NgaySinh, @SoDienThoai, @DiaChi , @LoaiNhanVien, @MaQuan, null";
            SqlParameter[] param = new SqlParameter[10];
            param[0] = new SqlParameter("@MaNhanVien", MaNhanVien);
            param[1] = new SqlParameter("@TenNhanVien", TenNhanVien);
            param[2] = new SqlParameter("@LuongTrenGio", LuongTrenGio);
            param[3] = new SqlParameter("@NgayVaoLam", NgayVaoLam);
            param[4] = new SqlParameter("@GioiTinh", GioiTinh);
            param[5] = new SqlParameter("@NgaySinh", NgaySinh);
            param[6] = new SqlParameter("@SoDienThoai", SoDienThoai);
            param[7] = new SqlParameter("@DiaChi", DiaChi);
            param[8] = new SqlParameter("@LoaiNhanVien", LoaiNhanVien);
            param[9] = new SqlParameter("@MaQuan", MaQuan);
            
           
            
            bool data = conn.executeInsertQuery(sql, param);

            return data;
        }

        public bool ThemTaiKhoan(string TenTaiKhoan, string MaNhanVien)
        {
            string sql = "UPDATE NHANVIEN SET TENTAIKHOAN = @TenTaiKhoan WHERE MANHANVIEN = @MaNhanVien";
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@TenTaiKhoan", TenTaiKhoan);
            param[1] = new SqlParameter("@MaNhanVien", MaNhanVien);
            

            bool data = conn.executeInsertQuery(sql, param);

            return data;
        }
        public bool SuaNhanVienDAO(string MaNhanVien,
           string TenNhanVien,
           int LuongTrenGio,
           DateTime NgayVaoLam,
           string GioiTinh,
           DateTime NgaySinh,
           string SoDienThoai,
           string DiaChi,
           string LoaiNhanVien,
           string MaQuan, string TenTaiKhoan)
        {
            string sql = "EXEC SuaNhanVien @MaNhanVien, @TenNhanVien, @LuongTrenGio, @NgayVaoLam, @GioiTinh, @NgaySinh, @SoDienThoai, @DiaChi , @LoaiNhanVien, @MaQuan, @TenTaiKhoan";
            SqlParameter[] param = new SqlParameter[11];
            param[0] = new SqlParameter("@MaNhanVien", MaNhanVien);
            param[1] = new SqlParameter("@TenNhanVien", TenNhanVien);
            param[2] = new SqlParameter("@LuongTrenGio", LuongTrenGio);
            param[3] = new SqlParameter("@NgayVaoLam", NgayVaoLam);
            param[4] = new SqlParameter("@GioiTinh", GioiTinh);
            param[5] = new SqlParameter("@NgaySinh", NgaySinh);
            param[6] = new SqlParameter("@SoDienThoai", SoDienThoai);
            param[7] = new SqlParameter("@DiaChi", DiaChi);
            param[8] = new SqlParameter("@LoaiNhanVien", LoaiNhanVien);
            param[9] = new SqlParameter("@MaQuan", MaQuan);
            if (TenTaiKhoan == "")
            {
                param[10] = new SqlParameter("@TenTaiKhoan", DBNull.Value);
            }
            else
            {
                param[10] = new SqlParameter("@TenTaiKhoan", TenTaiKhoan);
            }
            bool data = conn.executeInsertQuery(sql, param);

            return data;
        }

        public bool XoaNhanVienDAO(string MaNhanVien)
        {
            string sql = "EXEC XoaNhanVien @MaNhanVien";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@MaNhanVien", MaNhanVien);
            bool data = conn.executeInsertQuery(sql, param);

            return data;
        }
    }
}
