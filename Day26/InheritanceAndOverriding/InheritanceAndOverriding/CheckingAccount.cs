using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndOverriding
{
    class CheckingAccount : BankAccount
    {
        public CheckingAccount()
        {
        }

        public CheckingAccount(string accountNo, string customerName, double serviceCharge)
            : base(accountNo, customerName)
        {
            ServiceCharge = serviceCharge;
        }

        public double ServiceCharge { get; set; }

        public override string Transfer(string from, string to, double amount)
        {
            return "Failed";
            //throw new NotImplementedException();
        }
    }
}
