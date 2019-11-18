using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousTypeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new { FirstName = "James", Id = "151-12", Age = 20 };
            var age = person.Age;

            //person.FirstName = "Bruh"; >>>>>Anonymous type property has getter only, not setter.

            var abook = new { Name = "Ice and Fire", Author = "RR Martin", Price = 2000 };
            var price = abook.Price;
            Console.WriteLine(price);


            var names = new[] {"Alex", "Bliss", "Calix"};
            foreach(var name in names)
            {
                Console.WriteLine(name);
            }

            var books = new[]
            {
                new {Name = "7 habits of highly effective people", Author = "A Writer", TotalSell = 1000},
                new {Name = "Rich Dad Poor Das", Author = "B Writer", TotalSell = 2000},
                new {Name = "Subtle Art", Author = "C Poet", TotalSell = 3000}
            };

            foreach(var book in books)
            {
                Console.WriteLine(book.TotalSell);
            }

            PrintAuthor(abook);
            Console.WriteLine("\n");

            Show(books);

            Console.ReadKey();
        }

        private static void PrintAuthor(dynamic item)
        {
            Console.WriteLine(item.Author);
        }

        public static void Show(IEnumerable<dynamic> aList)
        {
            foreach(var aValue in aList)
            {
                PrintAuthor(aValue);
                //Console.WriteLine(aValue);
            }
        }
    }
}
