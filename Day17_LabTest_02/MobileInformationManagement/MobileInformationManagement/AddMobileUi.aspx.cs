using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MobileInformationManagement.Models;
using MobileInformationManagement.BLL;
using MobileInformationManagement.DAL;
using System.Drawing;

namespace MobileInformationManagement
{
    public partial class AddMobileUi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        MobileManager mobileManager = new MobileManager();

        protected void saveButton_Click(object sender, EventArgs e)
        {
            string modelName = inputModelName.Value;
            string imei = inputIMEI.Value;
            int price = Convert.ToInt32(inputPrice.Value);

            Mobile mobile = new Mobile(modelName, imei, price);

            string msg = mobileManager.SaveMobile(mobile);
            messageLabel.Text = msg;

            if (msg == "Mobile info Saved Successfully")
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
            inputModelName.Value = String.Empty;
            inputIMEI.Value = String.Empty;
            inputPrice.Value = String.Empty;
        }
    }
}