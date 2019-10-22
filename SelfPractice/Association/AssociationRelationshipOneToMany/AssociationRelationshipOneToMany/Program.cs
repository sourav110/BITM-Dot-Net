using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociationRelationshipOneToMany
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Rana", "635-386", "r@mail.com");
            Student student2 = new Student("Samira", "765-37", "sa@mail.com");
            Student student3 = new Student("Salim", "8346398", "salim@mail.com");
            Student student4 = new Student("Reza", "8346398", "r@mail.com");

            Department aDepartment = new Department("Computer Sc.", "A Building", "CSE");

            string msg;

            msg = aDepartment.AddStudent(student1);
            msg = aDepartment.AddStudent(student2);
            msg = aDepartment.AddStudent(student3);
            msg = aDepartment.AddStudent(student4);

            //aDepartment.Students.Add(student1);
            //aDepartment.Students.Add(student2);
            //aDepartment.Students.Add(student3);

            foreach (Student aStudent in aDepartment.Students)
            {
                string info = aStudent.Name + " " + aStudent.RegNo;
                Console.WriteLine(info);
            }

            Console.ReadKey();
        }
    }
}
