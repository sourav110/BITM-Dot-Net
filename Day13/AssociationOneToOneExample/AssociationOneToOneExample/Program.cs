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
            Person person1 = new Person("James", "H", "Leo");

            person1.PersonAddress = address1; //set
            Address person1Address = person1.PersonAddress; //get

            int postalCode = person1.PersonAddress.PostCode;
            //int postalCode = person1Address.PostCode;

            Console.WriteLine(postalCode);
            
            //Console.WriteLine(person1Address.District);

            Person person2 = new Person("Phil", "G.", "Lahm");
            Address address2 = new Address("33", "23A", "Dhanmondi", 1209, "Dhaka");

            person2.PersonAddress = address2; //refering one object to another

            string district = person2.PersonAddress.District;

            Console.WriteLine(district);
            Console.WriteLine();

            Person person3 = new Person("Mario", "Gomez", "Super");
            Address address3 = new Address("43", "34A", "Mirpur", 1218, "Dhaka");

            person3.PersonAddress = address3;
            Address person3Address = address3;
            int postalCode3 = address3.PostCode;
            Console.WriteLine(postalCode3);

            Console.ReadKey();
        }
    }
}
