
namespace ChinChin.Forms_QuanLy
{
    partial class KhoHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvVatLieu = new System.Windows.Forms.DataGridView();
            this.btnEdit = new FontAwesome.Sharp.IconButton();
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.ipbThemKho = new FontAwesome.Sharp.IconPictureBox();
            this.cbbKho = new System.Windows.Forms.ComboBox();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.btnNew = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVatLieu)).BeginInit();
            this.pnlTopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ipbThemKho)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVatLieu
            // 
            this.dgvVatLieu.AllowUserToAddRows = false;
            this.dgvVatLieu.AllowUserToDeleteRows = false;
            this.dgvVatLieu.AllowUserToResizeColumns = false;
            this.dgvVatLieu.AllowUserToResizeRows = false;
            this.dgvVatLieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVatLieu.BackgroundColor = System.Drawing.Color.White;
            this.dgvVatLieu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVatLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVatLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVatLieu.GridColor = System.Drawing.Color.White;
            this.dgvVatLieu.Location = new System.Drawing.Point(0, 48);
            this.dgvVatLieu.Margin = new System.Windows.Forms.Padding(2);
            this.dgvVatLieu.Name = "dgvVatLieu";
            this.dgvVatLieu.ReadOnly = true;
            this.dgvVatLieu.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Inter", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvVatLieu.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVatLieu.RowTemplate.Height = 24;
            this.dgvVatLieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVatLieu.Size = new System.Drawing.Size(800, 318);
            this.dgvVatLieu.TabIndex = 0;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(108)))), ((int)(((byte)(247)))));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEdit.IconColor = System.Drawing.Color.White;
            this.btnEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEdit.IconSize = 40;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnEdit.Location = new System.Drawing.Point(595, 0);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(89, 46);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.White;
            this.pnlTopBar.Controls.Add(this.ipbThemKho);
            this.pnlTopBar.Controls.Add(this.cbbKho);
            this.pnlTopBar.Controls.Add(this.btnDelete);
            this.pnlTopBar.Controls.Add(this.btnNew);
            this.pnlTopBar.Controls.Add(this.btnEdit);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBar.Margin = new System.Windows.Forms.Padding(2);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(800, 48);
            this.pnlTopBar.TabIndex = 2;
            // 
            // ipbThemKho
            // 
            this.ipbThemKho.BackColor = System.Drawing.Color.White;
            this.ipbThemKho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(108)))), ((int)(((byte)(247)))));
            this.ipbThemKho.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.ipbThemKho.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(108)))), ((int)(((byte)(247)))));
            this.ipbThemKho.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ipbThemKho.IconSize = 39;
            this.ipbThemKho.Location = new System.Drawing.Point(265, 7);
            this.ipbThemKho.Margin = new System.Windows.Forms.Padding(2);
            this.ipbThemKho.Name = "ipbThemKho";
            this.ipbThemKho.Size = new System.Drawing.Size(39, 39);
            this.ipbThemKho.TabIndex = 6;
            this.ipbThemKho.TabStop = false;
            this.ipbThemKho.Click += new System.EventHandler(this.ipbThemKho_Click);
            // 
            // cbbKho
            // 
            this.cbbKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbKho.FormattingEnabled = true;
            this.cbbKho.Location = new System.Drawing.Point(2, 9);
            this.cbbKho.Name = "cbbKho";
            this.cbbKho.Size = new System.Drawing.Size(258, 28);
            this.cbbKho.TabIndex = 5;
            this.cbbKho.Text = "Chọn Kho Hàng";
            this.cbbKho.SelectedIndexChanged += new System.EventHandler(this.cbbKho_SelectedIndexChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(108)))), ((int)(((byte)(247)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnDelete.IconColor = System.Drawing.Color.White;
            this.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelete.IconSize = 40;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnDelete.Location = new System.Drawing.Point(688, 0);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 46);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(108)))), ((int)(((byte)(247)))));
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnNew.IconColor = System.Drawing.Color.White;
            this.btnNew.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNew.IconSize = 40;
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnNew.Location = new System.Drawing.Point(502, 0);
            this.btnNew.Margin = new System.Windows.Forms.Padding(2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(89, 46);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "Thêm";
            this.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // KhoHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 366);
            this.Controls.Add(this.dgvVatLieu);
            this.Controls.Add(this.pnlTopBar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "KhoHang";
            this.Text = "QuanLyKhoHang - Các Vật Liệu";
            this.Load += new System.EventHandler(this.KhoHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVatLieu)).EndInit();
            this.pnlTopBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ipbThemKho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVatLieu;
        private FontAwesome.Sharp.IconButton btnEdit;
        private System.Windows.Forms.Panel pnlTopBar;
        private FontAwesome.Sharp.IconButton btnNew;
        private FontAwesome.Sharp.IconButton btnDelete;
        private System.Windows.Forms.ComboBox cbbKho;
        private FontAwesome.Sharp.IconPictureBox ipbThemKho;
    }
}