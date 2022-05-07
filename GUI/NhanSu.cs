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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string MaNhanVien = dgvNhanVien.SelectedRows[0].Cells[0].Value.ToString();
            string TenNhanVien = dgvNhanVien.SelectedRows[0].Cells[1].Value.ToString();
            int LuongTrenGio = int.Parse(dgvNhanVien.SelectedRows[0].Cells[2].Value.ToString());
            DateTime NgayVaoLam = DateTime.Parse(dgvNhanVien.SelectedRows[0].Cells[3].Value.ToString());
            string GioiTinh = dgvNhanVien.SelectedRows[0].Cells[4].Value.ToString();
            DateTime NgaySinh = DateTime.Parse(dgvNhanVien.SelectedRows[0].Cells[5].Value.ToString());
            string SoDienThoai = dgvNhanVien.SelectedRows[0].Cells[6].Value.ToString();
            string DiaChi = dgvNhanVien.SelectedRows[0].Cells[7].Value.ToString();
            string LoaiNhanVien = dgvNhanVien.SelectedRows[0].Cells[8].Value.ToString();

            formThem.ThemCapnhatNhanVien ThemCapnhatNhanVien
                = new formThem.ThemCapnhatNhanVien(
                    MaNhanVien, TenNhanVien, LuongTrenGio, NgayVaoLam,
                    GioiTinh, NgaySinh, SoDienThoai, DiaChi, LoaiNhanVien
                    );
            ThemCapnhatNhanVien.Show();
        }
    }
}
