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
        // cnStr chứa thông tin về tên Server, Database..
        static SqlConnection conn; // Create a connection
        static string connStr = @"Data Source=DESKTOP-AN8O8G6\TQK;Initial Catalog=QuanLyQuanTraSua;Integrated Security=True";

        static public DataTable LoadDatabase(string sql)
        {
            DataTable dt = new DataTable(); //Khởi tạo một datatable để lưu dữ liệu
            conn = new SqlConnection(connStr); //Khởi tạo 1 kết nối
            SqlCommand cm = new SqlCommand(sql, conn); //Tạo các lệnh
            SqlDataAdapter da = new SqlDataAdapter(cm); //Thực thi những lệnh được truyền từ SqlCommand
            da.Fill(dt); //Đổ dữ liệu từ DataAdapter vào Datatable
            return dt;
        }

        static public Create_Check_Database ()
        {

        }

        // Tại sao lại tạo DataSet trong khi chỉ toàn dùng DataTable
        static public DataSet LoadCSDLDTS(string sql)
        {
            DataSet dt = new DataSet();//Khởi tạo một datatable để lưu dữ liệu
            conn = new SqlConnection(connStr);//Khởi tạo 1 kết nối
            SqlCommand cm = new SqlCommand(sql, conn);//Tạo các lệnh
            SqlDataAdapter da = new SqlDataAdapter(cm);//Thực thi những lệnh được truyền từ SqlCommand
            da.Fill(dt);//Đổ dữ liệu từ DataAdapter vào Datatable
            return dt;
        }
    }
    
}
