using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Models;
using System.Data.SqlClient;

namespace WebApplication1.Master_Pages
{
    public partial class EmployeeInfoUi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            dateOfJoinCalendar.Visible = false;
            maleRadioButton.Checked = true;
           
        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            string employeeName = inputEmployeeName.Value;
            string employeeEmail = inputEmployeeEmail.Value;
            //string gender = genderRadioButton.DataSource;
            string gender = "";
            string dateOfJoin = inputDoJ.Value;
            string designation = inputDesignation.Value;
            double salary = Convert.ToDouble(inputSalary.Value);


            if (maleRadioButton.Checked)
            {
                gender = maleRadioButton.Text;
            }
            else
            {
                gender = femaleRadioButton.Text;
            }

            Employee employee = new Employee(employeeName, employeeEmail, gender, dateOfJoin, designation, salary);           

            string connectionString = @"Server = RDFOX; Database = InfoManagementDB; Integrated Security = true;";

            SqlConnection connection = new SqlConnection(connectionString);

            string query = "INSERT INTO Employee_tbl (Employee_Name, Employee_Email, Gender, Date_of_Join, Designation, Salary) VALUES('" + employee.EmployeeName + "', '" + employee.EmployeeEmail + "', '" + employee.Gender + "', '" + employee.DateOfJoin + "', " + employee.Designation + " , '" + employee.Salary + "')";

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            int rowEffect = command.ExecuteNonQuery();
            connection.Close();


            if (rowEffect > 0)
            {
                messageLabel.Text = String.Empty;
                messageLabel.Text = "Studenet info saved!";
                messageLabel.ForeColor = System.Drawing.Color.Green;
                ClearField();
                ShowAllEmployeeInfo();
            }

            else
            {
                messageLabel.Text = String.Empty;
                messageLabel.Text = "Failed to saved!";
                messageLabel.ForeColor = System.Drawing.Color.Red;
            }

        }

        protected void ClearField()
        {
            inputEmployeeName.Value = String.Empty;
            inputEmployeeEmail.Value = String.Empty;
            inputDoJ.Value = String.Empty;
            inputDesignation.Value = String.Empty;
            inputSalary.Value = String.Empty;
        }

        private void ShowAllEmployeeInfo()
        {

        }

        protected void calendarImageButton_Click(object sender, ImageClickEventArgs e)
        {
            if(dateOfJoinCalendar.Visible == false)
            {
                dateOfJoinCalendar.Visible = true;
            }

            dateOfJoinCalendar.Visible = true;
        }

        protected void dateOfJoinCalendar_SelectionChanged(object sender, EventArgs e)
        {
            //string doJ = inputDoJ.Value;
            dateOfJoinCalendar.Visible = false;
        }


    }
}