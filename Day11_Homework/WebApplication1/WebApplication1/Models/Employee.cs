using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName {get; set; }
        public string EmployeeEmail {get; set; }
        public string Gender {get; set; }
        public string DateOfJoin {get; set; }
        public string Designation {get; set; }
        public double Salary {get; set; }

        public Employee(string employeeName, string employeeEmail, string gender, string dateOfJoin, string designation, double salary)
        {
            this.EmployeeName = employeeName;
            this.EmployeeEmail = employeeEmail;
            this.Gender = gender;
            this.DateOfJoin = dateOfJoin;
            this.Designation = designation;
            this.Salary = salary;
        }
    }
}