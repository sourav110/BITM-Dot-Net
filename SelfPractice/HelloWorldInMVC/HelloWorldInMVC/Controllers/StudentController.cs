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

        public ActionResult Result(Student aStudent, int? age)
        {
            ViewBag.AStudent = aStudent;

            return View();
        }
    }
}