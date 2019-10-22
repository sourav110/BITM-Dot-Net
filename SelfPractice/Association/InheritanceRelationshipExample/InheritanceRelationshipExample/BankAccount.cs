using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceRelationshipExample
{
    class BankAccount
    {
        public string AccountNo { set; get; }
        public string CustomerName { get; set; }
        public double Balance { private set; get; }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            Balance -= amount;
        }
    }
}
