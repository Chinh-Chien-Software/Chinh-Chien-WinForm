using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ChinChin.DAL_DAO
{
    internal class KhoDAO
    {
        public DataTable LayKho(string MaQuan)
        {
            string sql = "select * from Kho where MaQuan = '"+MaQuan+"'";
            DataTable dt = DataProvider.ReturnDataTable(sql);
            return dt;
        }
    }
}
