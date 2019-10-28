using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

using BookInformationManagement.Models;
using BookInformationManagement.DAL;
using BookInformationManagement.BLL;


namespace BookInformationManagement
{
    public partial class AddBookUi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        BookManager bookManager = new BookManager();

        protected void saveButton_Click(object sender, EventArgs e)
        {
            string bookName = inputBookName.Value;
            string isbn = inputISBN.Value;
            string author = inputAuthor.Value;

            Book book = new Book(bookName, isbn, author);

            string msg = bookManager.SaveBook(book);
            messageLabel.Text = msg;
            
            if (msg == "Book Saved Successfully")
            {
                messageLabel.ForeColor = Color.Green;
            }
            else
            {
                messageLabel.ForeColor = Color.Red;
            }

            ClearField();

        }

        private void ClearField()
        {
            inputBookName.Value = String.Empty;
            inputISBN.Value = String.Empty;
            inputAuthor.Value = String.Empty;
        }
    }
}