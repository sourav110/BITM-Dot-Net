using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DemoMVC.Models;

namespace DemoMVC.ViewModels
{
    public class StudentDeptVM
    {
        public Student Student { get; set; }
        public Department Department { get; set; }
    }
}