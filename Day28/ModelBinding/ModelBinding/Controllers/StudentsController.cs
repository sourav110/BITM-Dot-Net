using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelBinding.Models;

namespace ModelBinding.Controllers
{
    public class StudentsController : Controller
    {
        // GET: Students
        public ActionResult GetStudents()
        {
            Student james = new Student("James", "California", 32);
            Student jason = new Student("Jason", "New York", 35);
            Student xavi = new Student("Xavi", "Madrid", 34);
            Student madona = new Student("Madona", "London", 32);

            List<Student> students = new List<Student>
            {
                james, jason, xavi, madona
            };

            //List<Student> students = new List<Student>()
            //{

            //    new Student {Name = "James", City = "London", Age = 30 },
            //    new Student {Name = "Jason", City = "New York", Age = 32 },
            //    new Student {Name = "Xavi", City = "Madrid", Age = 35 }
            //};

            return View(students);
        }
    }
}