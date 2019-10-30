using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MobileInformationManagement.Models;
using MobileInformationManagement.BLL;

namespace MobileInformationManagement
{
    public partial class ShowMobileUi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ShowAllAddedMobile();
        }

        protected void searchButton_Click(object sender, EventArgs e)
        {
            int lower = Convert.ToInt32(inputLowerPrice.Value);
            int higher = Convert.ToInt32(inputHigherPrice.Value);

            ShowAllMobile(lower, higher);

            inputLowerPrice.Value = String.Empty;
            inputHigherPrice.Value = String.Empty;
        }

        private void ShowAllMobile(int lower, int higher)
        {
            MobileManager mobileManager = new MobileManager();

            MobileGridView.DataSource = mobileManager.GetAllMobile(lower, higher);
            MobileGridView.DataBind();
        }

        private void ShowAllAddedMobile()
        {
            MobileManager mobileManager = new MobileManager();

            MobileGridView.DataSource = mobileManager.GetAllAddedMobile();
            MobileGridView.DataBind();
        }
    }
}