using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ChinhChien.DAL_DAO
{
    internal class KhoDAO
    {
        public DataTable LayDanhSachKho(string MaQuan)
        {
            string sql = "select * from Kho where MaQuan = '"+MaQuan+"'";
            DataTable dt = DataProvider.ReturnDataTable(sql);
            return dt;
        }

        public DataTable LayKhoBangMaKho (string MaKho, string MaQuan)
        {
            return DataProvider.ReturnDataTable("select TenKho from Kho where MaQuan = '" + MaQuan +
                "' and MaKho = '" + MaKho + "'");
        }
    }
}
