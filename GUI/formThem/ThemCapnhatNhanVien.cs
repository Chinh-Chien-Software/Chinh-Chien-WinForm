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

namespace ChinChin.GUI.formThem
{
    public partial class ThemCapnhatNhanVien : Form
    {
        int ChucNang;
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
            string LoaiNhanVien
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
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (ChucNang == 0)
            {
                if (KiemTra())
                {
                    ThemDAL.NhanVien
                     (tbcMaNV.Text, tbcTenNV.Text, int.Parse(tbcLuong.Text), dtpNgayVL.Value,
                     cbbGioiTinh.Text, dtpNgaySinh.Value, tbcSDT.Text, tbcDC.Text, cbbChucVu.Text, "quanchinhchien");
                    var f = (NhanSu)this.Owner;
                    f.RefreshDGV();
                    this.Close();
                }
            }
            else if (ChucNang == 1)
            {
                if (KiemTra())
                {
                    btnLuu.Text = "Cập nhật";
                    CapNhatDAL.NhanVien
                        (tbcMaNV.Text, tbcTenNV.Text, int.Parse(tbcLuong.Text), dtpNgayVL.Value,
                        cbbGioiTinh.Text, dtpNgaySinh.Value, tbcSDT.Text, tbcDC.Text, cbbChucVu.Text, "quanchinhchien");
                    var f1 = (NhanSu)this.Owner;
                    f1.RefreshDGV();
                    this.Close();
                }
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
