using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>
            {
                new Book{Name = "7 Habits of highly effective people", Author = "Gabriel",  Price = 700},
                new Book{Name = "Rich Dad Poor Dad", Author = "Roger",  Price = 900},
                new Book{Name = "Subtle Art", Author = "Manuel",  Price = 1600},
                new Book{Name = "Ice and Fire", Author = "Martin", Price = 2000},
                new Book{Name = "The Vinci Code", Author = "Dan Brown", Price = 800}
            };

            var selectedBooks = from book in books
                                where book.Price > 1500
                                select book;

            //foreach(var item in selectedBooks)
            //{
            //    Console.WriteLine(item.Name);
            //}

            var slctdBooks = books.Where(b => b.Price > 1500 && b.Name.EndsWith("e")).ToList();
            //foreach (var item in slctdBooks)
            //{
            //    Console.WriteLine(item.Name);
            //}

            var selectBooks = books.FirstOrDefault(c => (c.Price < 1000));
            //foreach (var item in selectBooks)
            //{
            //    Console.WriteLine(item.Name);
            //}

            IEnumerable<string> bookList = books.Where(book => book.Name.Contains("t") && book.Price < 1000).Select(bookName => bookName.Name);
            //foreach (var item in bookList)
            //{
            //    Console.WriteLine(item);
            //}


            //All of Day25----Magic method Hahhahahahhahahahahahaha

            ALLinOne();

            Console.ReadKey();
        }

        private static void ALLinOne()
        {
            //ImplicitlyType, Anonymous type and Object+collection initializer
            var books = new List<Book>
            {
                new Book{Name = "7 Habits of highly effective people", Author = "Gabriel",  Price = 1700},
                new Book{Name = "Rich Dad Poor Dad", Author = "Roger",  Price = 900},
                new Book{Name = "Subtle Art", Author = "Manuel",  Price = 1600},
                new Book{Name = "Ice and Fire", Author = "Martin", Price = 2000},
                new Book{Name = "The Vinci Code", Author = "Dan Brown", Price = 800},
                new Book{Name = "Cloudy Sky", Author = "Marry Gold", Price = 1000}
                
            };

            //Linq and Lambda expression
            var slctdBooks = books.Where(b => b.Price > 1500 && b.Name.EndsWith("e")).ToList();
            foreach (var item in slctdBooks)
            {
                Console.WriteLine(item.Name);
            }

        }
    }
}
