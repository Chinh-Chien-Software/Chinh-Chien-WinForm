using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChinhChien.Extra
{
    public partial class Notification : Form
    {
        public Notification(string NoiDung)
        {
            InitializeComponent();
            labelMessage.Text = NoiDung;
        }
    }
}
