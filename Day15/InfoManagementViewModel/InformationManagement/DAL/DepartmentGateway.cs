﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using InformationManagement.Models;


namespace InformationManagement.DAL
{
    public class DepartmentGateway
    {

        string connectionString = WebConfigurationManager.ConnectionStrings["IMDB"].ConnectionString;

        public List<Department> GetAllDepartmentFromDB()
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = @"SELECT * FROM Department_tbl"; 

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            List<Department> departmentList = new List<Department>();

            while (reader.Read())
            {
                Department department = new Department();

                department.DepartmentId = Convert.ToInt32(reader["DepartmentId"]);
                department.DeptName = reader["DeptName"].ToString();
                department.DeptCode = reader["DeptCode"].ToString();

                departmentList.Add(department);
            }

            reader.Close();
            connection.Close();

            return departmentList;
        }
    }
}