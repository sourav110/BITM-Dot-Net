using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StoredProcMVC.Models;
using StoredProcMVC.DAL;

namespace StoredProcMVC.BLL
{
    public class DepartmentManager
    {
        DepartmentGateway departmentGateway = new DepartmentGateway();
        
        public List<Department> GetDepartments()
        {
            return departmentGateway.GetDepartments();
        }
    }
}