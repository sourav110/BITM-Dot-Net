using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using StoredProcMVC.ViewModels;

namespace StoredProcMVC.DAL
{
    public class EmployeeDepartmentGateway
    {
        private string conString = WebConfigurationManager.ConnectionStrings["StoredDb"].ConnectionString;

        public List<EmployeeDepartmentViewModel> GetEmployeeDepartmentViewModels()
        {
            List<EmployeeDepartmentViewModel> employeeDepartmentViewModelList = new List<EmployeeDepartmentViewModel>();

            SqlConnection connection = new SqlConnection(conString);
            SqlCommand command = new SqlCommand("sPGetEmployeesWithDepartment", connection);
            command.CommandType = CommandType.StoredProcedure;
            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int employeeId = Convert.ToInt32(reader["EmployeeId"]);
                string name = reader["EmployeeName"].ToString();
                string designation = reader["Designation"].ToString();
                string nid = reader["NID"].ToString();
                DateTime joiningDate = Convert.ToDateTime(reader["JoiningDate"]);
                string bloodGroup = reader["BloodGroup"].ToString();
                int deptId = Convert.ToInt32(reader["DepartmentId"]);
                string deptName = reader["DepartmentName"].ToString();
                string code = reader["Code"].ToString();

                EmployeeDepartmentViewModel viewModel = new EmployeeDepartmentViewModel(employeeId, name, designation, nid, joiningDate, bloodGroup, deptId, deptName, code);
                employeeDepartmentViewModelList.Add(viewModel);
            }

            reader.Close();
            connection.Close();

            return employeeDepartmentViewModelList;
        }
    }
}