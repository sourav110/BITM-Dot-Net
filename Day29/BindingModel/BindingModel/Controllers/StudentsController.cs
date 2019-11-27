using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BindingModel.Models;

namespace BindingModel.Controllers
{
    public class StudentsController : Controller
    {
        // GET: Students
        public ActionResult Index()
        {
            //Student student = new Student("James", "London", 22);

            List<Student> students = new List<Student>
            {
                new Student{Name = "James", City = "London", Age =22},
                new Student{Name = "Jason", City = "California", Age =25},
                new Student{Name = "Maria", City = "New York", Age =32},
            };

            return View(students);
        }
    }
}