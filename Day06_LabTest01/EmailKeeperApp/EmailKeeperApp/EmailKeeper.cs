using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmailKeeperApp
{
    public partial class EmailKeeper : Form
    {

        List<string> emailList = new List<string>();

        List<string> searchList = new List<string>();

        

        public EmailKeeper()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string email = addTextBox.Text;
            int countAt = 0;
            int countDot = 0;

            foreach(char ch in email)
            {
                if(ch == '@')
                {
                    countAt++;
                }
            }

            foreach(char c in email)
            {
                if(c == '.')
                {
                    countDot++;
                }
            } 
            
            //MessageBox.Show(countAt.ToString());
            //MessageBox.Show(countDot.ToString());

            if(String.IsNullOrWhiteSpace(email) || countAt > 1 || countAt == 0 || countDot == 0)
            {
                MessageBox.Show("Please Enter valid Email");
            }

            else
            {
                emailList.Add(email);
                addListBox.Items.Add(email);
            }

            ClearTextBox();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchEmail = searchTextBox.Text;

            if (emailList.Contains(searchEmail))
            {
                searchListBox.Items.Add(searchEmail);
            }

            else
            {
                MessageBox.Show("Not found!");
            }

            ClearTextBox();

        }

        private void ClearTextBox()
        {
            addTextBox.Clear();
            searchTextBox.Clear();
        }
    }
}
