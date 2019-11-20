using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Name = "A";
            student.RegNo = "a-s";
            student.Email = "aaa";
            student.GetInfo();
            

            Department department = new Department();
            department.GetInfo();
            department.Print();

            Course course = new Course();
        }
    }
}
