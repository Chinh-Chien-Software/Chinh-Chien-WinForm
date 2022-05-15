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
            RefreshDGV();
        }

        public void ibtbRefresh_Click(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = DataProvider.ReturnDataTable("SELECT * FROM NhanVien");
        }

        public void RefreshDGV()
        {
            var fMainUI = (ChinChin.UI.MainUI)this.Owner;
            
            dgvNhanVien.DataSource
                = DataProvider.ReturnDataTable("SELECT * FROM NhanVien where MaQuan = '"+ fMainUI.MaQuan + "'");
            
            dgvNhanVien.Columns[0].HeaderText = "Mã Nhân Viên";
            //dgvNhanVien.Columns[0].DisplayIndex = 1;
            dgvNhanVien.Columns[0].FillWeight = 60;
            
            dgvNhanVien.Columns[1].HeaderText = "Tên Nhân Viên";
            dgvNhanVien.Columns[1].FillWeight = 60;
            //dgvNhanVien.Columns[1].DisplayIndex = 0;
            
            dgvNhanVien.Columns[2].HeaderText = "Lương trên giờ";
            dgvNhanVien.Columns[2].FillWeight = 60;
            
            dgvNhanVien.Columns[3].HeaderText = "Ngày vào làm";
            dgvNhanVien.Columns[3].FillWeight = 60;
            
            dgvNhanVien.Columns[4].HeaderText = "Giới tính";
            
            dgvNhanVien.Columns[5].HeaderText = "Ngày sinh";
            
            dgvNhanVien.Columns[6].HeaderText = "Số điện thoại";
            
            dgvNhanVien.Columns[7].HeaderText = "Địa chỉ";
            
            dgvNhanVien.Columns[8].HeaderText = "Loại nhân viên";
            
            dgvNhanVien.Columns[9].Visible = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            formThem.ThemCapnhatNhanVien ThemCapnhatNhanVien = new formThem.ThemCapnhatNhanVien();
            ThemCapnhatNhanVien.Owner = this;
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
            ThemCapnhatNhanVien.Owner = this;
            ThemCapnhatNhanVien.Show();
        }
    }
}
