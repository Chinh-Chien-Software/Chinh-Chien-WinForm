using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ChinChin.DAL_DAO
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
            string Loai,
            string MaQuan
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
            string sql = "INSERT INTO SanPham(MaSanPham, TenSanPham, CongThuc, ThanhPhan, Gia, DanhGia, Loai, MaQuan) values (@MaSanPham, @TenSanPham, @CongThuc, @ThanhPhan, @Gia, @DanhGia, @Loai, @MaQuan)";
            SqlParameter[] para = new SqlParameter[8];
            para[0] = new SqlParameter("@MaSanPham", SqlDbType.VarChar, 3);
            para[0].Value = MaSanPham;
            para[1] = new SqlParameter("@TenSanPham", SqlDbType.NVarChar, 50);
            para[1].Value = TenSanPham;
            para[2] = new SqlParameter("@CongThuc", SqlDbType.NVarChar, 50);
            para[2].Value = CongThuc;
            para[3] = new SqlParameter("@ThanhPhan", SqlDbType.NVarChar, 50);
            para[3].Value = ThanhPhan;
            para[4] = new SqlParameter("@Gia", SqlDbType.Float);
            para[4].Value = Gia;
            para[5] = new SqlParameter("@DanhGia", SqlDbType.Int);
            para[5].Value = DanhGia;
            para[6] = new SqlParameter("@Loai", SqlDbType.NVarChar, 50);
            para[6].Value = Loai;
            para[7] = new SqlParameter("@MaQuan", SqlDbType.NVarChar, 50);
            para[7].Value = MaQuan;
            conn.executeInsertQuery(sql, para);
        }
    }
}
