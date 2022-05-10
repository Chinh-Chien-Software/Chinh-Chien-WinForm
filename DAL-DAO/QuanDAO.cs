﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ChinChin.DAL_DAO
{
    internal class QuanDAO
    {
        private dbConnection conn;

        public QuanDAO()
        {
            conn = new dbConnection();
        }

        public DataTable searchQuanByTenTaiKhoan(string TenTaiKhoan)
        {
            string sql = "SELECT Quan.MaQuan, Quan.TenQuan FROM Quan, TruyCapQuan WHERE Quan.MaQuan = TruyCapQuan.MaQuan AND TruyCapQuan.TenTaiKhoan = @TenTaiKhoan";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@TenTaiKhoan", SqlDbType.VarChar, 10);
            parameters[0].Value = TenTaiKhoan;
            DataTable dt = new DataTable();
            dt = conn.executeSelectQuery(sql, parameters);
            return dt;
        }
    }
}