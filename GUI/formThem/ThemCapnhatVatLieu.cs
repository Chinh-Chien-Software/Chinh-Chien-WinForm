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
    public partial class ThemCapnhatVatLieu : Form
    {
        int ChucNang;
        public ThemCapnhatVatLieu()
        {
            InitializeComponent();
            btnLuuCapnhat.Text = "Lưu";
            ChucNang = 0;
            lblThongBao.Visible = false;
        }
        public string MaQuan
        {
            get;
            set;
        }
        
        public ThemCapnhatVatLieu(
            string MaVatLieu,
            string TenVatLieu,
            string NhaCungCap,
            int SoLuong,
            float Gia,
            string DonViTinh
            )
        {
            InitializeComponent();
            btnLuuCapnhat.Text = "Cập nhật";
            tbcMaVL.Text = MaVatLieu;
            tbcTenVL.Text = TenVatLieu;
            tbcNhaCC.Text = NhaCungCap;
            tbcSL.Text = SoLuong.ToString();
            tbcGia.Text = Gia.ToString();
            tbcDVT.Text = DonViTinh;
            ChucNang = 1;
        }

        private void ThemVatLieu_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            var f = (ChinChin.Forms_QuanLy.KhoHang)this.Owner;
            if (ChucNang == 0)
            {
                if (tbcMaVL.Text == ""
                    || tbcTenVL.Text == ""
                    || tbcNhaCC.Text == ""
                    || tbcSL.Text == ""
                    || tbcGia.Text == ""
                    || tbcDVT.Text == "")
                {
                    lblThongBao.Visible = true;
                    lblThongBao.Text = "Vui lòng nhập đầy đủ thông tin";
                }
                else if(
                    tbcMaVL.Text.Length > 4
                    || tbcTenVL.Text.Length > 30
                    || tbcNhaCC.Text.Length > 30
                    )
                {
                    lblThongBao.Visible = true;
                    lblThongBao.Text = "Số lượng từ quá lớn";
                }
                else
                {
                    ThemDAL.VatLieu(tbcMaVL.Text, tbcTenVL.Text, tbcNhaCC.Text,
                    Convert.ToInt32(tbcSL.Text), float.Parse(tbcGia.Text), tbcDVT.Text, "quanchinhchien");
                    f.RefreshDGV();
                    this.Close();
                }
            }
            else if (ChucNang == 1)
            {
                CapNhatDAL.VatLieu(tbcMaVL.Text, tbcTenVL.Text, tbcNhaCC.Text,
                    Convert.ToInt32(tbcSL.Text), float.Parse(tbcGia.Text), tbcDVT.Text, "quanchinhchien");
                f.RefreshDGV();
                this.Close();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

        }
    }
}
