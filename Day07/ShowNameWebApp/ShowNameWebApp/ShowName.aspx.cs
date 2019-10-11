using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShowNameWebApp
{
    public partial class ShowName : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addButton_Click(object sender, EventArgs e)
        {
            ViewState["name"] = nameTextBox.Text;
            nameTextBox.Text = String.Empty;
        }

        protected void showButton_Click(object sender, EventArgs e)
        {
            showLabel.Text = ViewState["name"].ToString();
        }
    }
}