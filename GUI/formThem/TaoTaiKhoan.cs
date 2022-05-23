using ChinChin.BUS;
using ChinChin.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChinChin.GUI.formThem
{
    public partial class TaoTaiKhoan : Form
    {
        string TaiKhoan;
        string MatKhau;
        string Email;
        string MaNhanVien;
        TaiKhoanBUS tkBUS;
        NhanVienBUS nvBUS;
        int ChucNang;
        public TaoTaiKhoan(string MaNhanVien)
        {
            InitializeComponent();
            btnGo.Visible = false;
            tkBUS = new TaiKhoanBUS();
            nvBUS = new NhanVienBUS();  
            ChucNang = 0;
            this.MaNhanVien = MaNhanVien;
        }

        public TaoTaiKhoan(string TaiKhoan, string MatKhau,string Email, string MaNhanVien)
        {
            InitializeComponent();
            tkBUS = new TaiKhoanBUS();
            tbcTenTk.Text = TaiKhoan;   
            this.TaiKhoan = TaiKhoan;
            tbcMk.Text = MatKhau;
            this.MatKhau = MatKhau;
            tbcEmail.Text = Email;
            this.Email = Email;
            this.MaNhanVien = MaNhanVien;
            btnGo.Visible = true;
            tbcTenTk.Enabled = false;
            ChucNang = 1;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            var f = (NhanSu)this.Owner;
            try
            {
                if (KiemTra())
                {
                    if (ChucNang == 0)
                    {
                        tkBUS.ThemTaiKhoanBUS(tbcTenTk.Text, tbcMk.Text, 1, tbcEmail.Text);
                        nvBUS.ThemTaiKhoanBUS(tbcTenTk.Text,f.MaNhanVien);

                    }
                    else
                    {
                        tkBUS.SuaTaiKhoanBUS(tbcTenTk.Text, tbcMk.Text, 1, tbcEmail.Text);
                    }
                    this.Close();
                    f.RefreshDGV();

                }
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message);
            }
           
        }

        private bool KiemTra()
        {
            if (tbcTenTk.Text.Trim() == "")
            {
                labelLoi.Text = "Bạn chưa nhập tài khoản";
                return false;
            }
            if (tbcMk.Text.Trim() == "")
            {
                labelLoi.Text = "Bạn chưa nhập mật khẩu";
                return false;
            }
            if (tbcEmail.Text.Trim() == "")
            {
                labelLoi.Text = "Bạn chưa nhập email";
                return false;
            }

            if (!WorkingDatabase.CheckUsername(tbcTenTk.Text) && ChucNang == 0)
            {
                labelLoi.Text = "Tài khoản đã tồn tại !" ;
                return false;
            }
            return true;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            var f = (NhanSu)this.Owner;
            try
            {
                tkBUS.goTaiKhoan(f.MaNhanVien);
                this.Close();
                f.RefreshDGV();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
