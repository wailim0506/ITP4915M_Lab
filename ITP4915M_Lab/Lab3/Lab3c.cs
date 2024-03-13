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
    public partial class Lab3c : Form
    {
        public Lab3c()
        {
            InitializeComponent();
        }

        private void Lab3c_Load(object sender, EventArgs e)
        {
            lst_Shop.Items.Add("Apple");
            lst_Shop.Items.Add("Banana");
            lst_Shop.Items.Add("Grape");
            lst_Shop.Items.Add("Orange");
            lst_Shop.Items.Add("Peach");
            lst_Shop.Items.Add("Pear");
            lst_Shop.Items.Add("Pineapple");
        }
    }
}
