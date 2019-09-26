using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Take a mark from the user and return Grade like(A +, A - ...)

            Console.WriteLine("Enter your mark: ");
            int mark = Convert.ToInt32(Console.ReadLine());

            string grade = GetGrade(mark);
            Console.WriteLine("\nYour grade is : " + grade);

            Console.ReadKey();
        }

        static string GetGrade(int mark)
        {
            string getGrade = null;

            if(mark <= 100 && mark >= 80)
            {
                getGrade = "A+";
            }
            else if( mark <= 79 && mark >= 75)
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
            else if(mark < 40)
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
