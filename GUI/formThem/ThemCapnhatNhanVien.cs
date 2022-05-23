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
    public partial class ThemCapnhatNhanVien : Form
    {
        int ChucNang;
        string TaiKhoan;
        
        public ThemCapnhatNhanVien()
        {
            InitializeComponent();
            ChucNang = 0;
        }

        public ThemCapnhatNhanVien(
            string MaNhanVien,
            string TenNhanVien,
            int LuongTrenGio,
            DateTime NgayVaoLam,
            string GioiTinh,
            DateTime NgaySinh,
            string SoDienThoai,
            string DiaChi,
            string LoaiNhanVien,
            string TaiKhoan
            )
        {
            InitializeComponent();
            ChucNang = 1;
            tbcMaNV.Enabled = false;
            tbcMaNV.Text = MaNhanVien;
            tbcTenNV.Text = TenNhanVien;
            tbcLuong.Text = LuongTrenGio.ToString();
            dtpNgayVL.Value = NgayVaoLam;
            cbbGioiTinh.Text = GioiTinh;
            dtpNgaySinh.Value = NgaySinh;
            tbcSDT.Text = SoDienThoai;
            tbcDC.Text = DiaChi;
            cbbChucVu.Text = LoaiNhanVien;
            this.TaiKhoan = TaiKhoan;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            var f = (NhanSu)this.Owner;
            NhanVienBUS nvBus = new NhanVienBUS();
            try
            {
                if (ChucNang == 0)
                {
                    if (KiemTra())
                    {
                        nvBus.ThemNhanVienBUS
                         (tbcMaNV.Text, tbcTenNV.Text, int.Parse(tbcLuong.Text), dtpNgayVL.Value,
                         cbbGioiTinh.Text, dtpNgaySinh.Value, tbcSDT.Text, tbcDC.Text, cbbChucVu.Text, f.MaQuan, TaiKhoan);

                        f.RefreshDGV();
                        this.Close();
                    }
                }
                else if (ChucNang == 1)
                {
                    if (KiemTra())
                    {
                        btnLuu.Text = "Cập nhật";
                        nvBus.SuaNhanVienBUS
                            (tbcMaNV.Text, tbcTenNV.Text, int.Parse(tbcLuong.Text), dtpNgayVL.Value,
                            cbbGioiTinh.Text, dtpNgaySinh.Value, tbcSDT.Text, tbcDC.Text, cbbChucVu.Text, f.MaQuan, TaiKhoan);
                        f.RefreshDGV();
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: "+ex.Message);
            }
           
        }

        bool KiemTra()
        {
            if (tbcMaNV.Text == "")
            {
                lblThongBao.Visible = true;
                lblThongBao.Text = "Mã nhân viên không được để trống";
                return false;
            }
            if (tbcTenNV.Text == "")
            {
                lblThongBao.Visible = true;
                lblThongBao.Text = "Tên nhân viên không được để trống";
                return false;
            }
            if (tbcLuong.Text == "")
            {
                lblThongBao.Visible = true;
                lblThongBao.Text = "Lương không được để trống";
                return false;
            }
            if (cbbGioiTinh.Text == "")
            {
                lblThongBao.Visible = true;
                lblThongBao.Text = "Giới tính không được để trống";
                return false;
            }
            if (tbcSDT.Text == "")
            {
                lblThongBao.Visible = true;
                lblThongBao.Text = "Số điện thoại không được để trống";
                return false;
            }
            if (tbcDC.Text == "")
            {
                lblThongBao.Visible = true;
                lblThongBao.Text = "Địa chỉ không được để trống";
                return false;
            }
            if (cbbChucVu.Text == "")
            {
                lblThongBao.Visible = true;
                lblThongBao.Text = "Chức vụ không được để trống";
                return false;
            }
            return true;
        }

        private void ThemCapnhatNhanVien_Load(object sender, EventArgs e)
        {
            lblThongBao.Visible = false;
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
