using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChinhChien.DAL_DAO;

namespace ChinhChien.Forms_ChuQuan
{
    public partial class QuanLyMenu : Form
    {
        string sql;

        public string MaQuan
        {
            get;
            set;
        }

        public QuanLyMenu()
        {
            InitializeComponent();
        }

        private void QuanLyMenu_Load(object sender, EventArgs e)
        {
            var fMainUI = (ChinhChien.UI.MainUI)this.Owner;
            this.MaQuan = fMainUI.MaQuan;
            RefreshDGV();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ChinhChien.GUI.formThem.ThemCapnhatSanPham ThemCapnhatSanPham = new ChinhChien.GUI.formThem.ThemCapnhatSanPham();
            ThemCapnhatSanPham.Owner = this;
            ThemCapnhatSanPham.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ChinhChien.GUI.formThem.ThemCapnhatSanPham ThemCapnhatSanPham
                = new ChinhChien.GUI.formThem.ThemCapnhatSanPham(
                    dgvSanPham.CurrentRow.Cells["MaSanPham"].Value.ToString(),
                    dgvSanPham.CurrentRow.Cells["TenSanPham"].Value.ToString(),
                    dgvSanPham.CurrentRow.Cells["CongThuc"].Value.ToString(),
                    dgvSanPham.CurrentRow.Cells["ThanhPhan"].Value.ToString(),
                    float.Parse(dgvSanPham.CurrentRow.Cells["Gia"].Value.ToString()),
                    int.Parse(dgvSanPham.CurrentRow.Cells["DanhGia"].Value.ToString()),
                    dgvSanPham.CurrentRow.Cells["Loai"].Value.ToString()
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
            var fMainUI = (ChinhChien.UI.MainUI)this.Owner;
            sql = "SELECT * FROM SanPham where MaQuan = '" + fMainUI.MaQuan + "'";
            dgvSanPham.DataSource = DataProvider.ReturnDataTable(sql);

            dgvSanPham.Columns["MaSanPham"].HeaderText = "Mã sản phẩm";

            dgvSanPham.Columns["TenSanPham"].HeaderText = "Tên sản phẩm";

            dgvSanPham.Columns["CongThuc"].HeaderText = "Công thức";

            dgvSanPham.Columns[3].HeaderText = "Thành phần";

            dgvSanPham.Columns[4].HeaderText = "Đánh giá";

            dgvSanPham.Columns[5].HeaderText = "Giá";

            dgvSanPham.Columns[6].HeaderText = "Loại";

            dgvSanPham.Columns[7].Visible = false;
        }
    }
}
