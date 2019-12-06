using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProtPracticeMVC.Models;
using ProtPracticeMVC.DAL;

namespace ProtPracticeMVC.BLL
{
    public class SemesterManager
    {
        SemesterGateway semesterGateway = new SemesterGateway();

        public List<Semester> GetSemesters()
        {
            return semesterGateway.GetSemesters();
        }
    }
}