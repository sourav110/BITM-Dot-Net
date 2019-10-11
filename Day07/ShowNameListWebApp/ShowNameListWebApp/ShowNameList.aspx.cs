using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShowNameListWebApp
{
    public partial class ShowNameList : System.Web.UI.Page
    {
        private List<string> nameList = new List<string>();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addButton_Click(object sender, EventArgs e)
        {
            //ViewState["name"] = nameTextBox.Text;

            if(ViewState["name"] != null)
            {
                nameList = (List<string>) ViewState["name"];
            }
            nameList.Add(nameTextBox.Text);
            ViewState["name"] = nameList;

            nameTextBox.Text = String.Empty;

        }

        protected void showAllButton2_Click(object sender, EventArgs e)
        {
            showListBox.Items.Clear();
            nameList = (List<string>)ViewState["name"];

            foreach(string name in nameList)
            {
                showListBox.Items.Add(name);
            }
        }
    }
}