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
            student.Name = "Alex";
            student.RegNo = "A-8292";
            student.Email = "alex@mail.com";
            student.GetInfo();
            Console.WriteLine(student.GetInfo());
            Console.WriteLine();


            Department department = new Department();
            department.GetInfo();
            department.PrintData();
            Console.WriteLine(department.GetInfo());
            Console.WriteLine();


            Course course = new Course();
            course.CourseName = "Object Oriented Programming";
            //course.GetInfo();
            course.Print();
            Console.WriteLine(course.GetInfo());
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
