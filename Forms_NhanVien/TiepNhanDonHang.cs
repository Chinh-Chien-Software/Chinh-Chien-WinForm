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


namespace ChinChin.Forms_NhanVien
{
    public partial class TiepNhanDonHang : Form
    {
        public TiepNhanDonHang()
        {
            InitializeComponent();
            HienMenu();
        }
        string chuoiketnoi = @"Data Source=DESKTOP-AN8O8G6\TQK;Initial Catalog=QuanLyQuanTraSua;Integrated Security=True";
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

            /*
            ketnoi.Open();
            thuchien = new SqlCommand(sqlcode, ketnoi);
            docdulieu = thuchien.ExecuteReader();
            docdulieu.Read();
            */

            //docdulieu[0].ToString();
            //flowLayoutPanelMenuList.Controls.Add();

            foreach (DataRow row in dttb.Rows)
            {
                var uc = new ButtonSanPham
                {
                    TenSanPham = row["TenSanPham"].ToString(),
                };
                flowLayoutPanelMenuList.Controls.Add(uc);
            }
        }


    }
}
