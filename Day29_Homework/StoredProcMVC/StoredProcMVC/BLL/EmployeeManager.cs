using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StoredProcMVC.Models;
using StoredProcMVC.DAL;

namespace StoredProcMVC.BLL
{
    public class EmployeeManager
    {
        EmployeeGateway employeeGateway = new EmployeeGateway();

        public List<Employee> GetEmployees()
        {
            return employeeGateway.GetEmployees();
        }

        public bool SaveEmployee(Employee employee)
        {
            return employeeGateway.SaveEmployee(employee);
        }
    }
}