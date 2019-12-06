using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProtPracticeMVC.Models
{
    public class Semester
    {
        public Semester(int semesterId, string semesterNo)
        {
            SemesterId = semesterId;
            SemesterNo = semesterNo;
        }

        public int SemesterId { get; set; }
        public string SemesterNo { get; set; }
    }
}