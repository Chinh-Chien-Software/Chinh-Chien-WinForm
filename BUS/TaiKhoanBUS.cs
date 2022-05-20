using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChinChin.Classes;
using ChinChin.DAL_DAO;

namespace ChinChin.BUS
{
    internal class TaiKhoanBUS
    {
        private TaiKhoanDAO taiKhoanDAO;
        
        public TaiKhoanBUS()
        {
            taiKhoanDAO = new TaiKhoanDAO();
        }
        
        public void ThemTaiKhoanBUS(TaiKhoanVO taiKhoanVO)
        {
            taiKhoanDAO.ThemTaiKhoanDAO(taiKhoanVO);
        }
    }
}
