using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Name: ");
            string first = Console.ReadLine();

            Console.WriteLine("Enter Last Name: ");
            string last = Console.ReadLine();

            Console.WriteLine("Enter Subject: ");
            string subject = Console.ReadLine();

            Console.WriteLine("Enter Mark: ");
            int mark = Convert.ToInt32(Console.ReadLine());

            string full = GetFullName(first, last);
            string grade = GetGrade(mark);

            if(mark <= 100 && mark >= 40)
            {
                Console.WriteLine("Hello " + full + " Congratulations! You have passed in " + subject + " and your grade is " + grade);
            }
            else if(mark < 40)
            {
                Console.WriteLine("Sorry you have failed. Please try again!");
            }
            else
            {
                Console.WriteLine("Please enter the mark between 1-100");
            }
            

            Console.ReadKey();
        }       


        static string GetFullName(string firstName, string lastName)
        {
            string fullName = firstName + " " + lastName;
            return fullName;
        }

        static string GetGrade(int mark)
        {
            string getGrade = null;

            if (mark <= 100 && mark >= 80)
            {
                getGrade = "A+";
            }
            else if (mark <= 79 && mark >= 75)
            {
                getGrade = "A";

            }
            else if (mark <= 74 && mark >= 70)
            {
                getGrade = "A-";

            }
            else if (mark <= 69 && mark >= 65)
            {
                getGrade = "B+";

            }
            else if (mark <= 64 && mark >= 60)
            {
                getGrade = "B";

            }
            else if (mark <= 59 && mark >= 55)
            {
                getGrade = "B-";

            }
            else if (mark <= 54 && mark >= 50)
            {
                getGrade = "C+";

            }
            else if (mark <= 49 && mark >= 45)
            {
                getGrade = "C";

            }
            else if (mark <= 44 && mark >= 40)
            {
                getGrade = "D";

            }
            else if (mark < 40)
            {
                getGrade = "F";
            }
            else
            {
                getGrade = "Null\nPlease enter your mark in the range between 1-100";
            }

            return getGrade;
        }
    }
}
