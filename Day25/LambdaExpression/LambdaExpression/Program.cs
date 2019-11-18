using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            //---Example 01---//
            Func<int, int> func1 = x => x + 1;
            Func<int, int> func2 = x => { return x + 1; };
            Func<int, int> func3 = (int x) => x + 1;
            Func<int, int> func4 = (int x) => { return x + 1; };
            Func<int, int, int> func5 = (x, y) => x * y;

            Action func6 = () => Console.WriteLine();

            Console.WriteLine(func1.Invoke(2));
            Console.WriteLine(func2.Invoke(1));
            Console.WriteLine(func3.Invoke(1));
            Console.WriteLine(func4.Invoke(1));
            Console.WriteLine(func5.Invoke(2, 2));
            func6.Invoke();


            //---Example 02---//
            List<string> names = new List<string> { "Alex", "Bliss", "Calix" };
            string foundStart = names.Find(name => name.StartsWith("B"));
            Console.WriteLine(foundStart);
            func6.Invoke();

            var foundEndAll = names.FindAll(name => name.EndsWith("x"));
            foreach(var name in foundEndAll)
            {
                Console.WriteLine(name);
            }
            func6.Invoke();

            List<double> numbers = new List<double>{8, 27, 77, 7, 16, 50};
            var aNum = numbers.Find(num => (num > 20));
            Console.WriteLine(aNum);
            func6.Invoke();

            List<Book> books = new List<Book>
            {
                new Book{Name = "7 Habits", Author = "Gabriel",  Price = 1200},
                new Book{Name = "Rich Dad Poor Dad", Author = "Shane",  Price = 1300},
                new Book{Name = "Ice and Fire", Author = "Martin",  Price = 1500}
            };

            var bookList = books.FindAll(book => (book.Price > 1200));
            foreach(var item in bookList)
            {
                Console.WriteLine(item.Name);
            }

            Console.ReadKey();
        }
    }
}
