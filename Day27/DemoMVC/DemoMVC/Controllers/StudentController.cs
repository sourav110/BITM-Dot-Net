using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoMVC.Models;

namespace DemoMVC.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        

        public ActionResult GetAllStudent()
        {

            //Student student = new Student()
            //{
            //    Name = "James",
            //    RegNo = "151-15",
            //    Age = 20
            //};

            //ViewBag.Student = student;

            List<Student> students = new List<Student>()
            {
                new Student {Name = "James", RegNo = "151-15", Age = 20},
                new Student {Name = "Mario", RegNo = "151-16", Age = 21},
                new Student {Name = "Phil", RegNo = "151-17", Age = 22},
            };
            //ViewBag.Students = students;

            return View(students);
        }
    }
}