using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChinChin.UI
{
    public static class MenuAnimation
    {
        //Fields
        private static IconButton currentBtn;
        //private Panel leftBorderBtn;
        public struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 188, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 241);
        }

        public static void ActivateButton(object senderBtn, Color color, IconPictureBox iconCurrentChildForm)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                currentBtn.Size = new Size(498, 100);

                //left border button
                //leftBorderBtn.BackColor = color;
                //leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                //leftBorderBtn.Visible = true;
                //leftBorderBtn.BringToFront();

                //Icon Current Child Form
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }
        private static void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(255, 255, 255);
                currentBtn.ForeColor = Color.Black;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.FromArgb(80, 108, 247);
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
                currentBtn.Size = new Size(498, 100);
            }
        }
        public static void Reset(IconPictureBox iconCurrentChildForm, Label labelTittleChildForm)
        {
            DisableButton();
            //leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.MediumPurple;
            labelTittleChildForm.Text = "Home";
        }
        public static void OpenChildForm(Form childForm, ref Form currentChildForm, Panel panelDesktop, Label labelTittleChildForm)
        {
            if (currentChildForm != null)
            {
                //Open Only Form
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelTittleChildForm.Text = childForm.Text;
        }
    }
}
