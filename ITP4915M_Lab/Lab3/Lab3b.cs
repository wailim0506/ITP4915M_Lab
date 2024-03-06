using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915M_Lab.Lab3
{
    public partial class Lab3b : Form
    {
        public Lab3b()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lab3b_Load(object sender, EventArgs e)
        {

        }

        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(txt_Amount.Text);
            double rate = Convert.ToDouble(txt_InterestRate.Text);
            double total = amount;

            for (int i = 0; i < 10; i++) {
                total = total * (1 + rate);
            }

            lb_Value10Year.Text = total.ToString();

            ////method 2:
            //total = amount * Math.Pow(1 + rate, 10);
            //lb_Value10Year.Text = total.ToString();
        }
    }
}
