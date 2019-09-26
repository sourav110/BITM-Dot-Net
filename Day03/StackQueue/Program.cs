using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            //-------Stack-------//

            Console.WriteLine("---Stack Ex---");

            Stack<string> nameList = new Stack<string>();
            nameList.Push("Abraham");
            nameList.Push("Brendon");
            nameList.Push("Cook");

            foreach (var item in nameList)
            {
                Console.WriteLine(item);
            }

            string gotOut = nameList.Pop();
            Console.WriteLine("\nOut = " + gotOut);

            Console.WriteLine("\nNew Stack:");

            foreach (var item in nameList)
            {
                Console.WriteLine(item);
            }



            //--------Queue------//

            Console.WriteLine("\n---Queue Ex---");

            Queue<int> ageList = new Queue<int>();
            ageList.Enqueue(11);
            ageList.Enqueue(12);
            ageList.Enqueue(13);

            foreach (var item in ageList)
            {
                Console.WriteLine(item);
            }

            int removeAge = ageList.Dequeue();
            Console.WriteLine("\ndelete = " + removeAge);

            Console.WriteLine("\nNew Queue:");

            foreach (var item in ageList)
            {
                Console.WriteLine(item);
            }



            //-------Dynamic Stack-----//

            Console.WriteLine("\n---Dynamic Stack---");

            Stack<string> playerList = new Stack<string>();

            Console.WriteLine("Enter players name:");
            for (int i = 0; i<5; i++)
            {
                playerList.Push(Console.ReadLine());
            }

            Console.WriteLine("\nPlayers are:");
            foreach(var item in playerList)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
