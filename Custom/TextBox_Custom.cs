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
        public override string Text
        {
            get { return textBox.Text; }
            set { textBox.Text = value; }
        }
        public char PasswordChar
        {
            get { return textBox.PasswordChar; }
            set { textBox.PasswordChar = value; }
        }

        [Browsable(true)] [Category("Action")]
        [Description("Invoked when user clicks button")]
        public event EventHandler TextChanged;

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (this.TextChanged != null)
                this.TextChanged(this, e);
        }
    }
}
