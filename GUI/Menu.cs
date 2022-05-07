using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChinChin.DAL_DAO;

namespace ChinChin.Forms_ChuQuan
{
    public partial class FormThucDon : Form
    {
        string sql = "SELECT * FROM SanPham";

        public FormThucDon()
        {
            InitializeComponent();
        }

        private void FormThucDon_Load(object sender, EventArgs e)
        {
            dgvSanPham.DataSource = DataProvider.ReturnDataTable(sql);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ChinChin.GUI.formThem.ThemCapnhatSanPham ThemCapnhatSanPham = new ChinChin.GUI.formThem.ThemCapnhatSanPham();
            ThemCapnhatSanPham.Show();
        }

        private void ibtbRefresh_Click(object sender, EventArgs e)
        {
            dgvSanPham.DataSource = DataProvider.ReturnDataTable(sql);
        }
    }
}
