using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoMVC.Models;
using DemoMVC.DAL;

namespace DemoMVC.Controllers
{
    public class EmployeesController : Controller
    {
        // GET: Employees
        public ActionResult Index()
        {
            EmployeeGateway db = new EmployeeGateway();
            List<Employee> employees = db.GetEmployees();
            ViewBag.Employees = employees;

            return View();
        }
    }
}