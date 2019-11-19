using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using InformationManagement.Models;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace InformationManagement.DAL
{
    public class StudentGateway
    {
        string connectionString = WebConfigurationManager.ConnectionStrings["IMDB"].ConnectionString;

        public bool SaveStudent(Student student)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "INSERT INTO " +
                           "Student_tbl(StudentName, RegNo," +
                           " Email, MobileNo, Age, Address)" +
                           "VALUES('" + student.StudentName + "','" + student.RegNo + "'," +
                           "'" + student.EmailAddress + "','" + student.MobileNo + "'," +
                           "" + student.Age + ",'" + student.Address + "')";

            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            int rowEffect = command.ExecuteNonQuery();
            connection.Close();

            if (rowEffect > 0)
            {
                return true;
            }

            return false;
        }

        public bool ExistStudent(Student student)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT * FROM Student_tbl WHERE RegNo = '" + student.RegNo + "'";

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            Student aStudent = null;
            while (reader.Read())
            {
                aStudent = new Student();

                aStudent.StudentId = Convert.ToInt32(reader["StudentId"]);
                aStudent.StudentName = reader["StudentName"].ToString();
                aStudent.RegNo = reader["RegNo"].ToString();
                aStudent.EmailAddress = reader["Email"].ToString();
                aStudent.MobileNo = reader["MobileNo"].ToString();
                aStudent.Age = Convert.ToInt32(reader["Age"]);
                aStudent.Address = reader["Address"].ToString();
            }

            reader.Close();
            connection.Close();

            if (aStudent != null)
            {
                return true;
            }

            return false;
        }

        public List<Student> GetAllStudents()
        {
            List<Student> studentList = new List<Student>();

            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM Student_tbl";
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

            return studentList;
        }

        public bool UpdateStudent(Student student)
        {

            SqlConnection connection = new SqlConnection(connectionString);
            string query = @"UPDATE Student_tbl SET StudentName = '" + student.StudentName + "', Email = '" + student.EmailAddress + "', MobileNo = '" + student.MobileNo + "', Address = '" + student.Address + "', Age = " + student.Age + "WHERE RegNo = '" + student.RegNo + "';";

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            int rowEffect = command.ExecuteNonQuery();
            connection.Close();

            if (rowEffect > 0)
            {
                return true;
            }

            return false;
        }

        public bool DeleteStudent(Student student) 
        {

            SqlConnection connection = new SqlConnection(connectionString);
            string query = @"DELETE FROM Student_tbl WHERE RegNo = '" + student.RegNo + "';";

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            int rowEffect = command.ExecuteNonQuery();
            connection.Close();

            if (rowEffect > 0)
            {
                return true;
            }

            return false;
        }
    }

}
