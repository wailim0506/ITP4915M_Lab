using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ITP4915M_Lab.Lab2
{
    public partial class Lab2b : Form
    {
        public Lab2b()
        {
            InitializeComponent();
        }

        private void rb_Cloudy_CheckedChanged(object sender, EventArgs e)
        {
            resetPic("Cloudy", pic_Cloudy);

        }

        private void rb_Rainy_CheckedChanged(object sender, EventArgs e)
        {
            resetPic("Rainy", pic_Rainy);
        }

        private void rb_Snowy_CheckedChanged(object sender, EventArgs e)
        {
            resetPic("Snowy", pic_Snowy);
        }

        private void rb_Sunny_CheckedChanged(object sender, EventArgs e)
        {
            resetPic("Sunny", pic_Sunny);
        }

        private void resetPic(String weather, PictureBox pic) {
            pic_Cloudy.Visible = false;
            pic_Rainy.Visible = false;
            pic_Snowy.Visible = false;
            pic_Sunny.Visible = false;
            pic.Visible = true;
            lb_Message.Text = $"It’s going to be a {weather} day today, {lb_Message.Text}.";
        }
    }
}
