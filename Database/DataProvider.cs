using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ChinChin.Database
{
    /* Learn about these methods from https://github.com/ngominhthong/QuanLyDiem/blob/main/QuanLyDiemSV/QuanLyDiemSV/Moldel/DataProvider.cs */
    
    internal class DataProvider
    {
        // cnStr is connection String
        // ketnoi = new SqlConnection(chuoiketnoi);
        // Connection String for set up infomation to connect.
        static string cnStr = @"Data Source=DESKTOP-AN8O8G6\TQK;Initial Catalog=QuanLyQuanTraSua;Integrated Security=True";
        static SqlConnection cn; // Create a connection
        SqlCommand thuchien;
        SqlDataReader docdulieu;

        private void OleMethod()
        {
            //ketnoi.Open();
            //ketnoi.Close();
            //// Kiểm tra Mật Khẩu
            //SqlDataAdapter sda = new SqlDataAdapter(sqlcode, ketnoi);
            //DataTable dttb = new DataTable();
            //sda.Fill(dttb);
            ////Kiểm tra LoaiTaiKhoan
            //ketnoi.Open();
            //thuchien = new SqlCommand(sqlcode, ketnoi);
            //docdulieu = thuchien.ExecuteReader();
            //docdulieu.Read();
        }
        static public DataTable LoadDatabase(string sql)
        {
            DataTable dt = new DataTable(); //Khởi tạo một datatable để lưu dữ liệu
            cn = new SqlConnection(cnStr); //Khởi tạo 1 kết nối
            SqlCommand cm = new SqlCommand(sql, cn); //Tạo các lệnh
            SqlDataAdapter da = new SqlDataAdapter(cm); //Thực thi những lệnh được truyền từ SqlCommand
            da.Fill(dt);//Đổ dữ liệu từ DataAdapter vào Datatable
            return dt;
        }
        // Tại sao lại tạo DataSet trong khi chỉ toàn dùng DataTable
        static public DataSet LoadCSDLDTS(string sql)
        {
            DataSet dt = new DataSet();//Khởi tạo một datatable để lưu dữ liệu
            cn = new SqlConnection(cnStr);//Khởi tạo 1 kết nối
            SqlCommand cm = new SqlCommand(sql, cn);//Tạo các lệnh
            SqlDataAdapter da = new SqlDataAdapter(cm);//Thực thi những lệnh được truyền từ SqlCommand
            da.Fill(dt);//Đổ dữ liệu từ DataAdapter vào Datatable
            return dt;
        }
    }
    
}
