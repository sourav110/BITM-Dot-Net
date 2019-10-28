using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookInformationManagement.Models;
using BookInformationManagement.BLL;
using System.Web.Configuration;
using System.Data.SqlClient;

namespace BookInformationManagement.DAL
{
    public class BookGateway
    {
        Book book = new Book();
        string connectionString = WebConfigurationManager.ConnectionStrings["BookDB"].ConnectionString;


        public bool ExistISBN(Book book)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM Book_tbl WHERE ISBN = '" + book.ISBN + "'";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            Book aBook = null;
            while (reader.Read())
            {
                aBook = new Book();

                aBook.BookId = Convert.ToInt32(reader["BookId"]);
                aBook.BookName = reader["BookName"].ToString();
                aBook.ISBN = reader["ISBN"].ToString();
                aBook.Author = reader["Author"].ToString();
            }

            reader.Close();
            connection.Close();

            if (aBook != null)
            {
                return true;
            }

            return false;
        }

        public bool SaveBook(Book book)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            
            string query = @"INSERT INTO Book_tbl(BookName, ISBN, Author)" +
                            "VALUES('"+book.BookName+"', '"+book.ISBN+"', '"+book.Author+"')";

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            int rowEffect = command.ExecuteNonQuery();
            connection.Close();

            if(rowEffect > 0)
            {
                return true;
            }

            return false;
        }

        public List<Book> GetAllBookFromDB(string searchBook)
        {
            List<Book> bookList = new List<Book>();

            SqlConnection connection = new SqlConnection(connectionString);
            string query;

            if(searchBook.Length > 0)
            {
                query = "SELECT * FROM Book_tbl WHERE BookName LIKE '%"+searchBook+"%'";
            }

            else
            {
                query = "SELECT * FROM Book_tbl";
            }

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int bookId = Convert.ToInt32(reader["BookId"]);
                string bookName = reader["BookName"].ToString();
                string isbn = reader["ISBN"].ToString();
                string author = reader["Author"].ToString();

                Book book = new Book(bookName, isbn, author);
                book.BookId = bookId;
                bookList.Add(book);
            }

            reader.Close();
            connection.Close();

            return bookList;
        }
    }
}