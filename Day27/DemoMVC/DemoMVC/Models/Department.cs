using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoMVC.Models
{
    public class Department
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public List<Department> departments { get; set; }
    }
}