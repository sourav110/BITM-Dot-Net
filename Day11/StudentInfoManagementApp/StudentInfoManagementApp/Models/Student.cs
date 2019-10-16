using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentInfoManagementApp.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string RegNo { get; set; }
        public string Email { get; set; }
        public string MobileNo { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

        public Student(string studentName, string regNo, string email, string mobileNo, int age, string address)
        {
            this.StudentName = studentName;
            this.RegNo = regNo;
            this.Email = email;
            this.MobileNo = mobileNo;
            this.Age = age;
            this.Address = address;
        }
    }
}