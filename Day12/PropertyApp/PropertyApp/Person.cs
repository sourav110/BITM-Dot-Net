using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyApp
{
    class Person
    {
        private string firstName;
        private string middleName;
        private string lastName;

        //public string FirstName { get; set; }
        //public string MiddleName { get; set; }
        //public string LastName { get; set; }


        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                if (value.Length > 2)
                {
                    firstName = value;
                }
            }
        }

        public string MiddleName
        {
            get
            {
                return middleName;
            }
            set
            {
                middleName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
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
