using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the first number:");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            int add = Add(firstNumber, secondNumber);
            float avg = GetAverage(add);

            Console.WriteLine("The average is: " + avg);

            Console.ReadKey();
        }

        static float GetAverage(int add)
        {
            float average = add / 2;
            return average;
        }

        static int Add(int firstNum, int secondNum)
        {
            int sum = firstNum + secondNum;
            return sum;
        }
    }
}
