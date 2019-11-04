using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceRelationshipExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //BankAccount bankAccount = new BankAccount(); //Base class

            SavingsAccount savingsAccount = new SavingsAccount(); //Sub class

            CheckingAccount checkingAccount = new CheckingAccount(); //Sub class

            //BankAccount b1 = new BankAccount();
            SavingsAccount sv1 = new SavingsAccount();
            CheckingAccount chk1 = new CheckingAccount();

            List<BankAccount> bankAccounts = new List<BankAccount>();

            bankAccounts.Add(b1);
            bankAccounts.Add(sv1);
            bankAccounts.Add(chk1);

            foreach(BankAccount account in bankAccounts)
            {
                account.Withdraw(100);
            }

            

        }
    }
}
