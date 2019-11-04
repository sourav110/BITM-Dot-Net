using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DateTimeApp.Models;
using DateTimeApp.DAL;
using DateTimeApp.BLL;


namespace DateTimeApp
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }
        private PersonManager personManager = new PersonManager();

        private void saveButton_Click(object sender, EventArgs e)
        {
            Person person = new Person();
            person.Name = nameTextBox.Text;
            person.Age = Convert.ToInt32(ageTextBox.Text);
            person.Date = DateTime.Today;

            string message = personManager.SavePerson(person);

            MessageBox.Show(message);

            ClearTextBox();
        }

        private void ClearTextBox()
        {
            nameTextBox.Text = String.Empty;
            ageTextBox.Text = String.Empty;
        }
    }
}
