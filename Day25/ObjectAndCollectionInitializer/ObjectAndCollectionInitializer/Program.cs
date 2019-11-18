using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectAndCollectionInitializer
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.FirstName = "James";
            person1.LastName = "Leo";
            person1.Age = 20;


            //---object initializer---//
            Person person2 = new Person("P.", "Lahm")
            {
                Age = 30   
            };

            Person person3 = new Person
            {
                FirstName = "Mario",
                LastName = "Gotze",
                Age = 28
            };

            Console.WriteLine(person3.Age);


            //---collection initializer---//
            List<string> names = new List<string>
            {
                "James", "Mario", "Alex"
            };

            //names.Add("James");
            //names.Add("Lucas");
            //names.Add("Lahm");
            
            foreach(var name in names)
            {
                Console.WriteLine(name);
            }

            List<Person> persons = new List<Person>()
            {
                person1,
                person2,
                person3,
                new Person("Lars", "Stindl")
                {
                    Age = 25
                }
                
            };

            //persons.Add(person1);
            //persons.Add(person2);
            //persons.Add(person3);

            foreach(var person in persons)
            {
                Console.WriteLine(person.GetFullName());
            }

            var person4 = persons[3];
            Console.WriteLine(person4.FirstName);

            Console.ReadKey();
        }
    }
}
