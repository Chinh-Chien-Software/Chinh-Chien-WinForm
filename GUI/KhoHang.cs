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
        public KhoHang()
        {
            InitializeComponent();
        }

        private void KhoHang_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM VatLieu";
            //DataTable dtVatLieu = DataProvider.LoadDataTable(sql);
            dgvVatLieu.DataSource = DataProvider.LoadDataTable(sql);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ChinChin.GUI.formThem.ThemVatLieu ThemVatLieu = new ChinChin.GUI.formThem.ThemVatLieu();
            ThemVatLieu.Show();
        }
    }
}
