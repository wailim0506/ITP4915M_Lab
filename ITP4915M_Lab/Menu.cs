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

        private void button1_Click(object sender, EventArgs e)
        {
            Lab1 lab1 = new Lab1();
            lab1.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {   Lab2.Lab2a lab2a = new Lab2.Lab2a();
            lab2a.ShowDialog();
        }
    }
}
