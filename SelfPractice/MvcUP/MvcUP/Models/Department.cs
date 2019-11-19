using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcUP.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string DeptName { get; set; }
        public string Code { get; set; }
        public string Address { get; set; }
    }
}