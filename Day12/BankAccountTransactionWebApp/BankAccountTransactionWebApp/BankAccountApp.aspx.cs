using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BankAccountTransactionWebApp
{
    public partial class BankAccountApp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void createButton_Click(object sender, EventArgs e)
        {
            BankAccount account = new BankAccount();

            string accountNo = accountNoTextBox.Text;
            string customerName = customerNameTextBox.Text;

            account.AccountNumber = accountNo;
            account.CustomerName = customerName;

            ViewState["Account"] = account;
            ClearText();

            reportLabel.Text = "Account created successfully";
            createButton.Enabled = false;

        }


        protected void ClearText()
        {
            accountNoTextBox.Text = String.Empty;
            customerNameTextBox.Text = String.Empty;
        }

        protected void depositButton_Click(object sender, EventArgs e)
        {
            BankAccount accountInfo = (BankAccount)ViewState["Account"];

            double amount = Convert.ToDouble(amountTextBox.Text);
            if(amount < 0)
            {
                reportLabel.Text = "Invalid amount!";
            }
            else
            {
                accountInfo.Deposit(amount);
                reportLabel.Text = "Deposit Successfull!";
            }
           
            amountTextBox.Text = String.Empty;

            //ViewState["Account"] = accountInfo;
        }

        protected void withdrawButton_Click(object sender, EventArgs e)
        {
            BankAccount accountInfo = (BankAccount)ViewState["Account"];

            double amount = Convert.ToDouble(amountTextBox.Text);
            if(amount < 0)
            {
                reportLabel.Text = "Invalid amount!";
            }

            else if(amount > accountInfo.Balance)
            {
                reportLabel.Text = "Insufficient balance!";
            }
            else
            {
                accountInfo.Withdraw(amount);
                reportLabel.Text = "Withdraw Successfull!";
            }
            
            amountTextBox.Text = String.Empty;

            //ViewState["Account"] = accountInfo;

        }

        protected void showReportButton_Click(object sender, EventArgs e)
        {
            BankAccount accountInfo = (BankAccount)ViewState["Account"];

            reportLabel.Text = accountInfo.CustomerName + ", your account number: " + accountInfo.AccountNumber + " and its balance: " + accountInfo.Balance + " TK";
        }
    }
}