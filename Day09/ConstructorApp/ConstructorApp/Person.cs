using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorApp
{
    class Person
    {
        public string firstName;
        public string middleName;
        public string lastName;
        public string id;

        public Person(string firstName, string middleName, string lastName) : this(firstName, lastName)
        {           
            this.middleName = middleName;
        }

        public Person(string firstName, string lastName) : this()
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public Person(string firstName) : this()
        {
            this.firstName = firstName;
        }

        public Person()
        {
            id = "000000";
        }



        public string GetFullName()
        {
            string fullName;


            if (middleName == null && lastName == null)
            {
                fullName = firstName;
            }

            else if (middleName == null)
            {
               fullName = firstName + " " + lastName;
            }
            
            else
            {
                fullName = firstName + " " + middleName + " " + lastName;
            }

            return fullName;
        }

        public string GetReverseFullName()
        {
            string fullName = GetFullName();
            char[] charArray = fullName.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
