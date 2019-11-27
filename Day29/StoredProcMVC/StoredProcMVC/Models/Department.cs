using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StoredProcMVC.Models
{
    public class Department
    {
        public Department(int departmentId, string code, string name)
        {
            DepartmentId = departmentId;
            Code = code;
            Name = name;
        }

        public int DepartmentId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
    }
}