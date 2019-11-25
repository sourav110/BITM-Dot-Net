using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoMVC.Models
{
    public class Employee
    {
        public Employee(int employeeId, string name, string designation, int age)
        {
            EmployeeId = employeeId;
            Name = name;
            Designation = designation;
            Age = age;
        }

        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public int Age { get; set; }
    }
}