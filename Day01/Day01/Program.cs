using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01
{
    class Program
    {
        static void Main(string[] args)
        {
            //01 - Take upper and lower limit from user and show all integers bewteen them[including them]
            Console.WriteLine("SOLUTION 01");

            Console.WriteLine("Enter the lower limit: ");
            int lowerLimit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the upper limit: ");
            int upperLimit = Convert.ToInt32(Console.ReadLine());

            int i;
            Console.WriteLine("The numbers between the range[lowerLimit to upperLimit]");
            for (i = lowerLimit; i <= upperLimit; i++)
            {
                Console.WriteLine(i);
            }


            //02 - Show all even numbers between 1 to 100
            Console.WriteLine("\nSOLUTION 02");

            Console.WriteLine("Even numbers between range: ");

            int j;
            for (j = 1; j <= 10; j++)
            {
                if (j % 2 == 0)
                {
                    Console.WriteLine(j);
                }

            }


            //03 - If we list all the natural numbers below 10 that are multiples of 3 or 5, 
            //we get 3, 5, 6 and 9.The sum of these multiples is 23.
            //Find the sum of all the multiples of 3 or 5 below 1000.
            Console.WriteLine("\nSOLUTION 03");

            int k;
            int sum = 0;

            for(k = 1; k<10; k++)
            {
                if(k % 3 == 0 || k% 5 == 0)
                {
                    sum = sum + k;
                }
            }

            Console.WriteLine("Sum is: " + sum);


            //04 - The sum of the squares of the first ten natural numbers is,
            //12 + 22 + ... + 102 = 385
            //The square of the sum of the first ten natural numbers is,
            //(1 + 2 + ... + 10)2 = 552 = 3025
            //Hence the difference between the sum of the squares of the first ten natural numbers and 
            //the square of the sum is 3025 - 385 = 2640
            //Find the difference between the sum of the squares of the first one hundred natural numbers 
            //and the square of the sum.
            Console.WriteLine("\nSOLUTION 04");
            int l;
            int sum1 = 0;
            int sum2 = 0;
            
            for(l = 1; l<= 10; l++)
            {
                sum1 = sum1 + (l * l);
            }
            int sumOfSquare = sum1;
            Console.WriteLine("Sum of the squares is: " + sumOfSquare);

            for(l = 0; l<= 10; l++)
            {
                sum2 = sum2 + l;
            }
            int squareOfSum = sum2 * sum2;
            Console.WriteLine("Squares of the Sum: " + squareOfSum);

            int difference = squareOfSum - sumOfSquare;
            Console.WriteLine("The difference is : " + difference);

            Console.ReadKey();

        }
    }
}
