using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ChinhChien.DAL_DAO
{
    internal class HoaDonDAO
    {
        private dbConnection conn;

        public HoaDonDAO()
        {
            conn = new dbConnection();
        }

        public bool addHoaDon(string MaHoaDon, string MaNhanVien, DateTime ThoiGianGiaoDich)
        {
            string query = "INSERT INTO HoaDon VALUES(@maHoaDon, @maNhanVien, @ngayLap)";
            SqlParameter[] parameters = new SqlParameter[3];
            parameters[0] = new SqlParameter("@maHoaDon", SqlDbType.VarChar, 10);
            parameters[0].Value = MaHoaDon;
            parameters[1] = new SqlParameter("@maNhanVien", SqlDbType.VarChar, 4);
            parameters[1].Value = MaNhanVien;
            parameters[2] = new SqlParameter("@ngayLap", SqlDbType.DateTime);
            parameters[2].Value = ThoiGianGiaoDich;
            return conn.executeInsertQuery(query, parameters);
        }

        /// <method>
        /// Get HoaDon Email By Firstname or Lastname and return DataTable
        /// </method>
        public DataTable searchByMaNhanVien(string _MaNhanVien)
        {
            string query = string.Format("select * from HoaDon where t01_firstname like @t01_firstname or t01_lastname like @t01_lastname ");
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@t01_firstname", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(_MaNhanVien);
            sqlParameters[1] = new SqlParameter("@t01_lastname", SqlDbType.VarChar);
            sqlParameters[1].Value = Convert.ToString(_MaNhanVien);
            return conn.executeSelectQuery(query, sqlParameters);
        }

        /// <method>
        /// Get User Email By Id and return DataTable
        /// </method>
        public DataTable searchByMaHoaDon(string _MaHoaDon)
        {
            string query = "select * from HoaDon where MaHoaDon = @MaHoaDon";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@MaHoaDon", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(_MaHoaDon);
            return conn.executeSelectQuery(query, sqlParameters);
        }

        /// <method>
        /// Tìm mã hóa đơn gần đây nhất
        /// </method> 
        public int searchRecentMaHoaDon()
        {
            string query = "select top 1 MaHoaDon from HoaDon order by ThoiGianGiaoDich desc";
            string MaHoaDon = conn.executeSelectFirstCell(query).ToString();
            return int.Parse(MaHoaDon);
        }

        /// <method>
        /// Thêm chi tiết hóa đơn
        public void addChiTietHoaDon(string MaHoaDon, string MaSanPham, int SoLuong, decimal DonGia)
        {
            string query = "INSERT INTO ChiTietHoaDon VALUES(@maHoaDon, @maSanPham, @soLuong, @donGia)";
            SqlParameter[] parameters = new SqlParameter[4];
            parameters[0] = new SqlParameter("@maHoaDon", SqlDbType.VarChar, 3);
            parameters[0].Value = MaHoaDon;
            parameters[1] = new SqlParameter("@maSanPham", SqlDbType.VarChar, 10);
            parameters[1].Value = MaSanPham;
            parameters[2] = new SqlParameter("@soLuong", SqlDbType.Int);
            parameters[2].Value = SoLuong;
            parameters[3] = new SqlParameter("@donGia", SqlDbType.Float);
            parameters[3].Value = DonGia;
            conn.executeInsertQuery(query, parameters);
        }
    }
}
