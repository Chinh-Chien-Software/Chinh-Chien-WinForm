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
    }
}
