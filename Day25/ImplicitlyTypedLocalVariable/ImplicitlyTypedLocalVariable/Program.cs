using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplicitlyTypedLocalVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = 10;
            i = 12;

            var s = "James";
            s = "Alex";

            var b = true;
            b = false;

            Person person = new Person();
            var name = person.GetFullName();

            var persons = new List<Person>();
            persons.Add(person);

            Console.WriteLine(name);
            Console.ReadKey();

        }
    }
}
