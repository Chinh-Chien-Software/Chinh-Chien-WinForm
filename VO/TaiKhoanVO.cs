using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinChin.Classes
{
    public class TaiKhoanVO
    {
        // Dùng để chứa data của đối tượng
        string tentaikhoan;
        string matkhau;
        string uimode;
        string email;

        public string TenTaiKhoan
        {
            get { return tentaikhoan; }
            set { tentaikhoan = value; }
        }

        public string MatKhau
        {
            get { return matkhau; }
            set { matkhau = value; }
        }

        public string UIMode
        {
            get { return uimode; }
            set { uimode = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
    }
}
