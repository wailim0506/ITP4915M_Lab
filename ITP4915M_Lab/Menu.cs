using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915M_Lab
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Lab1 lab1 = new Lab1();
            lab1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lab2.Lab2a lab2a = new Lab2.Lab2a();
            lab2a.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Lab2.Lab2b lab2b = new Lab2.Lab2b();
            lab2b.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Lab2.Lab2c lab2c = new Lab2.Lab2c();
            lab2c.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Lab3.Lab3a lab3a = new Lab3.Lab3a();
            lab3a.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Lab3.Lab3b lab3b = new Lab3.Lab3b();
            lab3b.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Lab3.Lab3c lab3c = new Lab3.Lab3c();
            lab3c.ShowDialog();
        }
    }
}
