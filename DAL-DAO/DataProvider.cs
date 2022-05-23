using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ChinChin.DAL_DAO
{
    /* Learn about these methods from https://github.com/ngominhthong/QuanLyDiem/blob/main/QuanLyDiemSV/QuanLyDiemSV/Moldel/DataProvider.cs */
    
    internal class DataProvider
    {
        // cnStr chứa thông tin về tên Server, Database..
        static SqlConnection conn; // Create a connection - Dây cấm
        static string connStr = Properties.Settings.Default.ChinhChienConnectionString; // Ổ cấm
        static SqlCommand cm;

        static public DataTable ReturnDataTable(string sql)
        {
            DataTable dt = new DataTable(); //Khởi tạo một datatable để lưu dữ liệu
            conn = new SqlConnection(connStr); // Khởi tạo 1 kết nối - Cấm vào
            cm = new SqlCommand(sql, conn); //Tạo các lệnh
            SqlDataAdapter da = new SqlDataAdapter(cm); //Thực thi những lệnh được truyền từ SqlCommand
            da.Fill(dt); //Đổ dữ liệu từ DataAdapter vào Datatable
            return dt;
        }

        static public void Create_Check_Database ()
        {
            string sql = Properties.Settings.Default.ChinhChienConnectionString;
            conn = new SqlConnection(connStr); //Khởi tạo 1 kết nối
            SqlCommand cm = new SqlCommand(sql, conn); //Tạo các lệnh
        }

        // Tại sao lại tạo DataSet trong khi chỉ toàn dùng DataTable => 
        static public DataSet LoadDataSet(string sql)
        {
            DataSet DataSet = new DataSet(); //Khởi tạo một DataSet để lưu dữ liệu
            conn = new SqlConnection(connStr); //Khởi tạo 1 kết nối
            cm = new SqlCommand(sql, conn); //Tạo các lệnh
            SqlDataAdapter da = new SqlDataAdapter(cm); //Thực thi những lệnh được truyền từ SqlCommand
            da.Fill(DataSet); //Đổ dữ liệu từ DataAdapter vào DataSet
            return DataSet;
        }

        static public SqlDataReader ReturnSqlDataReader(string sql)
        {
            SqlDataReader SqlDataReader; //Khởi tạo một DataReader để lưu dữ liệu
            conn = new SqlConnection(connStr);
            conn.Open();
            cm = new SqlCommand(sql, conn);
            SqlDataReader = cm.ExecuteReader(); //Thực thi những lệnh được truyền từ SqlCommand
            // ExecuteReader() trả về một bảng dữ liệu
            //conn.Close();
            return SqlDataReader;
        }

        static public string ReturnFirstCell(string sql)
        {
            conn = new SqlConnection(connStr); // Khởi tạo 1 kết nối - Cấm vào
            conn.Open();
            cm = new SqlCommand(sql, conn); //Tạo các lệnh
            string kq = (string)cm.ExecuteScalar();
            return kq;
        }
    }
}
