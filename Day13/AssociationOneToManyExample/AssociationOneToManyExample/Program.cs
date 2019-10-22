using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociationOneToManyExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("James", "151-2762", "james@gmail.com");
            Student student2 = new Student("Jami", "161-7622", "jami@yahoo.com");
            Student student3 = new Student("Leo", "161-7623", "leo@hotmail.com");
            Student student4 = new Student("Basti", "161-7623", "basti@hotmail.com");
            Student student5 = new Student("Lahm", "161-7627", "lahm@hotmail.com");

            Department aDepartment = new Department("Computer Science", "AB Building", "CSE");

            //aDepartment.Students.Add(student1);
            //aDepartment.Students.Add(student2);
            //aDepartment.Students.Add(student3);

            //string message;

            //message = aDepartment.AddStudent(student1);
            //message = aDepartment.AddStudent(student2);
            //message = aDepartment.AddStudent(student3);
            //message = aDepartment.AddStudent(student4);
            //message = aDepartment.AddStudent(student5);

            //Console.WriteLine(message);

            aDepartment.AddStudent(student1);
            aDepartment.AddStudent(student2);
            aDepartment.AddStudent(student3);
            aDepartment.AddStudent(student4);
            aDepartment.AddStudent(student5);


            foreach (Student aStudent in aDepartment.Students)
            {
                string info = aStudent.Name + " " + aStudent.RegNo + " " + aStudent.Email;
                Console.WriteLine(info);
            }

            Console.ReadKey();
        }
    }
}
