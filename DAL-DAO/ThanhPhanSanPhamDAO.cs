using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ChinChin.DAL_DAO
{
    internal class ThanhPhanSanPhamDAO
    {
        private dbConnection conn;

        public ThanhPhanSanPhamDAO()
        {
            conn = new dbConnection();
        }

        public DataTable LayThanhPhanSanPham(string MaSanPham)
        {
            return DataProvider.ReturnDataTable
                ("SELECT * FROM ThanhPhanSanPham where MaSanPham = '" + MaSanPham + "'");
        }

        void Them(string MaSanPham, string MaVatLieu, int SoLuong)
        {
            string sql = "INSERT INTO ThanhPhanSanPham(MaSanPham, MaVatLieu, SoLuong) VALUES(@MaSanPham, @MaVatLieu, @SoLuong)";
            SqlParameter[] para = new SqlParameter[3];
            para[0] = new SqlParameter("@MaSanPham", MaSanPham);
            para[1] = new SqlParameter("@MaVatLieu", MaVatLieu);
            para[2] = new SqlParameter("@SoLuong", SoLuong);
            conn.executeInsertQuery(sql, para);
        }
    }
}
