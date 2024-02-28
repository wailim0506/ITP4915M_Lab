using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915M_Lab.Lab2
{
    public partial class Lab2a : Form
    {
        private int price;
        private string payment;

        public Lab2a()
        {
            InitializeComponent();
        }

        private void Lab2a_Load(object sender, EventArgs e)
        {
            rbt_visa.Checked = true;
        }

        private void rbt_RedWine_CheckedChanged(object sender, EventArgs e)
        {
            price = 250;
        }

        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            int total = Convert.ToInt32(textBox_Qty.Text) * price;
            lb_Result.Text = "Total price: " + total + ", Payment Method:" + payment;
        }

        private void lb_Result_Click(object sender, EventArgs e)
        {

        }

        private void rbt_WhiteWine_CheckedChanged(object sender, EventArgs e)
        {
            price = 100;
        }

        private void rbt_Beer_CheckedChanged(object sender, EventArgs e)
        {
            price = 75;
        }

        private void rbt_visa_CheckedChanged(object sender, EventArgs e)
        {
            payment = "Visa";
        }

        private void rbt_master_CheckedChanged(object sender, EventArgs e)
        {
            payment = "Master";
        }
    }
}
