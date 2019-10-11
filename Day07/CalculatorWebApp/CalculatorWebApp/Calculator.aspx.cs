using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CalculatorWebApp
{
    public partial class Calculator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void calculateButton_Click(object sender, EventArgs e)
        {
            double unitPrice = Convert.ToDouble(unitPriceTextBox.Text);
            int quantity = Convert.ToInt32(quantityTextBox.Text);

            double totalPrice = Math.Round(unitPrice * quantity, 2);

            ViewState["Total Price"] = totalPrice;

            ClearTextBox();
        }

        protected void showButton_Click(object sender, EventArgs e)
        {
            totalPriceTextBox.Text = ViewState["Total Price"].ToString();
        }

        private void ClearTextBox()
        {
            unitPriceTextBox.Text = String.Empty;
            quantityTextBox.Text = String.Empty;
        }
    }
}