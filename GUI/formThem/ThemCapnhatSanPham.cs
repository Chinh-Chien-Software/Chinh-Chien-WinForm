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
    public partial class ThemCapnhatSanPham : Form
    {
        int ChucNang;
        string Loai;
        
        public ThemCapnhatSanPham()
        {
            InitializeComponent();
            lblThongBao.Visible = false;
            btnLuu.Text = "Lưu";
            lblTitle.Text = "Thêm sản phẩm";
            ChucNang = 0;
        }
        public ThemCapnhatSanPham(
            string MaSanPham,
            string TenSanPham,
            string CongThuc,
            string ThanhPhan,
            float Gia,
            int DanhGia,
            string Loai
            )
        {
            InitializeComponent();
            lblThongBao.Visible = false;
            btnLuu.Text = "Cập nhật";
            lblTitle.Text = "Cập nhật sản phẩm";
            
            tbcMaSP.Text = MaSanPham;
            tbcTenSP.Text = TenSanPham;
            tbcCT.Text = CongThuc;

            //tbcTimVL.Text = ThanhPhan;
            //dgvThanhPhan.DataSource = 

            tbcGia.Text = Gia.ToString();
            tbcDanhGia.Text = DanhGia.ToString();
            cbbLoai.Text = Loai;
            ChucNang = 1;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            SanPhamDAO sanPhamDAO = new SanPhamDAO();
            if (KiemTra())
            {
                var fQuanLyMenu = (ChinChin.Forms_ChuQuan.QuanLyMenu)this.Owner;
                if (ChucNang == 0)
                {
                    ChonLoai();
                    sanPhamDAO.Create
                        (tbcMaSP.Text, tbcTenSP.Text, tbcCT.Text, "",
                        float.Parse(tbcGia.Text), int.Parse(tbcDanhGia.Text), cbbLoai.Text, fQuanLyMenu.MaQuan);
                    fQuanLyMenu.RefreshDGV();
                    this.Close();
                }
                else if (ChucNang == 1)
                {
                    btnLuu.Text = "Cập nhật";
                    sanPhamDAO.Update
                        (tbcMaSP.Text, tbcTenSP.Text, tbcCT.Text, "",
                        float.Parse(tbcGia.Text), int.Parse(tbcDanhGia.Text), cbbLoai.Text);
                    fQuanLyMenu.RefreshDGV();
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
            /*else if (tbcTimVL.Text == "")
            {
                lblThongBao.Visible = true;
                MessageBox.Show("Thành phần không được để trống");
                KetQua = false;
            }*/
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
