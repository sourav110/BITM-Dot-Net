using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the size of the array:");
            int arraySize = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[arraySize];

            Console.WriteLine("\nEnter the numbers:");
            for (int i = 0; i < arraySize; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nNumbers are:");
            foreach(var item in numbers)
            {
                Console.WriteLine(item);
            }

            double average = GetAverage(numbers);
            Console.WriteLine("\nAverage of the numbers is: " + average);

            Console.ReadKey();

        }

        static double GetAverage(int[] array)
        {
            double average;
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum = sum + array[i];
            }

            average = sum / array.Length;
            average = Math.Round(average, 2); // return 2 decimal places
            return average;
        }
    }
}
