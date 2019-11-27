using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StoredProcMVC.Models
{
    public class Employee
    {
        private int deptId;

        public Employee(int employeeId, string name, string designation, string nid, DateTime joiningDate, string bloodGroup, int deptId)
        {
            EmployeeId = employeeId;
            Name = name;
            Designation = designation;
            NID = nid;
            JoiningDate = joiningDate;
            BloodGroup = bloodGroup;
            this.deptId = deptId;
        }

        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public string NID { get; set; }
        public DateTime JoiningDate { get; set; }
        public string BloodGroup { get; set; }
        public int Department { get; set; }
    }
}