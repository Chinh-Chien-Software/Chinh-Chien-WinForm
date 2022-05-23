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
using System.Runtime.InteropServices;
using ChinChin.BUS;

namespace ChinChin.GUI.formThem
{
    public partial class ThemCapnhatVatLieu : Form
    {
        int ChucNang;
        VatLieuBUS vatLieuBUS = new VatLieuBUS();
        VatLieuDAO vatLieuDAO = new VatLieuDAO();
        KhoDAO khoDao = new KhoDAO();
        
        public ThemCapnhatVatLieu()
        {
            InitializeComponent();
            btnLuuCapnhat.Text = "Lưu";
            lblTitle.Text = "Thêm vật liệu";
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
            lblTitle.Text = "Cập nhật vật liệu";

            tbcMaVL.Text = MaVatLieu;
            tbcMaVL.Enabled = false;

            tbcTenVL.Text = TenVatLieu;
            tbcNhaCC.Text = NhaCungCap;
            tbcSL.Text = SoLuong.ToString();
            tbcGia.Text = Gia.ToString();
            tbcDVT.Text = DonViTinh;
            ChucNang = 1;

            KhoBUS khoBus = new KhoBUS();

            cbbKho.Text = khoBus.LayTenKhoBangMaKho(MaKho, MaQuan);
        }

        private void ThemVatLieu_Load(object sender, EventArgs e)
        {
            var fKhoHang = (ChinChin.Forms_QuanLy.KhoHang)this.Owner;
            cbbKho.DataSource = khoDao.LayDanhSachKho(fKhoHang.MaQuan);
            lblThongBao.Visible = false;
            cbbKho.DisplayMember = "TenKho";
            cbbKho.ValueMember = "MaKho";
            
            //cbbKho.SelectedValue = MaKho;
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
                    vatLieuDAO.Them(tbcMaVL.Text, tbcTenVL.Text, tbcNhaCC.Text,
                    Convert.ToInt32(tbcSL.Text), float.Parse(tbcGia.Text), tbcDVT.Text, fKhoHang.MaQuan, fKhoHang.MaKho);
                    fKhoHang.RefreshVatLieu(fKhoHang.TenKho);
                    this.Close();
                }
            }
            else if (ChucNang == 1)
            {
                if (KiemTra())
                {
                    vatLieuDAO.CapNhat(tbcMaVL.Text, tbcTenVL.Text, tbcNhaCC.Text,
                    Convert.ToInt32(tbcSL.Text), float.Parse(tbcGia.Text), tbcDVT.Text, fKhoHang.MaQuan, (string)cbbKho.SelectedValue);
                    fKhoHang.RefreshVatLieu(fKhoHang.TenKho);
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

        [DllImport("user32")]
        private static extern bool ReleaseCapture();
        [DllImport("user32")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wp, int lp);

        private void pnlMoveAndTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void lblTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
