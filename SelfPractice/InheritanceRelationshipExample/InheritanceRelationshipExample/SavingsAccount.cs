using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceRelationshipExample
{
    class SavingsAccount : BankAccount
    {
        public double InterestAmount { set; get; }

        public override string Withdraw(double amount)
        {
            if(Balance - amount > 0)
            {
                return base.Withdraw(amount);
            }

            else
            {
                return "Insufficient Balance";
            }
        }

        public override void Transfer(string from, string to, int amount)
        {
            //todo
        }
    }
}
