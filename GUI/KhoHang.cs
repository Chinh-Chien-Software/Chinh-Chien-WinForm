﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChinChin.Database;
using ChinChin.DAL_DAO;

namespace ChinChin.Forms_QuanLy
{
    public partial class KhoHang : Form
    {
        static string sqlVL = "SELECT * FROM VatLieu";
        static string sqlKH = "SELECT * FROM KhoHang";

        public KhoHang()
        {
            InitializeComponent();
        }

        private void KhoHang_Load(object sender, EventArgs e)
        {
            dgvVatLieu.DataSource = DataProvider.ReturnDataTable(sqlVL);
            cbbKhoHang.DataSource = DataProvider.ReturnDataTable(sqlKH);
            cbbKhoHang.DisplayMember = "TenKho";
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ChinChin.GUI.formThem.ThemCapnhatVatLieu ThemVatLieu = new ChinChin.GUI.formThem.ThemCapnhatVatLieu();
            ThemVatLieu.Show();
        }

        private void ibtbRefresh_Click(object sender, EventArgs e)
        {
            dgvVatLieu.DataSource = DataProvider.ReturnDataTable(sqlVL);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //int i = dgvVatLieu.CurrentCell.RowIndex;
            int i = dgvVatLieu.SelectedRows[0].Index;
            string MaVatLieu = dgvVatLieu.SelectedRows[0].Cells[0].Value.ToString();
            string TenVatLieu = dgvVatLieu.SelectedRows[0].Cells[1].Value.ToString();
            string NhaCungCap = dgvVatLieu.SelectedRows[0].Cells[2].Value.ToString();
            int SoLuong = int.Parse(dgvVatLieu.SelectedRows[0].Cells[3].Value.ToString());
            float Gia = float.Parse(dgvVatLieu.SelectedRows[0].Cells[4].Value.ToString());
            string DonViTinh = dgvVatLieu.SelectedRows[0].Cells[5].Value.ToString();
            //MessageBox.Show(dgvVatLieu.SelectedRows[0].Cells[0].Value.ToString());

            ChinChin.GUI.formThem.ThemCapnhatVatLieu ThemVatLieu
                = new ChinChin.GUI.formThem.ThemCapnhatVatLieu(
                    MaVatLieu, TenVatLieu, NhaCungCap, SoLuong, Gia, DonViTinh);

            ThemVatLieu.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string MaVatLieu = dgvVatLieu.SelectedRows[0].Cells[0].Value.ToString();
            XoaDAL.VatLieu(MaVatLieu);
        }
    }
}