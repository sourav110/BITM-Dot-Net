using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModelBinding.Models
{
    public class Student
    {
        //public Student(string name, string city, int age)
        //{
        //    Name = name;
        //    City = city;
        //    Age = age;
        //}

        //public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public int Age { get; set; }
    }
}