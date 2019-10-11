using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentInfoManagementWebApp
{
    [Serializable]

    public class Student
    {
        public string FirstName;
        public string LastName;
        public string UserName;
        public string RegNo;
        public string Email;
        public int Age;

        public string GetFullName()
        {
            string FullName = FirstName + " " + LastName;
            return FullName;
        }
    }
}