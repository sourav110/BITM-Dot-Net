using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CFMigrationAndHTMLhelper.Models;

namespace CFMigrationAndHTMLhelper.Controllers
{
    public class DepartmentsController : Controller
    {
        // GET: Departments
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Department department)
        {
            return View();
        }

    }
}