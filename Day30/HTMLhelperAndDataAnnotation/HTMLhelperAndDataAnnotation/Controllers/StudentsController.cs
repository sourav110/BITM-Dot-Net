﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HTMLhelperAndDataAnnotation.Models;

namespace HTMLhelperAndDataAnnotation.Controllers
{
    public class StudentsController : Controller
    {
        // GET: Students
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Register()
        {
            ViewBag.Departments = GetDepartments();
            return View();
        }

        [HttpPost]
        public ActionResult Register(Student student)
        {
            ViewBag.Departments = GetDepartments();
            return View();
        }

        private List<Department> GetDepartments()
        {
            List<Department> departments = new List<Department>
            {
                new Department{Id= 0, Code= "", DeptName="Select Department"},
                new Department{Id= 1, Code= "CSE", DeptName= "Computer Science & Engineering"},
                new Department{Id= 2, Code= "EEE", DeptName= "Electrical Engineering"},
                new Department{Id= 3, Code= "ENG", DeptName= "English"}
            };

            return departments;
        }
    }
}