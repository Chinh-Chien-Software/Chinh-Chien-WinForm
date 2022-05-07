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

namespace ChinChin.GUI
{
    public partial class NhanSu : Form
    {
        public NhanSu()
        {
            InitializeComponent();
        }

        private void NhanSu_Load(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = DataProvider.ReturnDataTable("SELECT * FROM NhanVien");
        }

        private void ibtbRefresh_Click(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = DataProvider.ReturnDataTable("SELECT * FROM NhanVien");
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            formThem.ThemCapnhatNhanVien ThemCapnhatNhanVien = new formThem.ThemCapnhatNhanVien();
            ThemCapnhatNhanVien.Show();
        }
    }
}
