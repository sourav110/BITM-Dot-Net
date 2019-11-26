using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BasicMVC.DAL;
using BasicMVC.Models;

namespace BasicMVC.Controllers
{
    public class EmployeesController : Controller
    {
        // GET: Employees
        public ActionResult Index()

        {
            EmployeeGateway employeeGateway = new EmployeeGateway();

            List<Employee> employeeList = new List<Employee>();
            employeeList = employeeGateway.GetEmployees();

            ViewBag.Employees = employeeList;
            
            return View();
        }
    }
}