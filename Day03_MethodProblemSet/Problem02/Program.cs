using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Take 5 numbers from the user and return average

            Console.WriteLine("Enter 1st number: ");
            int first = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 2nd number: ");
            int second = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 3rd number: ");
            int third = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 4th number: ");
            int fourth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 5th number: ");
            int fifth = Convert.ToInt32(Console.ReadLine());

            int average = GetAverage(first, second, third, fourth, fifth);
            Console.WriteLine("\nThe average is : " + average);

            Console.ReadKey();

        }

        static int GetAverage(int firstNum, int secondNum, int thirdNum, int fourthNum, int fifthNum)
        {
            int getAverage = (firstNum + secondNum + thirdNum + fourthNum + fifthNum) / 5;
            return getAverage;
        }
    }
}
