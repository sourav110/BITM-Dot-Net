using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentInfoManagementWebApp
{
    public partial class StudentInfoList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            List<Student> studentList = new List<Student>();

            Student bStudent = new Student();

            bStudent.FirstName = firstNameTextBox.Text;
            bStudent.LastName = lastNameTextBox.Text;
            bStudent.UserName = userNameTextBox.Text;
            bStudent.RegNo = regNoTextBox.Text;
            bStudent.Email = emailTextBox.Text;
            bStudent.Age = Convert.ToInt32(ageTextBox.Text);

            

            if(ViewState["Student List"] != null)
            {
                studentList = (List<Student>)ViewState["Student List"]; 
            }

            studentList.Add(bStudent);
            ViewState["Student List"] = studentList;


            messageLabel.Text = "Student info saved";
            messageLabel.ForeColor = System.Drawing.Color.Green;


            ClearInput();

        }

        protected void showButton_Click(object sender, EventArgs e)
        {
            //studentListBox.Items.Clear();

            List<Student> viewStudentList = new List<Student>();

            viewStudentList = (List<Student>)ViewState["Student List"];

            //if(viewStudentList != null)
            //{
                foreach(Student data in viewStudentList)
                {
                    studentListBox.Items.Add("First Name: " + data.FirstName);
                    studentListBox.Items.Add("Last Name: " + data.LastName);
                    studentListBox.Items.Add("User Name: " + data.UserName);
                    studentListBox.Items.Add("Registration No: " + data.RegNo);
                    studentListBox.Items.Add("Email: " + data.Email);
                    studentListBox.Items.Add("Age: " + data.Age);

                    studentListBox.Items.Add(" ");
                }
                
            //}

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
    }
}