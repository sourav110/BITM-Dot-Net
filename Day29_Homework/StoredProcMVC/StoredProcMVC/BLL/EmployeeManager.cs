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
            if (!IsEmployeeExist(employee))
            {
                return employeeGateway.SaveEmployee(employee);
            }
            return false;
        }

        public bool IsEmployeeExist(Employee employee)
        {
            var employeeList = GetEmployees();
            return employeeList.Any(emp => emp.NID == employee.NID);
        }
    }
}