using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace ChinChin.UI
{
    public partial class MainUI : Form
    {
        public MainUI()
        {
            InitializeComponent();
        }

        private void MainUI_Load(object sender, EventArgs e)
        {
            IconButton btn1 = new IconButton();
            btn1.Text = "Ngọc";
            btn1.IconChar = IconChar.Dashcube;
            btn1.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn1.Dock = DockStyle.Top;
            btn1.Size = new Size(374, 100);
            btn1.IconColor = Color.FromArgb(80, 108, 247);
            btn1.ImageAlign = ContentAlignment.MiddleLeft;
            pnButtons.Controls.Add(btn1);
            btn1.BringToFront();
        }
    }
}
