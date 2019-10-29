using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InformationManagement.Models.ViewModels
{
    public class DepartmentWiseStudentView
    {
        public string Name { get; set; }
        public string RegNo { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string DeptName { get; set; }
        public string DeptCode { get; set; }
    }
}