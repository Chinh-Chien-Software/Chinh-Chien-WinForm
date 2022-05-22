using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChinChin.DAL_DAO;

namespace ChinChin.BUS
{
    internal class VatLieuBUS
    {
        private VatLieuDAO vatLieuDAO;

        public VatLieuBUS()
        {
            vatLieuDAO = new VatLieuDAO();
        }

        public void Them(string MaVatLieu,
            string TenVatLieu,
            string NhaCungCap,
            int SoLuong,
            float Gia,
            string DonViTinh,
            string MaQuan,
            string MaKho)
        {
            vatLieuDAO.Them(MaVatLieu, TenVatLieu, NhaCungCap, SoLuong, Gia, DonViTinh, MaQuan, MaKho);
        }
    }
}
