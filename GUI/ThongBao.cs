using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChinhChien.GUI
{
    internal class ThongBao
    {

        public void Hien(Label lb, string message)
        {
            lb.Visible = true;
            lb.Text = message;
        }
    }
}
