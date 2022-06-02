using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ChinhChien.DAL_DAO
{
    internal class SanPhamDAO
    {
        private dbConnection conn;

        public SanPhamDAO()
        {
            conn = new dbConnection();
        }

        public void Update(
            string MaSanPham,
            string TenSanPham,
            string CongThuc,
            string ThanhPhan,
            float Gia,
            int DanhGia,
            string Loai
            )
        {
            string sql = "UPDATE SanPham SET TenSanPham = @TenSanPham, CongThuc = @CongThuc, ThanhPhan = @ThanhPhan, Gia = @Gia, DanhGia = @DanhGia, Loai = @Loai WHERE MaSanPham = @MaSanPham";
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@MaSanPham", MaSanPham);
            param[1] = new SqlParameter("@TenSanPham", TenSanPham);
            param[2] = new SqlParameter("@CongThuc", CongThuc);
            param[3] = new SqlParameter("@ThanhPhan", ThanhPhan);
            param[4] = new SqlParameter("@Gia", Gia);
            param[5] = new SqlParameter("@DanhGia", DanhGia);
            param[6] = new SqlParameter("@Loai", Loai);
            conn.executeUpdateQuery(sql, param);
        }

        public void Create(
            string MaSanPham,
            string TenSanPham,
            string CongThuc,
            string ThanhPhan,
            float Gia,
            int DanhGia,
            string Loai,
            string MaQuan)
        {
            string sql = "INSERT INTO SanPham values (@MaSanPham, @TenSanPham, @CongThuc, @ThanhPhan, @DanhGia, @Gia,  @Loai, @MaQuan)";
            SqlParameter[] param= new SqlParameter[8];
            param[0] = new SqlParameter("@MaSanPham", MaSanPham);
            param[1] = new SqlParameter("@TenSanPham", TenSanPham);
            param[2] = new SqlParameter("@CongThuc", CongThuc);
            param[3] = new SqlParameter("@ThanhPhan", ThanhPhan);
            param[4] = new SqlParameter("@Gia", Gia);
            param[5] = new SqlParameter("@DanhGia", DanhGia);
            param[6] = new SqlParameter("@Loai", Loai);
            param[7] = new SqlParameter("@MaQuan", MaQuan);
            
            conn.executeInsertQuery(sql, param);
        }
    }
}
