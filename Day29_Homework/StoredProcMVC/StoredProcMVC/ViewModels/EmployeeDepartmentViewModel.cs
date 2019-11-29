using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StoredProcMVC.ViewModels
{
    public class EmployeeDepartmentViewModel
    {
        public EmployeeDepartmentViewModel(int employeeId, string employeeName, string designation, string nID, DateTime joiningDate, string bloodGroup, int departmentId, string departmentName, string code)
        {
            EmployeeId = employeeId;
            EmployeeName = employeeName;
            Designation = designation;
            NID = nID;
            JoiningDate = joiningDate;
            BloodGroup = bloodGroup;
            DepartmentId = departmentId;
            DepartmentName = departmentName;
            Code = code;
        }

        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string Designation { get; set; }
        public string NID { get; set; }
        public DateTime JoiningDate { get; set; }
        public string BloodGroup { get; set; }
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string Code { get; set; }
        
    }
}