using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FullNameWebApp
{
    public partial class FullName : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void showButton_Click(object sender, EventArgs e)
        {
            string firstName = firstNameTextBox.Text;
            string lastName = lastNameTextBox.Text;

            string fullName = firstName + " " + lastName;

            fullNameTextBox.Text = fullName;

            ClearTextBox();
        }

        private void ClearTextBox()
        {
            firstNameTextBox.Text = String.Empty;
            lastNameTextBox.Text = String.Empty;
            
        }
    }
}