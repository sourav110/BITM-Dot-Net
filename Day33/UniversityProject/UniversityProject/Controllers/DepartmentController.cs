using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UniversityProject.Models;
using Vereyon.Web;

namespace UniversityProject.Controllers
{
    public class DepartmentController : Controller
    {

        private ProjectDBContext db = new ProjectDBContext();
        public ActionResult SaveDepartment()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SaveDepartment(Department department)
        {
            if (ModelState.IsValid)
            {
                db.Departments.Add(department);
                db.SaveChanges();
                FlashMessage.Confirmation("Department Successfully saved");
                return RedirectToAction("SaveDepartment");
            }

            return View();
        }

        public JsonResult IsCodeExits(string departmentCode)
        {
            var dept = db.Departments.ToList();
            if (!dept.Any(x=>x.DepartmentCode.ToLower()== departmentCode.ToLower()))
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

        public ActionResult ShowAllDepartment()
        {
            var dept = db.Departments.ToList();
            return View(dept);
        }

        public ActionResult ViewDetails()
        {
            ViewBag.DepartmentId = new SelectList(db.Departments, "DepartmentId", "DepartmentCode");
            return View();
        }

        public JsonResult GetStudentByDepartment(int deptId)
        {
            var students = db.Students.Where(s => s.DepartmentId == deptId).ToList();
            return Json(students);
        }

        public JsonResult GetStudentById(int studentId)
        {
            var student = db.Students.FirstOrDefault(s => s.StudentId == studentId);
            return Json(student);
        }
    }
}