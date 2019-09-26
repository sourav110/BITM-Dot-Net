using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListArraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            //--------List Basic------//

            List<string> countryName = new List<string>();
            countryName.Add("Germany");
            countryName.Add("Italy");
            countryName.Add("France");
            countryName.Add("Spain");

            foreach(var item in countryName)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("");

            //-----Arraylist-----//

            ArrayList nameList = new ArrayList();
            nameList.Add("Basti");
            nameList.Add("Poldi");
            nameList.Add("Lahm");

            foreach(var item in nameList)
            {
                Console.WriteLine(item);
            }


            Console.ReadKey();
        }
    }
}
