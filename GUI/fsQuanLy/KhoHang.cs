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
            string sql = "SELECT * FROM KhoHang";
            DataSet dsVatLieu = DataProvider.LoadDataSet(sql);
            dgvVatLieu.DataSource = dsVatLieu.Tables[0];
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
