using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StoredProcMVC.Models;
using StoredProcMVC.BLL;
using StoredProcMVC.ViewModels;

namespace StoredProcMVC.Controllers
{
    public class EmployeesController : Controller
    {
        EmployeeManager employeeManager = new EmployeeManager();
        DepartmentManager departmentManager = new DepartmentManager();
        EmployeeDepartmentManager employeeDepartmentManager = new EmployeeDepartmentManager();

        // GET: Employees
        public ActionResult Index()
        {
            //List<Employee> employees = employeeManager.GetEmployees();
            List<EmployeeDepartmentViewModel> employeesWithDepartment = employeeDepartmentManager.GetEmployeeDepartmentViewModels();
            return View(employeesWithDepartment);
        }

        public ActionResult Create()
        {
            List<Department> departments = departmentManager.GetDepartments();
            ViewBag.Departments = departments;
            ViewBag.IsSaved = true;
            return View();
        }

        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            List<Department> departments = departmentManager.GetDepartments();
            ViewBag.Departments = departments;

            bool isSaved = employeeManager.SaveEmployee(employee);
            if (isSaved)
            {
                ViewBag.IsSaved = true;
                return RedirectToAction("Index");
            }

            else
            {
                ViewBag.IsSaved = false;
                return View();
            }
        }
    }
}