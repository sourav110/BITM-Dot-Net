using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using InformationManagement.Models;
using InformationManagement.DAL;

namespace InformationManagement.BLL
{
    public class DepartmentManager
    {
        DepartmentGateway departmentGateway = new DepartmentGateway();

        public List<Department> GetAllDepartment()
        {
            return departmentGateway.GetAllDepartmentFromDB();
        }
    }
}