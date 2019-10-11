using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentInfoManagementWebApp
{
    public partial class StudentInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void saveButton_Click(object sender, EventArgs e)
        {

            Student aStudent = new Student();

            aStudent.FirstName = firstNameTextBox.Text;
            aStudent.LastName = lastNameTextBox.Text;
            aStudent.UserName = userNameTextBox.Text;
            aStudent.RegNo = regNoTextBox.Text;
            aStudent.Email = emailTextBox.Text;
            aStudent.Age = Convert.ToInt32(ageTextBox.Text);
            //aStudent.Age = int.Parse(ageTextBox.Text);

            ViewState["Student"] = aStudent;
            ClearInput();

            messageLabel.Text = "Student info saved";
            messageLabel.ForeColor = System.Drawing.Color.Green;


        }

        protected void showButton_Click(object sender, EventArgs e)
        {
            Student viewStudent = (Student)ViewState["Student"];

            if(viewStudent != null)
            {
                firstNameLabel.Text = viewStudent.FirstName;
                lastNameLabel.Text = viewStudent.LastName;
                userNameLabel.Text = viewStudent.UserName;
                regNoLabel.Text = viewStudent.RegNo;
                emailLabel.Text = viewStudent.Email;
                ageLabel.Text = viewStudent.Age.ToString();

                fullNameLabel.Text = viewStudent.GetFullName();
            }

            else
            {
                messageLabel.Text = "Student not found";
                messageLabel.ForeColor = System.Drawing.Color.Red;
            }

        }

        private void ClearInput()
        {
            firstNameTextBox.Text = String.Empty;
            lastNameTextBox.Text = String.Empty;
            userNameTextBox.Text = String.Empty;
            regNoTextBox.Text = String.Empty;
            emailTextBox.Text = String.Empty;
            ageTextBox.Text = String.Empty;
        }

        protected void nextPageButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("StudentInfoList.aspx");
        }
    }
}