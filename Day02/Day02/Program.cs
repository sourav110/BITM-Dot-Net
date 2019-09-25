using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Print odd numbers between 1-100 using continue and break statement

            int i = 0;

            while (true)
            {
                i++;

                if (i % 2 == 0)
                {
                    continue;
                }

                else if (i > 100)
                {
                    break;
                }
                Console.WriteLine(i);
            }

            //Input three parts of the name and print full name
            Console.WriteLine("\nEnter the first name: ");
            string first = Console.ReadLine();
            Console.WriteLine("Enter the middle name: ");
            string middle = Console.ReadLine();
            Console.WriteLine("Enter the last name: ");
            string last = Console.ReadLine();

            string full = Name(first, middle, last);
            Console.WriteLine("The full name is: " + full);

            Console.ReadKey();
        }

        static string Name(string firstName, string middleName, string lastName)
        {
            string fullName = firstName + " " + middleName + " " + lastName;
            return fullName;
        }
    }
}
