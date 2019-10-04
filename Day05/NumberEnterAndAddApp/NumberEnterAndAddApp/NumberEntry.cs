using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberEnterAndAddApp
{
    public partial class NumberEntry : Form
    {

        List<int> numberList = new List<int>();

        public NumberEntry()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(numberTextBox.Text))
            {
                MessageBox.Show("Please Enter number!");
            }

            else
            {
                numberList.Add(Convert.ToInt32(numberTextBox.Text));
                numberTextBox.Clear();
            }
            
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            foreach(var item in numberList)
            {
                showListBox.Items.Add(item);
            }

            int sum = 0;

            foreach(var number in numberList)
            {
                sum = sum + number;
            }

            sumTextBox.Text = sum.ToString();
        }

        private void clearAllButton_Click(object sender, EventArgs e)
        {
            numberTextBox.Clear();
            sumTextBox.Clear();
            showListBox.Items.Clear();
        }
    }
}
