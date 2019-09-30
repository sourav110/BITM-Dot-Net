using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListMinMax
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the list:");
            int listSize = Convert.ToInt32(Console.ReadLine());

            List<int> numbers = new List<int>();

            Console.WriteLine("\nEnter the numbers:");

            for(int i = 0; i < listSize; i++)
            {
                numbers.Add(Convert.ToInt32(Console.ReadLine()));
            }


            Console.WriteLine("\nNumbers are: ");
            foreach(var item in numbers)
            {
                Console.WriteLine(item);
            }

            int minimum = GetMin(numbers);
            Console.WriteLine("\nMin is : " + minimum);

            int maximum = GetMax(numbers);
            Console.WriteLine("\nMax is : " + maximum);

            Console.ReadKey();

        }

        static int GetMin(List<int> list)
        {
            int min = list[0];
            for (int i = 0; i < list.Count; i++)
            {
                if (min > list[i])
                {
                    min = list[i];
                }
            }
            return min;
        }

        static int GetMax(List<int> list)
        {
            int max = list[0];
            for(int i = 0; i < list.Count; i++)
            {
                if(max < list[i])
                {
                    max = list[i];
                }
            }
            return max;
        }
    }
}
