using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayMinMax
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the array: ");
            int arraySize = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[arraySize];

            Console.WriteLine("Enter the numbers: ");

            for(int i = 0; i < arraySize; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nNumbers are:");

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            int minimum = GetMin(array);
            Console.WriteLine("\nMin is: " + minimum);

            int maximum = GetMax(array);
            Console.WriteLine("\nMax is: " + maximum);

            Console.ReadKey();
        }



        static int GetMin(int[] array)
        {
            int min = array[0];           

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }

            return min;
        }

        static int GetMax(int[] array)
        {
            int max = array[0];           

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            return max;
        }
    }
}
