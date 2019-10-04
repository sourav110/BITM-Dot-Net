using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListViewApp
{
    public partial class ListViewApp : Form
    {
        public ListViewApp()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {

            if(String.IsNullOrWhiteSpace(nameTextBox.Text) || String.IsNullOrWhiteSpace(emailTextBox.Text) || String.IsNullOrWhiteSpace(contactTextBox.Text))
            {
                MessageBox.Show("Please enter value!");
            }

            else
            {
                ListViewItem item = new ListViewItem();

                //item.SubItems.Add(nameTextBox.Text);
                item.Text = nameTextBox.Text;
                item.SubItems.Add(emailTextBox.Text);
                item.SubItems.Add(contactTextBox.Text);

                detailsListView.Items.Add(item);

                ClearTextBox();
            }

           
        }

        private void ClearTextBox()
        {
            nameTextBox.Clear();
            emailTextBox.Clear();
            contactTextBox.Clear();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            detailsListView.Items.Clear();
            ClearTextBox();
        }

        private void detailsListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            ListViewItem item = detailsListView.SelectedItems[0];

            string name = item.Text;
            string email = item.SubItems[1].Text;
            string contact = item.SubItems[2].Text;

            MessageBox.Show("Name: " + name + "\nEmail: " + email + "\nContact:" + contact);
        }

    }
}
