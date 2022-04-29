using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChinChin.Custom
{
    public partial class TextBox_Custom : UserControl
    {
        public TextBox_Custom()
        {
            InitializeComponent();
        }
        public string TB_Text
        {
            get { return textBox.Text; }
            set { textBox.Text = value; }
        }
        public char PasswordChar
        {
            get { return textBox.PasswordChar; }
            set { textBox.PasswordChar = value; }
        }
    }
}
