using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BasicMVC.Models
{
    public class Employee
    {
        public Employee(int employeeId, string name, int age)
        {
            EmployeeId = employeeId;
            Name = name;
            Age = age;
        }

        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

    }
}