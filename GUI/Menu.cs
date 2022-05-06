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

namespace ChinChin.Forms_ChuQuan
{
    public partial class FormThucDon : Form
    {
        public FormThucDon()
        {
            InitializeComponent();
        }

        private void FormThucDon_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM SanPham";
            dgvSanPham.DataSource = DataProvider.ReturnDataTable(sql);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {

        }
    }
}
