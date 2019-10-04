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

namespace BookListApp
{
    public partial class BookDatabase : Form
    {

        Hashtable bookList = new Hashtable(); 

        public BookDatabase()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(infoIsbnTextBox.Text) || String.IsNullOrWhiteSpace(infoDetailsTextBox.Text))
            {
                MessageBox.Show("Please Enter ISBN no. and Book details!");
            }

            else
            {
                bookList.Add(infoIsbnTextBox.Text, infoDetailsTextBox.Text);
                Clear();
            }
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            foreach(var key in bookList.Keys)
            {
                string value = Convert.ToString(bookList[key]);

                if (String.IsNullOrWhiteSpace(searchIsbnTextBox.Text))
                {
                    MessageBox.Show("Please enter ISBN no!");
                }

                else
                {
                    if(searchIsbnTextBox.Text == Convert.ToString(key))
                    {
                        searchDetailsTextBox.Text = value;
                    }

                    else
                    {
                        MessageBox.Show("Details not found, Please enter valid ISBN no!");
                    }
                }
            }
        }

        private void Clear()
        {
            infoIsbnTextBox.Clear();
            infoDetailsTextBox.Clear();
        }

        
    }
}
