using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {

            Person person1 = new Person();

            person1.firstName = "James";
            person1.middleName = "H";
            person1.lastName = "Leo";

            string fullName = person1.GetFullName();
            string reverseName = person1.GetReverseFullName();

            Console.WriteLine(fullName);
            Console.WriteLine(reverseName);

            Console.WriteLine();

            Person person2 = new Person();

            person2.firstName = "Israt";
            person2.middleName = "Jahan";
            person2.lastName = "Moury";

            fullName = person2.GetFullName();
            reverseName = person2.GetReverseFullName();

            person2.lastName = "Changed";

            Console.WriteLine(fullName);
            Console.WriteLine(reverseName);

            Console.WriteLine();

            //person2 = null;

            Person person3 = new Person();
            person3 = person2; // Reffers the objects that are reffered by person2 

            //person2 = null;\
            person3.lastName = "Changed 2";

            fullName = person3.GetFullName();
            reverseName = person3.GetReverseFullName();

            Console.WriteLine(fullName);
            Console.WriteLine(reverseName);

            Console.ReadKey();
        }

        static void Change(Person person)
        {
            person.lastName = "Changed";
        }
    }
}
