
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.storageDataSet = new ChinChin.StorageDataSet();
            this.khoHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khoHangTableAdapter = new ChinChin.StorageDataSetTableAdapters.KhoHangTableAdapter();
            this.khoHangDataSet = new ChinChin.KhoHangDataSet();
            this.khoHangBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.khoHangTableAdapter1 = new ChinChin.KhoHangDataSetTableAdapters.KhoHangTableAdapter();
            this.maKhoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKhoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dienTichDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storageDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoHangDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoHangBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelKhoHang
            // 
            this.labelKhoHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelKhoHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKhoHang.Location = new System.Drawing.Point(0, 0);
            this.labelKhoHang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelKhoHang.Name = "labelKhoHang";
            this.labelKhoHang.Size = new System.Drawing.Size(600, 32);
            this.labelKhoHang.TabIndex = 1;
            this.labelKhoHang.Text = "Danh Sách Vật Liệu";
            this.labelKhoHang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maKhoDataGridViewTextBoxColumn,
            this.tenKhoDataGridViewTextBoxColumn,
            this.diaChiDataGridViewTextBoxColumn,
            this.dienTichDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.khoHangBindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 32);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(600, 334);
            this.dataGridView1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelKhoHang);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 32);
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
            // khoHangDataSet
            // 
            this.khoHangDataSet.DataSetName = "KhoHangDataSet";
            this.khoHangDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // khoHangBindingSource1
            // 
            this.khoHangBindingSource1.DataMember = "KhoHang";
            this.khoHangBindingSource1.DataSource = this.khoHangDataSet;
            // 
            // khoHangTableAdapter1
            // 
            this.khoHangTableAdapter1.ClearBeforeFill = true;
            // 
            // maKhoDataGridViewTextBoxColumn
            // 
            this.maKhoDataGridViewTextBoxColumn.DataPropertyName = "MaKho";
            this.maKhoDataGridViewTextBoxColumn.HeaderText = "MaKho";
            this.maKhoDataGridViewTextBoxColumn.Name = "maKhoDataGridViewTextBoxColumn";
            // 
            // tenKhoDataGridViewTextBoxColumn
            // 
            this.tenKhoDataGridViewTextBoxColumn.DataPropertyName = "TenKho";
            this.tenKhoDataGridViewTextBoxColumn.HeaderText = "TenKho";
            this.tenKhoDataGridViewTextBoxColumn.Name = "tenKhoDataGridViewTextBoxColumn";
            // 
            // diaChiDataGridViewTextBoxColumn
            // 
            this.diaChiDataGridViewTextBoxColumn.DataPropertyName = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.HeaderText = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.Name = "diaChiDataGridViewTextBoxColumn";
            // 
            // dienTichDataGridViewTextBoxColumn
            // 
            this.dienTichDataGridViewTextBoxColumn.DataPropertyName = "DienTich";
            this.dienTichDataGridViewTextBoxColumn.HeaderText = "DienTich";
            this.dienTichDataGridViewTextBoxColumn.Name = "dienTichDataGridViewTextBoxColumn";
            // 
            // FormKhoHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormKhoHang";
            this.Text = "Kho Hàng";
            this.Load += new System.EventHandler(this.FormKhoHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.storageDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoHangDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoHangBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelKhoHang;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private StorageDataSet storageDataSet;
        private System.Windows.Forms.BindingSource khoHangBindingSource;
        private StorageDataSetTableAdapters.KhoHangTableAdapter khoHangTableAdapter;
        private KhoHangDataSet khoHangDataSet;
        private System.Windows.Forms.BindingSource khoHangBindingSource1;
        private KhoHangDataSetTableAdapters.KhoHangTableAdapter khoHangTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKhoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKhoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dienTichDataGridViewTextBoxColumn;
    }
}