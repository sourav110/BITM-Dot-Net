using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03_MethodProblemSet
{
    class Program
    {
        static void Main(string[] args)
        {
            //Take First Name, Middle Name, Last Name and return Full Name to the screen.

            Console.WriteLine("Enter first name:");
            string first = Console.ReadLine();

            Console.WriteLine("Enter middle name:");
            string middle = Console.ReadLine();

            Console.WriteLine("Enter last name:");
            string last = Console.ReadLine();

            string full = GetFullName(first, middle, last);
            Console.WriteLine("\nThe full name is: " + full);

            Console.ReadKey();
        }

        static string GetFullName(string firstName, string middleName, string lastName)
        {
            string fullName = firstName + " " + middleName + " " + lastName;
            return fullName;
        }
    }
}
