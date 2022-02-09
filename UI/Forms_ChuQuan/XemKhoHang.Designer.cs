
namespace ChinChin.FormsChuQuan
{
    partial class FormKhoHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelKhoHang = new System.Windows.Forms.Label();
            this.dataGridViewKhoHang = new System.Windows.Forms.DataGridView();
            this.khoHangBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.khoHangDataSet = new ChinChin.KhoHangDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.storageDataSet = new ChinChin.StorageDataSet();
            this.khoHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khoHangTableAdapter = new ChinChin.StorageDataSetTableAdapters.KhoHangTableAdapter();
            this.khoHangTableAdapter1 = new ChinChin.KhoHangDataSetTableAdapters.KhoHangTableAdapter();
            this.quanLyQuanTraSuaDataSet = new ChinChin.QuanLyQuanTraSuaDataSet();
            this.vatLieuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vatLieuTableAdapter = new ChinChin.QuanLyQuanTraSuaDataSetTableAdapters.VatLieuTableAdapter();
            this.maVatLieuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenVatLieuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhaCungCapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donViTinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKhoHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoHangBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoHangDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storageDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyQuanTraSuaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vatLieuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelKhoHang
            // 
            this.labelKhoHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelKhoHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKhoHang.Location = new System.Drawing.Point(0, 0);
            this.labelKhoHang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelKhoHang.Name = "labelKhoHang";
            this.labelKhoHang.Size = new System.Drawing.Size(854, 32);
            this.labelKhoHang.TabIndex = 1;
            this.labelKhoHang.Text = "Danh Sách Vật Liệu";
            this.labelKhoHang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewKhoHang
            // 
            this.dataGridViewKhoHang.AutoGenerateColumns = false;
            this.dataGridViewKhoHang.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewKhoHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKhoHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maVatLieuDataGridViewTextBoxColumn,
            this.tenVatLieuDataGridViewTextBoxColumn,
            this.nhaCungCapDataGridViewTextBoxColumn,
            this.soLuongDataGridViewTextBoxColumn,
            this.giaDataGridViewTextBoxColumn,
            this.donViTinhDataGridViewTextBoxColumn});
            this.dataGridViewKhoHang.DataSource = this.vatLieuBindingSource;
            this.dataGridViewKhoHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewKhoHang.Location = new System.Drawing.Point(0, 32);
            this.dataGridViewKhoHang.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewKhoHang.Name = "dataGridViewKhoHang";
            this.dataGridViewKhoHang.RowHeadersWidth = 51;
            this.dataGridViewKhoHang.RowTemplate.Height = 24;
            this.dataGridViewKhoHang.Size = new System.Drawing.Size(854, 334);
            this.dataGridViewKhoHang.TabIndex = 2;
            // 
            // khoHangBindingSource1
            // 
            this.khoHangBindingSource1.DataMember = "KhoHang";
            this.khoHangBindingSource1.DataSource = this.khoHangDataSet;
            // 
            // khoHangDataSet
            // 
            this.khoHangDataSet.DataSetName = "KhoHangDataSet";
            this.khoHangDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelKhoHang);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(854, 32);
            this.panel1.TabIndex = 3;
            // 
            // storageDataSet
            // 
            this.storageDataSet.DataSetName = "StorageDataSet";
            this.storageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // khoHangBindingSource
            // 
            this.khoHangBindingSource.DataMember = "KhoHang";
            this.khoHangBindingSource.DataSource = this.storageDataSet;
            // 
            // khoHangTableAdapter
            // 
            this.khoHangTableAdapter.ClearBeforeFill = true;
            // 
            // khoHangTableAdapter1
            // 
            this.khoHangTableAdapter1.ClearBeforeFill = true;
            // 
            // quanLyQuanTraSuaDataSet
            // 
            this.quanLyQuanTraSuaDataSet.DataSetName = "QuanLyQuanTraSuaDataSet";
            this.quanLyQuanTraSuaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vatLieuBindingSource
            // 
            this.vatLieuBindingSource.DataMember = "VatLieu";
            this.vatLieuBindingSource.DataSource = this.quanLyQuanTraSuaDataSet;
            // 
            // vatLieuTableAdapter
            // 
            this.vatLieuTableAdapter.ClearBeforeFill = true;
            // 
            // maVatLieuDataGridViewTextBoxColumn
            // 
            this.maVatLieuDataGridViewTextBoxColumn.DataPropertyName = "MaVatLieu";
            this.maVatLieuDataGridViewTextBoxColumn.HeaderText = "MaVatLieu";
            this.maVatLieuDataGridViewTextBoxColumn.Name = "maVatLieuDataGridViewTextBoxColumn";
            // 
            // tenVatLieuDataGridViewTextBoxColumn
            // 
            this.tenVatLieuDataGridViewTextBoxColumn.DataPropertyName = "TenVatLieu";
            this.tenVatLieuDataGridViewTextBoxColumn.HeaderText = "TenVatLieu";
            this.tenVatLieuDataGridViewTextBoxColumn.Name = "tenVatLieuDataGridViewTextBoxColumn";
            // 
            // nhaCungCapDataGridViewTextBoxColumn
            // 
            this.nhaCungCapDataGridViewTextBoxColumn.DataPropertyName = "NhaCungCap";
            this.nhaCungCapDataGridViewTextBoxColumn.HeaderText = "NhaCungCap";
            this.nhaCungCapDataGridViewTextBoxColumn.Name = "nhaCungCapDataGridViewTextBoxColumn";
            // 
            // soLuongDataGridViewTextBoxColumn
            // 
            this.soLuongDataGridViewTextBoxColumn.DataPropertyName = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn.HeaderText = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn.Name = "soLuongDataGridViewTextBoxColumn";
            // 
            // giaDataGridViewTextBoxColumn
            // 
            this.giaDataGridViewTextBoxColumn.DataPropertyName = "Gia";
            this.giaDataGridViewTextBoxColumn.HeaderText = "Gia";
            this.giaDataGridViewTextBoxColumn.Name = "giaDataGridViewTextBoxColumn";
            // 
            // donViTinhDataGridViewTextBoxColumn
            // 
            this.donViTinhDataGridViewTextBoxColumn.DataPropertyName = "DonViTinh";
            this.donViTinhDataGridViewTextBoxColumn.HeaderText = "DonViTinh";
            this.donViTinhDataGridViewTextBoxColumn.Name = "donViTinhDataGridViewTextBoxColumn";
            // 
            // FormKhoHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 366);
            this.Controls.Add(this.dataGridViewKhoHang);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormKhoHang";
            this.Text = "Kho Hàng";
            this.Load += new System.EventHandler(this.FormKhoHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKhoHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoHangBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoHangDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.storageDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyQuanTraSuaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vatLieuBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelKhoHang;
        private System.Windows.Forms.DataGridView dataGridViewKhoHang;
        private System.Windows.Forms.Panel panel1;
        private StorageDataSet storageDataSet;
        private System.Windows.Forms.BindingSource khoHangBindingSource;
        private StorageDataSetTableAdapters.KhoHangTableAdapter khoHangTableAdapter;
        private KhoHangDataSet khoHangDataSet;
        private System.Windows.Forms.BindingSource khoHangBindingSource1;
        private KhoHangDataSetTableAdapters.KhoHangTableAdapter khoHangTableAdapter1;
        private QuanLyQuanTraSuaDataSet quanLyQuanTraSuaDataSet;
        private System.Windows.Forms.BindingSource vatLieuBindingSource;
        private QuanLyQuanTraSuaDataSetTableAdapters.VatLieuTableAdapter vatLieuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maVatLieuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenVatLieuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhaCungCapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donViTinhDataGridViewTextBoxColumn;
    }
}