using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndOverriding
{
    class SavingAccount : BankAccount
    {
        public SavingAccount()
        {

        }

        public SavingAccount(string accountNo, string customerName, double interestAmount) 
            : base(accountNo, customerName)
        {
            InterestAmount = interestAmount;
        }
        
        

        public double InterestAmount { get; set; }

        public override string Transfer(string from, string to, double amount)
        {

            return "Successful";
            //throw new NotImplementedException();
        }

        public override string Withdraw(double amount)
        {
            if(amount > Balance)
            {
                return "Insufficient Balance";
            }

            return base.Withdraw(amount);
        }
    }
}
