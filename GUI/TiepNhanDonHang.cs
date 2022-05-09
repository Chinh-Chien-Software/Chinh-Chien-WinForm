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

namespace ChinChin.Forms_NhanVien
{
    public partial class TiepNhanDonHang : Form
    {
        public TiepNhanDonHang()
        {
            InitializeComponent();
            
            //HienMenu();
        }
        string chuoiketnoi = Properties.Settings.Default.ChinhChienConnectionString;
        string sqlcode;
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
            string i = lvSanPhamTheoLoai.SelectedItems[0].SubItems[2].Text.ToString();
            MessageBox.Show(i);
        }
    }
}
