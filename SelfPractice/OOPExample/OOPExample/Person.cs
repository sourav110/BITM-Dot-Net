using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExample
{
    class Person
    {
        public string firstName;
        public string middleName;
        public string lastName;
        public string id;

        public static string Email { set; get; }
        //public string Email { set; get; }

        public string GetFullName()
        {
            return firstName + " " + middleName + " " + lastName;
        }

        public Person(string firstName, string middleName, string lastName) : this(firstName, lastName)
        {
            this.middleName = middleName;
        }

        public Person(string firstName, string lastName) :this()
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public Person()
        {
            id = "000";
        }
    }
}
