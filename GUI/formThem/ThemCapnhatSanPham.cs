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

namespace ChinChin.GUI.formThem
{
    public partial class ThemCapnhatSanPham : Form
    {
        int ChucNang;
        string Loai;
        
        public ThemCapnhatSanPham()
        {
            InitializeComponent();
            btnLuu.Text = "Lưu";
            ChucNang = 0;
        }
        public ThemCapnhatSanPham(
            string MaSanPham,
            string TenSanPham,
            string CongThuc,
            string ThanhPhan,
            float Gia,
            int DanhGia
            )
        {
            InitializeComponent();
            lblThongBao.Visible = false;
            btnLuu.Text = "Cập nhật";
            tbcMaSP.Text = MaSanPham;
            tbcTenSP.Text = TenSanPham;
            tbcCT.Text = CongThuc;
            tbcTPhan.Text = ThanhPhan;
            tbcGia.Text = Gia.ToString();
            tbcDanhGia.Text = DanhGia.ToString();
            ChucNang = 1;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (KiemTra())
            {
                var fMenu = (ChinChin.Forms_ChuQuan.QuanLyMenu)this.Owner;
                if (ChucNang == 0)
                {
                    ChonLoai();
                    ThemDAL.SanPham
                        (tbcMaSP.Text, tbcTenSP.Text, tbcCT.Text, tbcTPhan.Text,
                        float.Parse(tbcGia.Text), int.Parse(tbcDanhGia.Text), Loai, "quanchinhchien");
                    fMenu.RefreshDGV();
                    this.Close();
                }
                else if (ChucNang == 1)
                {
                    btnLuu.Text = "Cập nhật";
                    CapNhatDAL.SanPham
                        (tbcMaSP.Text, tbcTenSP.Text, tbcCT.Text, tbcTPhan.Text,
                        float.Parse(tbcGia.Text), int.Parse(tbcDanhGia.Text), Loai, "quanchinhchien");
                    fMenu.RefreshDGV();
                    this.Close();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        string ChonLoai()
        {
            if (cbbLoai.Text == "Trà sữa")
            {
                Loai = "trasua";
            }
            else if (cbbLoai.Text == "Cà phê")
            {
                Loai = "caphe";
            }
            else
            {
                Loai = "";
            }
            return Loai;
        }

        bool KiemTra() // Kiểm tra xem đã điền đủ thông tin chưa
        {
            bool KetQua = true;
            if (tbcMaSP.Text == "")
            {
                lblThongBao.Visible = true;
                MessageBox.Show("Mã sản phẩm không được để trống");
                KetQua = false;
            }
            else if (tbcTenSP.Text == "")
            {
                lblThongBao.Visible = true;
                MessageBox.Show("Tên sản phẩm không được để trống");
                KetQua = false;
            }
            else if (tbcCT.Text == "")
            {
                lblThongBao.Visible = true;
                MessageBox.Show("Công thức không được để trống");
                KetQua = false;
            }
            else if (tbcTPhan.Text == "")
            {
                lblThongBao.Visible = true;
                MessageBox.Show("Thành phần không được để trống");
                KetQua = false;
            }
            else if (tbcGia.Text == "")
            {
                lblThongBao.Visible = true;
                MessageBox.Show("Giá không được để trống");
                KetQua = false;
            }
            else if (cbbLoai.Text == "")
            {
                lblThongBao.Visible = true;
                MessageBox.Show("Loại không được để trống");
                KetQua = false;
            }
            return KetQua;
        }
    }
}
