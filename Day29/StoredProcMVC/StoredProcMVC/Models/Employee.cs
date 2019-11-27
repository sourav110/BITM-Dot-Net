using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StoredProcMVC.Models
{
    public class Employee
    {
        public Employee(int employeeId, string name, string designation, string nID, DateTime joiningDate, string bloodGroup, int departmentId)
        {
            EmployeeId = employeeId;
            Name = name;
            Designation = designation;
            NID = nID;
            JoiningDate = joiningDate;
            BloodGroup = bloodGroup;
            DepartmentId = departmentId;
        }

        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public string NID { get; set; }
        public DateTime JoiningDate { get; set; }
        public string BloodGroup { get; set; }
        public int DepartmentId { get; set; }
    }
}