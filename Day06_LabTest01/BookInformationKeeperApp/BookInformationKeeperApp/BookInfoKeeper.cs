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

namespace BookInformationKeeperApp
{
    public partial class BookInfoKeeper : Form
    {
        public BookInfoKeeper()
        {
            InitializeComponent();
        }

        //Dictionary<long, string> bookInfo = new Dictionary<long, string>(); 
        Dictionary<string, string> bookInfo = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

        private void addButton_Click(object sender, EventArgs e)
        {
            string isbnNumber = isbnTextBox.Text;
            int isbnLength = isbnNumber.Length;

            if (String.IsNullOrWhiteSpace(isbnTextBox.Text) || String.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                MessageBox.Show("Please insert value !");
            }

            else
            {
                if (isbnLength != 13)
                {
                    MessageBox.Show("Please insert 13 digit valid ISBN number");
                }

                else
                {
                    //long isbn = long.Parse(isbnNumber);
                    //string isbn = isbnTextBox.Text;

                    List<string> bookKeys = bookInfo.Keys.ToList();


                    if (bookKeys.Contains(isbnNumber))
                    {
                        MessageBox.Show("Already added!");
                    }
                    else
                    {
                        string bookName = nameTextBox.Text;
                        bookInfo.Add(isbnNumber, bookName);

                        addListBox.Items.Add(isbnTextBox.Text);
                        addListBox.Items.Add(nameTextBox.Text);
                    }


                }
            }

            ClearTextBox();
            isbnTextBox.Focus();

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (isbnRadioButton.Checked == true)
            {
                //long isbn = long.Parse(searchTextBox.Text);

                string isbn = searchTextBox.Text;

                if (String.IsNullOrWhiteSpace(isbn))
                {
                    MessageBox.Show("Enter ISBN!");
                }

                else
                {
                    List<string> bookKeys = bookInfo.Keys.ToList();

                    if (bookKeys.Contains(isbn))
                    {
                        searchListBox.Items.Add(bookInfo[isbn]);
                    }

                    else
                    {
                        MessageBox.Show("ISBN doesn't match!");
                    }
                }



                searchTextBox.Clear();
            }

            else if (nameRadioButton.Checked == true)
            {

                string bookName = searchTextBox.Text;

                if (String.IsNullOrWhiteSpace(bookName))
                {
                    MessageBox.Show("Enter book name!");
                }

                else
                {
                    List<string> bookValues = bookInfo.Values.ToList();

                    if (bookValues.Contains(bookName, StringComparer.OrdinalIgnoreCase))
                    {
                        searchListBox.Items.Add(bookName);
                    }

                    //foreach (string data in bookInfo.Values)
                    //{
                    //    if (data.ToLower().Contains(bookName))
                    //    {
                    //        searchListBox.Items.Add(data);
                    //    }



                    else
                    {
                        MessageBox.Show("Bookname doesn't match!");
                    }


                }

                searchTextBox.Clear();
            }


            else
            {
                MessageBox.Show("Check any item!");
                searchTextBox.Clear();
            }

        }

        private void ClearTextBox()
        {
            isbnTextBox.Clear();
            nameTextBox.Clear();

        }
    }
}
