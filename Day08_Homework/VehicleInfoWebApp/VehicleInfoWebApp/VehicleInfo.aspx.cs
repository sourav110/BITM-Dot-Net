using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VehicleInfoWebApp
{
    public partial class VehicleInfo : System.Web.UI.Page
    {

        Vehicle aVehicle = new Vehicle();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void createButton_Click(object sender, EventArgs e)
        {
            aVehicle.VehicleName = nameTextBox.Text;
            aVehicle.RegNo = regNoTextBox.Text;

            ViewState["Vehicle"] = aVehicle;
        }

        protected void enterButton_Click(object sender, EventArgs e)
        {
            Vehicle speedVehicle = (Vehicle)ViewState["Vehicle"];
            speedVehicle.speedList.Add(Convert.ToDouble(speedTextBox.Text));

            speedTextBox.Text = String.Empty;
        }

        protected void showButton_Click(object sender, EventArgs e)
        {
            Vehicle bVehicle = (Vehicle)ViewState["Vehicle"];

            double maxSpeed = bVehicle.GetMaxSpeed();
            double minSpeed = bVehicle.GetMinSpeed();
            double avgSpeed = Math.Round(bVehicle.GetAverageSpeed(), 2);

            string detail = bVehicle.GetDetail();

            maxTextBox.Text = maxSpeed.ToString();
            minTextBox.Text = minSpeed.ToString();
            avgTextBox.Text = avgSpeed.ToString();

            detailTextBox.Text = detail;

            speedTextBox.Text = String.Empty;
            nameTextBox.Text = String.Empty;
            regNoTextBox.Text = String.Empty;
        }
    }
}