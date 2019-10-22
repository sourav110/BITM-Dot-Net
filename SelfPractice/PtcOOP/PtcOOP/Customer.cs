using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PtcOOP
{
    class Customer
    {
        public int CustID;
        public string Name;
        public string Address;

        public Customer()
        {
            CustID = 100;
            Name = "James";
            Address = "USA";
        }

        public void Display()
        {
            Console.WriteLine("Customer: " + CustID);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Address: " + Address);
        }

    }
}
