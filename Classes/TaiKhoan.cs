using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinChin.Classes
{
    internal class TaiKhoan
    {
        public string tentaikhoan;
        public string TenTaiKhoan
        {
            get { return tentaikhoan; }
            set { tentaikhoan = value; }
        }

        string loaitaikhoan;
        string LoaiTaiKhoan
        {
            set { loaitaikhoan = value; }
            get { return loaitaikhoan; }
        }
        string MaNhanVien;
        int UIMode;
    }
}
