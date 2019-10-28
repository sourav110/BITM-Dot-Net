using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using BookInformationManagement.Models;
using BookInformationManagement.DAL;
using BookInformationManagement.BLL;

namespace BookInformationManagement
{
    public partial class ShowBookUi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void searchButton_Click(object sender, EventArgs e)
        {
            string searchBook = inputSearchBook.Value;
            ShowAllBook(searchBook);

            inputSearchBook.Value = String.Empty;
        }

        private void ShowAllBook(string searchBook)
        {
            BookManager bookManager = new BookManager();

            BookGridView.DataSource = bookManager.GetAllBook(searchBook);
            BookGridView.DataBind();
        }
    }
}