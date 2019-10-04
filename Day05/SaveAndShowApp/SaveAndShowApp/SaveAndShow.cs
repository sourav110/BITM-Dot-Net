using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaveAndShowApp
{
    public partial class Form1 : Form
    {
        List<string> nameList = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                MessageBox.Show("Please Enter Name");
            }
            else
            {
                nameList.Add(nameTextBox.Text);
                ClearTextBox();
            }
        }


        private void ClearTextBox()
        {
            nameTextBox.Clear();
        }

      
        private void showAllButton_Click(object sender, EventArgs e)
        {
            foreach (var item in nameList)
            {
                showListBox.Items.Add(item);
            }

            totalTextBox.Text = nameList.Count().ToString();
        }

        private void clearAllButton_Click(object sender, EventArgs e)
        {
            
            totalTextBox.Clear();
            showListBox.Items.Clear();

        }
    }
}
