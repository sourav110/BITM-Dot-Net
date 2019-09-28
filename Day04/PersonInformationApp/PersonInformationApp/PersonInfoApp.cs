using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonInformationApp
{
    public partial class PersonInfoApp : Form
    {

        private string firstName;
        private string lastName;
        private string fatherName;
        private string motherName;
        private string address;

        public PersonInfoApp()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            firstName = firstNameTextBox.Text;
            lastName = lastNameTextBox.Text;
            fatherName = fathersNameTextBox.Text;
            motherName = mothersNameTextBox.Text;
            address = addressTextBox.Text;

            MessageBox.Show("All information successfully saved!");
            ClearTextBox();
        }

        private void showAllInfoButton_Click(object sender, EventArgs e)
        {
            firstNameTextBox.Text = firstName;
            lastNameTextBox.Text = lastName;
            fathersNameTextBox.Text = fatherName;
            mothersNameTextBox.Text = motherName;
            addressTextBox.Text = address;

        }

        private void nameButton_Click(object sender, EventArgs e)
        {
            ClearTextBox();
            firstNameTextBox.Text = firstName;
            lastNameTextBox.Text = lastName;
        }

        private void parentsNameButton_Click(object sender, EventArgs e)
        {
            ClearTextBox();
            fathersNameTextBox.Text = fatherName;
            mothersNameTextBox.Text = motherName;
        }

        private void addressButton_Click(object sender, EventArgs e)
        {
            ClearTextBox();
            addressTextBox.Text = address;
        }

        public void ClearTextBox()
        {
            firstNameTextBox.Clear();
            lastNameTextBox.Clear();
            fathersNameTextBox.Clear();
            mothersNameTextBox.Clear();
            addressTextBox.Clear();
        }

       
    }
}
