using StoredProcMVC.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;


namespace StoredProcMVC.DAL
{
    public class EmployeeGateway
    {
        private string conString = WebConfigurationManager.ConnectionStrings["StoredDb"].ConnectionString;

        public List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();

            SqlConnection connection = new SqlConnection(conString);
            SqlCommand command = new SqlCommand("sPGetEmployees", connection);
            command.CommandType = CommandType.StoredProcedure;
            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int employeeId = Convert.ToInt32(reader["EmployeeId"]);
                string name = reader["Name"].ToString();
                string designation = reader["Designation"].ToString();
                string nid = reader["NID"].ToString();
                DateTime joiningDate = Convert.ToDateTime(reader["JoiningDate"]);
                string bloodGroup = reader["BloodGroup"].ToString();
                int deptId = Convert.ToInt32(reader["DepartmentId"]);

                Employee employee = new Employee(employeeId, name, designation, nid, joiningDate, bloodGroup, deptId);
                employees.Add(employee);
            }

            reader.Close();
            connection.Close();

            return employees;
        }

        public bool SaveEmployee(Employee employee)
        {
            SqlConnection connection = new SqlConnection(conString);
            SqlCommand command = new SqlCommand("sPSaveEmloyee", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Clear();
            command.Parameters.AddWithValue("@Name", employee.Name);
            command.Parameters.AddWithValue("@Designation", employee.Designation);
            command.Parameters.AddWithValue("@NID", employee.NID);
            command.Parameters.AddWithValue("@JoiningDate", employee.JoiningDate);
            command.Parameters.AddWithValue("@BloodGroup", employee.BloodGroup);
            command.Parameters.AddWithValue("@DepartmentId", employee.DepartmentId);

            connection.Open();
            int rowAffected = command.ExecuteNonQuery();
            connection.Close(); 

            if(rowAffected > 0)
            {
                return true;
            }

            return false;
        }
    }
}