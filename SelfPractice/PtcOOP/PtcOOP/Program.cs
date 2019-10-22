using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PtcOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            Customer customer2 = new Customer();
            Customer customer3 = new Customer();

            customer.Display();
            customer2.Display();
            string custName = customer3.Name; 

            Console.WriteLine(custName);

            Console.ReadKey();
        }
    }
}
