using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExample
{
    class Program
    {
        static void Main(string[] args)
        {


            Student student1 = new Student();
            student1.Name = "James";
            student1.RegNo = "161-10";
            student1.Age = 20;

            Address address1 = new Address();
            address1.HouseNo = "98/A";
            address1.RoadNo = "Lake";
            address1.PostCode = 1205;

            student1.StudentAddress = address1;

            string name = student1.Name;
            //int postCode = address1.PostCode;
            Address studentAddress = student1.StudentAddress;

            //int postCode = studentAddress.PostCode;
            //int postCode2 = student1.StudentAddress.PostCode;


            Student student2 = new Student();
            student2.Name = "Leo";
            student2.RegNo = "171-10";
            student2.Age = 23;

            Student student3 = new Student();
            student3.Name = "Jess";
            student3.RegNo = "191-10";
            student3.Age = 24;

            Department department1 = new Department();

            department1.DeptName = "CSE";
            department1.DeptCode = 101;

            department1.Students.Add(student1);
            department1.Students.Add(student2);
            department1.Students.Add(student3);

            //foreach(Student student in department1.Students)
            //{
            //    string info = student.Name + " " + student.RegNo + " " + student.Age;
            //    Console.WriteLine(info);
            //}


            //Uses relationship

            student1.MathScore = 70;
            student1.EngScore = 90;

            student2.MathScore = 50;
            student2.EngScore = 40;

            string result1 = student1.GetResult();
            string result2 = student2.GetResult();
            Console.WriteLine(result1);
            Console.WriteLine(result2);


            //In case Student inherits Person
            //Base class : Person
            //Sub class : Student 
            //then it is possible

            Person p1 = new Student();
            
            






            //Person person1 = new Person("James", "H", "Leo");
            //Person person2 = new Person("Jess", "HD");

            //Console.WriteLine(person1.GetFullName());
            //Console.WriteLine(person2.GetFullName());

            //Person person = new Person();
            //person.Email = "rf@m.com";
            //Person.Email = "rf@m.com";
            //Console.WriteLine(Person.Email);

            //Console.WriteLine(person1.id);

            //Console.ReadKey();

            






            //Person person1 = new Person();
            //person1.firstName = "James";
            //person1.lastName = "Leo";
            //Console.WriteLine(person1.GetFullName());

            //Person person2 = new Person();
            //person2.firstName = "Jess";
            //person2.lastName = "Hdz";
            //Console.WriteLine(person2.GetFullName());

            //Person person3;
            //person3 = new Person();

            //person3 = person1;

            //person1 = null;

            //Person person4 = person2;
            //Person person5 = person4;


            //Console.WriteLine(person3.GetFullName());
            ////Console.WriteLine(person1.GetFullName());
            //Console.WriteLine(person4.GetFullName());
            //Console.WriteLine(person5.GetFullName());


            Console.ReadKey();
        }
    }
}
