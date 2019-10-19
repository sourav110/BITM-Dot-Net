using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Person person1 = new Person();

            string firstName = Console.ReadLine();
            string middleName = "H";
            string lastName = "Leo";

            //Set
            person1.FirstName = firstName;
            person1.MiddleName = middleName;
            person1.LastName = lastName;

            //Get
            string fName = person1.FirstName;
            string mName = person1.MiddleName;
            string lName = person1.LastName;

            string fullName = person1.GetFullName();

            Console.WriteLine(fullName);



            Person person2 = new Person();
            string middleName2 = "whoa";
            //person2.MiddleName = middleName;
            Console.WriteLine(middleName2);


            Console.ReadKey();
        }
    }
}
