using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CFMigrationAndHTMLhelper.Models;
using Vereyon.Web;

namespace CFMigrationAndHTMLhelper.Controllers
{
    public class DepartmentsController : Controller
    {
        ProjectDbContext db = new ProjectDbContext();

        // GET: Departments
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Department department)
        {
            if (ModelState.IsValid)
            {
                db.Departments.Add(department);
                db.SaveChanges();
                FlashMessage.Confirmation("Department saved successfully");
                return RedirectToAction("Create");
            }
            return View(department);
        }


        public JsonResult IsCodeExists(string departmentCode)
        {
            var depts = db.Departments.ToList();
            if (!depts.Any(code => code.DepartmentCode.ToLower() == departmentCode.ToLower()))
            {
                return Json(true, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }


        public JsonResult IsNameExists(string departmentName)
        {
            var depts = db.Departments.ToList();
            if(!depts.Any(name => name.DepartmentName.ToLower() == departmentName.ToLower()))
            {
                return Json(true, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
    }
}