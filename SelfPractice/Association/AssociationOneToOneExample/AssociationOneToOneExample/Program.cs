using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociationOneToOneExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address1 = new Address("23", "11A", "Dhanmondi", 1205, "Dhaka");
            Person person1 = new Person("Touhidul", "Islam", "Sumon");

            person1.PersonAddress = address1;

            Address person1Address = person1.PersonAddress;

            int postalCode = person1.PersonAddress.PostCode;

        }
    }
}
