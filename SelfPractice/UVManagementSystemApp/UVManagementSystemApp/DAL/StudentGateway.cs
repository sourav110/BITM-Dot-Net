using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UVManagementSystemApp.Models;

namespace UVManagementSystemApp.DAL
{
    class StudentGateway
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["UVMSDB"].ConnectionString;

        public int SaveStudent(Student student)
        {
            //string connectionString = @"Server = RDFOX; Database = UVManagementSystemDB; Integrated Security = true;";

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "INSERT INTO Students (StudentName, RegNo, PhoneNo, Email, Department) VALUES ('"+student.StudentName+"', '"+student.RegNo+"', '"+student.PhoneNo+"', '"+student.Email+"', '"+student.Department+"')";

            SqlCommand command = new SqlCommand(query, connection);
            int rowEffect = command.ExecuteNonQuery();
            connection.Close();

            return rowEffect;
        }

        public bool IsRegNoExist(string regNo)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            string query = "SELECT * FROM Students WHERE RegNo = '"+ regNo +"'";
            SqlCommand command = new SqlCommand();
            command.CommandText = query;
            command.Connection = connection;
            connection.Open();

            SqlDataReader reader = command.ExecuteReader();
            bool isExist = reader.HasRows;

            reader.Close();
            connection.Close();

            return isExist;
        }

        public List<Student> GetAllStudentsFromDB()
        {
            List<Student> students = new List<Student>();

            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM Students";
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Student student = new Student();

                student.StudentId = Convert.ToInt32(reader["StudentId"]);
                student.StudentName = reader["StudentName"].ToString();
                student.RegNo = reader["RegNo"].ToString();
                student.PhoneNo = reader["PhoneNo"].ToString();
                student.Email = reader["Email"].ToString();
                student.Department = reader["Department"].ToString();

                students.Add(student);
            }

            reader.Close();
            connection.Close();

            return students;
        }
    }
}
