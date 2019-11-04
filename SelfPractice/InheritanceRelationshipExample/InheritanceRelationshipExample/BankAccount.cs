using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceRelationshipExample
{
    abstract class BankAccount
    {
        public string AccountNo { set; get; }
        public string CustomerName { set; get; }
        public double Balance {private set; get; }

        public string Deposit(double amount)
        {
            Balance += amount;
            return "Deposited";
        }

        public virtual string Withdraw(double amount)
        {
            Balance -= amount;
            return "Withdrawn";
        }

        public abstract void Transfer(string from, string to, int amount);
    }
}
