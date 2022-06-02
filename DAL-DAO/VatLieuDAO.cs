using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ChinhChien.DAL_DAO
{
    internal class VatLieuDAO
    {
        private dbConnection conn;

        public VatLieuDAO()
        {
            conn = new dbConnection();
        }

        public void Them(
            string MaVatLieu,
            string TenVatLieu,
            string NhaCungCap,
            int SoLuong,
            float Gia,
            string DonViTinh,
            string MaQuan,
            string MaKho)
        {
            string sql = "INSERT INTO VatLieu VALUES(@MaVatLieu, @TenVatLieu, @NhaCungCap, @SoLuong, @Gia, @DonViTinh, @MaQuan, @MaKho)";
            SqlParameter[] parameters = new SqlParameter[8];
            parameters[0] = new SqlParameter("@MaVatLieu", MaVatLieu);
            parameters[1] = new SqlParameter("@TenVatLieu", TenVatLieu);
            parameters[2] = new SqlParameter("@NhaCungCap", NhaCungCap);
            parameters[3] = new SqlParameter("@SoLuong", SoLuong);
            parameters[4] = new SqlParameter("@Gia", Gia);
            parameters[5] = new SqlParameter("@DonViTinh", DonViTinh);
            parameters[6] = new SqlParameter("@MaQuan", MaQuan);
            parameters[7] = new SqlParameter("@MaKho", MaKho);
            conn.executeInsertQuery(sql, parameters);
        }

        public void CapNhat(
            string MaVatLieu,
            string TenVatLieu,
            string NhaCungCap,
            int SoLuong,
            float Gia,
            string DonViTinh,
            string MaQuan,
            string MaKho)
        {
            string sql = "update VatLieu set TenVatLieu = @TenVatLieu, NhaCungCap = @NhaCungCap, SoLuong = @SoLuong, Gia = @Gia, DonViTinh = @DonViTinh, MaQuan = @MaQuan, MaKho = @MaKho where MaVatLieu = @MaVatLieu";
            SqlParameter[] parameters = new SqlParameter[8];
            parameters[0] = new SqlParameter("@MaVatLieu", MaVatLieu);
            parameters[1] = new SqlParameter("@TenVatLieu", TenVatLieu);
            parameters[2] = new SqlParameter("@NhaCungCap", NhaCungCap);
            parameters[3] = new SqlParameter("@SoLuong", SoLuong);
            parameters[4] = new SqlParameter("@Gia", Gia);
            parameters[5] = new SqlParameter("@DonViTinh", DonViTinh);
            parameters[6] = new SqlParameter("@MaQuan", MaQuan);
            parameters[7] = new SqlParameter("@MaKho", MaKho);
            conn.executeUpdateQuery(sql, parameters);
        }
    }
}
