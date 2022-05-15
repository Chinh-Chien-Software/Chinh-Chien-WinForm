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

        public ThemCapnhatVatLieu(
            string MaVatLieu,
            string TenVatLieu,
            string NhaCungCap,
            int SoLuong,
            float Gia,
            string DonViTinh,
            string MaQuan,
            string MaKho
            )
        {
            InitializeComponent();
            tbcMaVL.Enabled = false;
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
            lblThongBao.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            var fKhoHang = (ChinChin.Forms_QuanLy.KhoHang)this.Owner;
            if (ChucNang == 0)
            {
                if (KiemTra())
                {
                    ThemDAL.VatLieu(tbcMaVL.Text, tbcTenVL.Text, tbcNhaCC.Text,
                    Convert.ToInt32(tbcSL.Text), float.Parse(tbcGia.Text), tbcDVT.Text, "quanchinhchien");
                    fKhoHang.RefreshDGV();
                    this.Close();
                }
            }
            else if (ChucNang == 1)
            {
                if (KiemTra())
                {
                    CapNhatDAL.VatLieu(tbcMaVL.Text, tbcTenVL.Text, tbcNhaCC.Text,
                    Convert.ToInt32(tbcSL.Text), float.Parse(tbcGia.Text), tbcDVT.Text, "quanchinhchien");
                    fKhoHang.RefreshDGV();
                    this.Close();
                }
            }
        }

        bool KiemTra()
        {
            if (tbcMaVL.Text == "")
            {
                lblThongBao.Text = "Mã vật liệu không được để trống";
                lblThongBao.Visible = true;
                return false;
            }
            else if (tbcTenVL.Text == "")
            {
                lblThongBao.Text = "Tên vật liệu không được để trống";
                lblThongBao.Visible = true;
                return false;
            }
            else if(tbcNhaCC.Text == "")
            {
                lblThongBao.Text = "Nhà cung cấp không được để trống";
                lblThongBao.Visible = true;
                return false;
            }
            else if(tbcSL.Text == "")
            {
                lblThongBao.Text = "Số lượng không được để trống";
                lblThongBao.Visible = true;
                return false;
            }
            else if(tbcGia.Text == "")
            {
                lblThongBao.Text = "Giá không được để trống";
                lblThongBao.Visible = true;
                return false;
            }
            else if(tbcDVT.Text == "")
            {
                lblThongBao.Text = "Đơn vị tính không được để trống";
                lblThongBao.Visible = true;
                return false;
            }
            else if(cbbKho.Text == "")
            {
                lblThongBao.Text = "Kho không được để trống";
                lblThongBao.Visible = true;
                return false;
            }
            else if (tbcMaVL.Text.Length > 4)
            {
                lblThongBao.Visible = true;
                lblThongBao.Text = "Mã vật liệu quá dài";
                return false;
            }
            else if( tbcTenVL.Text.Length > 30)
            {
                lblThongBao.Visible = true;
                lblThongBao.Text = "Tên vật liệu quá dài";
                return false;
            }
            else if (tbcNhaCC.Text.Length > 30)
            {
                lblThongBao.Visible = true;
                lblThongBao.Text = "Tên nhà cung cấp quá dài";
                return false;
            }
            else
            {
                return true;
            }
        }
        
        private void btnHuy_Click(object sender, EventArgs e)
        {

        }
    }
}
