using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChinChin.Forms_NhanVien;

namespace ChinChin.Forms_NhanVien
{
    public partial class ButtonSanPham : UserControl
    {
        public ButtonSanPham()
        {
            InitializeComponent();
        }
        private int _id;
        private string _tensanpham;
        private int _soluong;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        public string TenSanPham
        {
            get { return _tensanpham; }
            set { _tensanpham = value; labelTenSanPham.Text = value; }
        }
        public int SoLuong
        {
            get { return _soluong; }
            set { _soluong = value; }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            TiepNhanDonHang tndh = new TiepNhanDonHang();
            tndh.NhapSanPham();
        }

        private void labelSL_Click(object sender, EventArgs e)
        {

        }

        private void labelTenSanPham_Click(object sender, EventArgs e)
        {

        }

        private void ButtonSanPham_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
        }

        private void ButtonSanPham_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void textBoxSL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void buttonAdd_MouseEnter(object sender, EventArgs e)
        {

        }
    }
}
