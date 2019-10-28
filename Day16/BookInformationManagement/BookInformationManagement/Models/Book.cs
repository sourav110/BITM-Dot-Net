using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookInformationManagement.Models
{
    public class Book
    {
        public Book()
        {
        }

        public Book(string bookName, string iSBN, string author)
        {
            BookName = bookName;
            ISBN = iSBN;
            Author = author;
        }

        public Book(int bookId, string bookName, string iSBN, string author)
        {
            BookId = bookId;
            BookName = bookName;
            ISBN = iSBN;
            Author = author;
        }

        public int BookId { get; set; }
        public string BookName { get; set; }
        public string ISBN { get; set; }
        public string Author { get; set; }
    }
}