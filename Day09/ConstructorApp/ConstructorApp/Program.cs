using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("James",  "H.", "Leo");

            

            string fullName = person1.GetFullName();
            string reverseName = person1.GetReverseFullName();
            Console.WriteLine(fullName);
            //Console.WriteLine(reverseName);
            Console.WriteLine();



            Person person2 = new Person("Israt", "Jahan", "Moury");            

            fullName = person2.GetFullName();
            reverseName = person2.GetReverseFullName();          
            Console.WriteLine(fullName);
            Console.WriteLine(reverseName);
            Console.WriteLine("ID: " + person2.id);
            Console.WriteLine();




            Person person3 = new Person("Mario", "Gotze");

            fullName = person3.GetFullName();
            reverseName = person3.GetReverseFullName();
            Console.WriteLine(fullName);
            Console.WriteLine(reverseName);
            Console.WriteLine();


            //Person person4 = new Person();           
            //Console.WriteLine(person4.id);
            //Console.WriteLine();

            Person person5 = new Person("Lahm");

            fullName = person5.GetFullName();
            reverseName = person5.GetReverseFullName();

            Console.WriteLine(fullName);
            Console.WriteLine(reverseName);
            Console.WriteLine("ID: " + person5.id);
            

            Console.ReadKey();
        }
    }
}
