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
    public partial class Lab2c : Form
    {
        public Lab2c()
        {
            InitializeComponent();
        }

        private void Lab2c_Load(object sender, EventArgs e)
        {
            lst_Student.Items.Add("Mary Chu");
            lst_Student.Items.Add("Peter Lee");
            lst_Student.Items.Add("Johnson Chan");
            lst_Student.Items.Add("Alex Leung");

        }

        private void lb_Delete_Click(object sender, EventArgs e)
        {
            String name = lst_Student.SelectedItem.ToString();
            lst_Student.Items.Remove(lst_Student.SelectedItem);
            lb_Message.Text = "The following item is deleted: " + name;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {

        }

        private void lst_Student_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
