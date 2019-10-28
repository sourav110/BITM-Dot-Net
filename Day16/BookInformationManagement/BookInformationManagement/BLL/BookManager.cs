using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookInformationManagement.Models;
using BookInformationManagement.DAL;


namespace BookInformationManagement.BLL
{
    public class BookManager
    {
        Book book = new Book();
        BookGateway bookGateway = new BookGateway();

        public string SaveBook(Book book)
        {

            bool isExisted = bookGateway.ExistISBN(book);

            if (isExisted)
            {
                return "Already Exists";
            }

            else
            {
                if (book.ISBN.Length == 13)
                {
                    bool isSaved = bookGateway.SaveBook(book);

                    if (isSaved)
                    {
                        return "Book Saved Successfully";
                    }
                    else
                    {
                        return "Failed to Save";
                    }
                }

                else
                {
                    return "ISBN must be 13 digit";
                }
            }
        }

        public List<Book> GetAllBook(string searchBook)
        {
            BookGateway bookGateway = new BookGateway();

            return bookGateway.GetAllBookFromDB(searchBook);
        }
    }
}