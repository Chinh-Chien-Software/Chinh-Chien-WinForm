using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ChinChin.DAL_DAO
{
    internal class ThanhPhanSanPham
    {
        private dbConnection conn;

        public ThanhPhanSanPham()
        {
            conn = new dbConnection();
        }

        public DataTable LayThanhPhanSanPham(string MaSanPham)
        {
            return DataProvider.ReturnDataTable
                ("SELECT * FROM ThanhPhanSanPham where MaSanPham = '"+ MaSanPham + "'");
        }
    }
}
