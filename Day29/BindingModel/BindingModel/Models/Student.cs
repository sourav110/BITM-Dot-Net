using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BindingModel.Models
{
    public class Student
    {
        public Student(string name, string city, int age)
        {
            Name = name;
            City = city;
            Age = age;
        }

        public string Name { get; set; }
        public string City { get; set; }
        public int Age { get; set; }
    }
}