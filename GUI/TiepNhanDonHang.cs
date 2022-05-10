using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ChinChin.DAL_DAO;
using ChinChin.GUI;

namespace ChinChin.Forms_NhanVien
{
    public partial class TiepNhanDonHang : Form
    {
        public TiepNhanDonHang()
        {
            InitializeComponent();
            HienSanPham("Trasua");
            //HienMenu();
        }
        string chuoiketnoi = Properties.Settings.Default.ChinhChienConnectionString;
        string sqlcode;
        string MaHoaDon;
        SqlConnection ketnoi;
        //SqlCommand thuchien;
        //SqlDataReader docdulieu;

        public void NhapSanPham()
        {
            
        }
        private void HienMenu()
        {
            ketnoi = new SqlConnection(chuoiketnoi);
            sqlcode = "SELECT * FROM SanPham";
            ketnoi.Open();
            SqlDataAdapter sda = new SqlDataAdapter(sqlcode, ketnoi);
            DataTable dttb = new DataTable();
            sda.Fill(dttb);
            ketnoi.Close();

            foreach (DataRow row in dttb.Rows)
            {
                var uc = new ButtonSanPham
                {
                    TenSanPham = row["TenSanPham"].ToString(),
                };
            }
        }
        /*
        int TaoMaHoaDon()
        {
            string phanNgay = DateTime.Now.ToShortDateString();
            return int i = 0;
        }*/

        
        private void btnTypeTraSua_Click(object sender, EventArgs e)
        {
            HienSanPham("Trasua");
        }

        void HienSanPham(string Loai)
        {
            lvSanPhamTheoLoai.Items.Clear();
            string query = "SELECT TenSanPham, Gia, MaSanPham FROM SanPham where Loai = '"+ Loai +"'";
            int i = 0;
            SqlDataReader table = DataProvider.ReturnSqlDataReader(query);
            while (table.Read())
            {
                lvSanPhamTheoLoai.Items.Add(table["TenSanPham"].ToString());
                lvSanPhamTheoLoai.Items[i].SubItems.Add(table["Gia"].ToString());
                lvSanPhamTheoLoai.Items[i].SubItems.Add(table["MaSanPham"].ToString());
                i++;
            }
            table.Close();
        }

        private void lvSanPhamTheoLoai_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            lvThongTinHoaDon.Items.Add(lvSanPhamTheoLoai.SelectedItems[0].Text.ToString());
            lvThongTinHoaDon.Items[0].SubItems.Add(lvSanPhamTheoLoai.SelectedItems[0].SubItems[1].Text.ToString());
            NhapSoLuong nhapSL = new NhapSoLuong();
            nhapSL.ShowDialog();
            int Tien = int.Parse(lvSanPhamTheoLoai.SelectedItems[0].SubItems[1].Text.ToString()) * int.Parse(nhapSL.SoLuong);
            lvThongTinHoaDon.Items[0].SubItems.Add(nhapSL.SoLuong);
            lvThongTinHoaDon.Items[0].SubItems.Add(Tien.ToString());
            lvThongTinHoaDon.Items[0].SubItems.Add(lvSanPhamTheoLoai.SelectedItems[0].SubItems[2].Text.ToString());
        }

        private void btnTypeCaPhe_Click(object sender, EventArgs e)
        {

        }

        private void lvSanPhamTheoLoai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
