using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChinChin.GUI
{
    public partial class NhapSoLuong : Form
    {
        public NhapSoLuong()
        {
            InitializeComponent();
            this.ActiveControl = tbcSL;
            this.FormBorderStyle = FormBorderStyle.None;
        }
        
        public string SoLuong
        {
            get;
            set;
        }
        
        private void btnOK_Click(object sender, EventArgs e)
        {
            SoLuong = tbcSL.Text;
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
