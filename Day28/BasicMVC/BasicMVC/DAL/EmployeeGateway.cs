using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using BasicMVC.Models;

namespace BasicMVC.DAL
{
    public class EmployeeGateway
    {
        //private string connectionString = WebConfigurationManager.ConnectionStrings["EmployeeDBMVC"].ConnectionString;


        string connectionString = WebConfigurationManager.ConnectionStrings["EmployeeDBMVC"].ConnectionString;
        public List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();

            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM Employees";
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int employeeId = Convert.ToInt32(reader["EmployeeId"]);
                string name = reader["Name"].ToString();
                int age = Convert.ToInt32(reader["Age"]);

                Employee employee = new Employee(employeeId, name, age);
                employees.Add(employee);
            }

            reader.Close();
            connection.Close();

            return employees;
        }

    }
}