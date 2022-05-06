
namespace ChinChin.Forms_ChuQuan
{
    partial class FormThucDon
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
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.btnNew = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVatLieu)).BeginInit();
            this.pnlTopBar.SuspendLayout();
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
            this.dgvVatLieu.Size = new System.Drawing.Size(600, 318);
            this.dgvVatLieu.TabIndex = 3;
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
            this.btnEdit.Location = new System.Drawing.Point(395, 0);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(89, 46);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.White;
            this.pnlTopBar.Controls.Add(this.btnDelete);
            this.pnlTopBar.Controls.Add(this.btnNew);
            this.pnlTopBar.Controls.Add(this.btnEdit);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBar.Margin = new System.Windows.Forms.Padding(2);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(600, 48);
            this.pnlTopBar.TabIndex = 4;
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
            this.btnDelete.Location = new System.Drawing.Point(488, 0);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 46);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
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
            this.btnNew.Location = new System.Drawing.Point(302, 0);
            this.btnNew.Margin = new System.Windows.Forms.Padding(2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(89, 46);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "New";
            this.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNew.UseVisualStyleBackColor = false;
            // 
            // FormThucDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.dgvVatLieu);
            this.Controls.Add(this.pnlTopBar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormThucDon";
            this.Text = "Quản Lý Menu";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVatLieu)).EndInit();
            this.pnlTopBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVatLieu;
        private FontAwesome.Sharp.IconButton btnEdit;
        private System.Windows.Forms.Panel pnlTopBar;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnNew;
    }
}