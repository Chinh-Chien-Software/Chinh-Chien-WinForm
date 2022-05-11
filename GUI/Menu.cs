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
    public partial class Menu : Form
    {
        string sql = "SELECT * FROM SanPham";

        public Menu()
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
            ThemCapnhatSanPham.Owner = this;
            ThemCapnhatSanPham.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ChinChin.GUI.formThem.ThemCapnhatSanPham ThemCapnhatSanPham
                = new ChinChin.GUI.formThem.ThemCapnhatSanPham(
                    dgvSanPham.CurrentRow.Cells["MaSanPham"].Value.ToString(),
                    dgvSanPham.CurrentRow.Cells["TenSanPham"].Value.ToString(),
                    dgvSanPham.CurrentRow.Cells["CongThuc"].Value.ToString(),
                    dgvSanPham.CurrentRow.Cells["ThanhPhan"].Value.ToString(),
                    float.Parse(dgvSanPham.CurrentRow.Cells["Gia"].Value.ToString()),
                    int.Parse(dgvSanPham.CurrentRow.Cells["DanhGia"].Value.ToString())
                    );
            ThemCapnhatSanPham.Owner = this;
            ThemCapnhatSanPham.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string MaSanPham = dgvSanPham.SelectedRows[0].Cells[0].Value.ToString();
            XoaDAL.SanPham(MaSanPham);
            RefreshDGV();
        }

        public void RefreshDGV()
        {
            dgvSanPham.DataSource = DataProvider.ReturnDataTable(sql);
        }
    }
}
