using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChinhChien.DAL_DAO;
using System.Data;

namespace ChinhChien.BUS
{
    internal class KhoBUS
    {
        KhoDAO khoDAO = new KhoDAO();
        
        public string LayTenKhoBangMaKho(string MaKho, string MaQuan)
        {
            DataTable dt = khoDAO.LayKhoBangMaKho(MaKho, MaQuan);
            return dt.Columns[0].ToString();   
        }
    }
}
