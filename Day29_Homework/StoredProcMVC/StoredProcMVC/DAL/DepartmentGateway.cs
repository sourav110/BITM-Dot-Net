using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using StoredProcMVC.Models;

namespace StoredProcMVC.DAL
{
    public class DepartmentGateway
    {
        private string conString = WebConfigurationManager.ConnectionStrings["StoredDb"].ConnectionString;

        public List<Department> GetDepartments()
        {
            List<Department> departments = new List<Department>();

            SqlConnection connection = new SqlConnection(conString);
            SqlCommand command = new SqlCommand("sPGetDepartments", connection);
            command.CommandType = CommandType.StoredProcedure;
            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int departmentId = Convert.ToInt32(reader["DepartmentId"]);
                string code = reader["Code"].ToString();
                string name = reader["Name"].ToString();

                Department department = new Department(departmentId, code, name);
                departments.Add(department);
            }

            reader.Close();
            connection.Close();

            return departments;
        }
    }
}