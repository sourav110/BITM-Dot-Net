using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MobileInformationManagement.BLL;
using MobileInformationManagement.Models;

namespace MobileInformationManagement
{
    public partial class SearchImeiUi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void searchButton_Click(object sender, EventArgs e)
        {
            string searchIMEI = inputIMEI.Value;

            Mobile aMobile = new Mobile();
            MobileManager mobileManager = new MobileManager();

            aMobile = mobileManager.GetMobileByIMEI(searchIMEI);

            modelNameLabel.Text = aMobile.ModelName;
            imeiLabel.Text = aMobile.IMEI;
            priceLabel.Text = aMobile.Price.ToString();

            inputIMEI.Value = String.Empty;
        }

    }
}