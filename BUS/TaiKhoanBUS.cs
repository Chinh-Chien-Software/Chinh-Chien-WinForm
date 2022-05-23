using System;
using System.Collections.Generic;
using System.Data;
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
      
        public DataTable getAccountBUS(string TenTaiKhoan)
        {
            return taiKhoanDAO.getAccount(TenTaiKhoan);
        }

        public bool goTaiKhoan(string MaNhanVien)
        {
            return taiKhoanDAO.GoTaiKhoan(MaNhanVien);
        }
        public bool ThemTaiKhoanBUS(string TenTaiKhoan, string MatKhau, int UIMode, string Email)
        {
            return taiKhoanDAO.ThemTaiKhoanDAO(TenTaiKhoan,MatKhau,UIMode,Email);
        }

        public bool SuaTaiKhoanBUS(string TenTaiKhoan, string MatKhau, int UIMode, string Email)
        {
            return taiKhoanDAO.SuaTaiKhoanDAO(TenTaiKhoan, MatKhau, UIMode, Email);
        }

        public bool XoaTaiKhoanBUS(string TenTaiKhoan)
        {
            return taiKhoanDAO.XoaTaiKhoanDAO(TenTaiKhoan);
        }
        
        public void ThemTaiKhoanBUS(TaiKhoanVO taiKhoanVO)
        {
            taiKhoanDAO.ThemTaiKhoanDAO(taiKhoanVO);
        }
    }
}
