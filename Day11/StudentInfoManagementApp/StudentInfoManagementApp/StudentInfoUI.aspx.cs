using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StudentInfoManagementApp.Models;

namespace StudentInfoManagementApp
{
    public partial class StudentInfoUI : System.Web.UI.Page
    {
        public object SSqlConnection { get; private set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            ShowAllStudentInfo();
        }
       

        protected void saveButton_Click(object sender, EventArgs e)
        {
            string studentName = inputStudentName.Value;
            string regNo = inputRegNo.Value;
            string email = inputEmail.Value;
            string mobileNo = inputMobile.Value;
            int age = Convert.ToInt32(inputAge.Value);
            string address = inputAddress.Value;

            Student student = new Student(studentName, regNo, email, mobileNo, age, address);

            string connectionString = @"Server = RDFOX; Database = StudentInfoDB; Integrated Security = true;";

            SqlConnection connection = new SqlConnection(connectionString);

            string query = "INSERT INTO Student_tbl (StudentName, RegNo, Email, MobileNo, Age, Address) VALUES('"+student.StudentName+"', '"+student.RegNo+"', '"+student.Email+"', '"+student.MobileNo+"', "+student.Age+" , '"+student.Address+"')";

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            int rowEffect = command.ExecuteNonQuery();
            connection.Close();

            if(rowEffect > 0)
            {
                messageLabel.Text = String.Empty;
                messageLabel.Text = "Studenet info saved!";
                messageLabel.ForeColor = System.Drawing.Color.Green;
                ClearField();
                ShowAllStudentInfo();
            }

            else
            {
                messageLabel.Text = String.Empty;
                messageLabel.Text = "Failed to saved!";
                messageLabel.ForeColor = System.Drawing.Color.Red;
            }

        }

        private void ShowAllStudentInfo()
        {
            List<Student> studentList = new List<Student>();

            string connectionString = @"Server = RDFOX; Database = StudentInfoDB; Integrated Security = true;";

            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT * FROM Student_tbl ORDER BY StudentID DESC";
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int studentId = (int)reader["StudentId"];
                string studentName = reader["StudentName"].ToString();
                string regNo = reader["RegNo"].ToString();
                string email = reader["Email"].ToString();
                string mobileNo = reader["MobileNo"].ToString();
                int age = (int)reader["Age"];
                string address = reader["Address"].ToString();

                Student student = new Student(studentName, regNo, email, mobileNo, age, address);
                student.StudentId = studentId;

                studentList.Add(student);
            }

            reader.Close();
            connection.Close();

            StudentGridView.DataSource = studentList;
            StudentGridView.DataBind();
        }


        protected void ClearField()
        {
            inputStudentName.Value = String.Empty;
            inputRegNo.Value = String.Empty;
            inputEmail.Value = String.Empty;
            inputMobile.Value = String.Empty;
            inputAge.Value = String.Empty;
            inputAddress.Value = String.Empty;
        }
    }
}