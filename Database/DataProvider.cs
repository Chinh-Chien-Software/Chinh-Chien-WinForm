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
        string cnStr = @"Data Source=DESKTOP-AN8O8G6\TQK;Initial Catalog=QuanLyQuanTraSua;Integrated Security=True";
        SqlConnection cn; // Create a connection
        SqlCommand thuchien;
        SqlDataReader docdulieu;
    }
}
