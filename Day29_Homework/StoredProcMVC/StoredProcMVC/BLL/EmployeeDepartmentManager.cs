using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StoredProcMVC.DAL;
using StoredProcMVC.ViewModels;

namespace StoredProcMVC.BLL
{
    public class EmployeeDepartmentManager
    {
        EmployeeDepartmentGateway viewModelGateway = new EmployeeDepartmentGateway();

        public List<EmployeeDepartmentViewModel> GetEmployeeDepartmentViewModels()
        {
            return viewModelGateway.GetEmployeeDepartmentViewModels();
        }
    }
}