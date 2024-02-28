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
            pic_Cloudy.Visible = true;
            pic_Rainy.Visible = false;
            pic_Snowy.Visible = false;
            pic_Sunny.Visible = false;
            lb_Message.Text = $"It’s going to be a cloudy day today, {lb_Message.Text}.";

        }

        private void rb_Rainy_CheckedChanged(object sender, EventArgs e)
        {
            pic_Cloudy.Visible = false;
            pic_Rainy.Visible = true;
            pic_Snowy.Visible = false;
            pic_Sunny.Visible = false;
            lb_Message.Text = $"It’s going to be a rainy day today, {lb_Message.Text}.";
        }

        private void rb_Snowy_CheckedChanged(object sender, EventArgs e)
        {
            pic_Cloudy.Visible = false;
            pic_Rainy.Visible = false;
            pic_Snowy.Visible = true;
            pic_Sunny.Visible = false;
            lb_Message.Text = $"It’s going to be a snowy day today, {lb_Message.Text}.";
        }

        private void rb_Sunny_CheckedChanged(object sender, EventArgs e)
        {
            pic_Cloudy.Visible = false;
            pic_Rainy.Visible = false;
            pic_Snowy.Visible = false;
            pic_Sunny.Visible = true;
            lb_Message.Text = $"It’s going to be a sunny day today, {lb_Message.Text}."; 
        }
    }
}
