using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChinChin.Database;

namespace ChinChin.Forms_QuanLy
{
    public partial class KhoHang : Form
    {
        static string sqlVL = "SELECT * FROM VatLieu";

        public KhoHang()
        {
            InitializeComponent();
        }

        private void KhoHang_Load(object sender, EventArgs e)
        {
            dgvVatLieu.DataSource = DataProvider.ReturnDataTable(sqlVL);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ChinChin.GUI.formThem.ThemVatLieu ThemVatLieu = new ChinChin.GUI.formThem.ThemVatLieu();
            ThemVatLieu.Show();
        }

        private void ibtbRefresh_Click(object sender, EventArgs e)
        {
            dgvVatLieu.DataSource = DataProvider.ReturnDataTable(sqlVL);
        }
    }
}
