using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndOverriding
{
    class Program
    {
        static void Main(string[] args)
        {
            //BankAccount b1 = new BankAccount();

            SavingAccount sv1 = new SavingAccount("Saving001", "Alex", 2000);

            Console.WriteLine(sv1.Deposit(50000));
            Console.WriteLine(sv1.Withdraw(5000));
            Console.WriteLine(sv1.Balance);
            Console.WriteLine(sv1.Withdraw(5000));
            Console.WriteLine(sv1.Balance);
            Console.WriteLine(sv1.Withdraw(50000));
            Console.WriteLine(sv1.Balance);

            Console.WriteLine();

            CheckingAccount chk1 = new CheckingAccount("Checking002", "Calix", 4000);

            Console.WriteLine(chk1.Deposit(50000));
            Console.WriteLine(chk1.Withdraw(10000));
            Console.WriteLine(sv1.Balance);
            Console.WriteLine(chk1.Withdraw(70000));
            Console.WriteLine(chk1.Balance);

            Console.WriteLine();

            BankAccount b2 = sv1; //upcast

            b2.Withdraw(500);

            SavingAccount sv2 = new SavingAccount();
            SavingAccount sv3 = new SavingAccount();
            CheckingAccount chk3 = new CheckingAccount();

            SavingAccount sv4 = (SavingAccount)b2; //downcast
            
            List<BankAccount> bankAccounts = new List<BankAccount>()
            {
                b2, sv1, chk1
            };

            foreach (var acount in bankAccounts)
            {
                acount.Withdraw(500);
            }


            BankAccount b4 = sv1;
            BankAccount b5 = chk1;

            SavingAccount sv5 = (SavingAccount)b4;
            sv5.Withdraw(500);

            b4.Withdraw(1000);

            //Console.WriteLine(b1.Equals(sv1));
            //Console.WriteLine(b1.Equals(chk1));

            Console.ReadKey();
        }
    }
}
