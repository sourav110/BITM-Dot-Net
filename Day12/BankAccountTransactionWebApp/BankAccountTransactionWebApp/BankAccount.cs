using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankAccountTransactionWebApp
{

    [Serializable]
    public class BankAccount
    {
        

        public string AccountNumber { get; set; }
        public string CustomerName { get; set; }
        public double Balance { get; private set; }

        public BankAccount()
        {
            Balance = 0;
        }

        public double Deposit(double amount)
        {
            Balance = Balance + amount;
            return Balance;
            
        }

        public double Withdraw(double amount)
        {
            if(Balance != 0 & amount < Balance)
            {
                Balance = Balance - amount;
            }
            return Balance;
        }

        //public string ShowReport()
        //{

        //}
    }
}