using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03
{
    class Program
    {
        static void Main(string[] args)
        {
            //---------Array Basic--------//

            //declaration
            int[] num = new int[] { 0, 1, 2, 3, 4, 5 };
            //console.writeline(num[2]);

            foreach (int i in num)
            {
                Console.WriteLine(i);
            }

            //-----Array Declaration Manually----//

            Console.WriteLine("");
            string[] countrylist = new string[10];

            countrylist[0] = "Bangladesh";
            countrylist[1] = "India";
            countrylist[2] = "Pakistan";
            countrylist[3] = "Srilanka";
            countrylist[4] = "Nepal";

            string countryname = countrylist[4];
            Console.WriteLine(countryname);
            //Console.WriteLine("");

            foreach (var i in countrylist)
            {
                Console.WriteLine(i);
            }


            //Enter the size of array, input names and print them dynamically[using loop]
            Console.WriteLine("Enter the size of array:");
            int arraySize = Convert.ToInt32(Console.ReadLine());

            string[] nameList = new string[arraySize];

            Console.WriteLine("\nEnter the names");
            for(int i = 0; i<arraySize; i++)
            {
                nameList[i] = Console.ReadLine();
            }

            Console.WriteLine("\nThe names are:");
            for(int i = 0; i<arraySize; i++)
            {
                Console.WriteLine(nameList[i]);
            }

            //foreach(var i in nameList)
            //{
            //    Console.WriteLine(i);
            //}

            Console.ReadKey();
        }
    }
}
