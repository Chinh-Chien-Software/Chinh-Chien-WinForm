using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChinChin.Forms_NhanVien
{
    public partial class TiepNhanDonHang : Form
    {
        public TiepNhanDonHang()
        {
            InitializeComponent();

            ListViewItem ThucUong = new ListViewItem();
            ThucUong.Text = "Tên";
            ThucUong.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "SL" });
            ThucUong.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "Giá" });
            ThucUong.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "T.Tiền" });
            listViewThucUong.Items.Add(ThucUong);
        }
    }
}
