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
        private TaiKhoanVO taiKhoanVO;
        
        public TaiKhoanBUS()
        {
            taiKhoanDAO = new TaiKhoanDAO();
        }
        
        public void ThemTaiKhoan(TaiKhoanVO taiKhoanVO)
        {
            taiKhoanDAO.Create(taiKhoanVO);
        }
    }
}
