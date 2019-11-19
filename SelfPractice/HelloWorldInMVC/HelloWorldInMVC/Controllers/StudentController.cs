using HelloWorldInMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorldInMVC.Controllers
{
    public class StudentController : Controller
    {
        //public string Result(string name, string address, int? roadNo=98)
        //{
        //    return name + ", Your result is A+ & address is " + roadNo + ", " + address;
        //}

        public ActionResult Result(Student aStudent)
        {
            //ViewBag.AStudent = aStudent;

            List<Student> studentList = new List<Student>()
            {
                new Student(){Name = "Alex", Email = "alex@mail.com"},
                new Student(){Name = "Brad", Email = "brad@mail.com"},
                new Student(){Name = "Calix", Email = "calix@mail.com"},
                new Student(){Name = "James", Email = "james@mail.com"}
            };

            return View(studentList);
        }
    }
}