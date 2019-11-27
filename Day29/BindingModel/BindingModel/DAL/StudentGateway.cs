using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using BindingModel.Models;
using System.Data.SqlClient;

namespace BindingModel.DAL
{
    public class StudentGateway
    {
        public string connString = WebConfigurationManager.ConnectionStrings["STDB"].ConnectionString;

        public List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();
            SqlConnection con = new SqlConnection(connString);
            string query = "SELECT * FROM Students";
            SqlCommand command = new SqlCommand(query, con);
            con.Open();

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string name = reader["Name"].ToString();
                string city = reader["City"].ToString();
                int age = Convert.ToInt32(reader["Age"]);

                Student student = new Student(name, city, age);
                students.Add(student);
            }

            reader.Close();
            con.Close();

            return students;
        }

    }
}