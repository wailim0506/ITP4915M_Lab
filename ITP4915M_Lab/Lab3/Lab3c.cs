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

        private void MoveListBoxItems(ListBox source, ListBox destination)
        {
            ListBox.SelectedObjectCollection sourceItems = source.SelectedItems;
            foreach (var item in sourceItems)
            {
                destination.Items.Add(item);
            }
            while (source.SelectedItems.Count > 0)
            {
                source.Items.Remove(source.SelectedItems[0]);
            }
        }

        private void btn_right_Click(object sender, EventArgs e)
        {
            MoveListBoxItems(lst_Shop, listBox2);
        }

        private void btn_left_Click(object sender, EventArgs e)
        {
            MoveListBoxItems(listBox2, lst_Shop);
        }

        private void btn_count_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Total: {lst_Shop.Items.Count + listBox2.Items.Count}", "Caption", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Yes");
            }
            else if (result == DialogResult.Yes)
            {
                MessageBox.Show("No");
            }
            else {
                MessageBox.Show("Cacnel");
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            while (listBox2.Items.Count>0)
            {
                listBox2.Items.Remove(listBox2.Items[0]);
            }
        }
    }
}
