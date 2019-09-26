using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashtableDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //------Hashtable-----//
            //...Hashtable doesn't maintain sequence, it shows values randomly...

            Console.WriteLine("\n---Hashtable Example---");

            Hashtable ht = new Hashtable();
            ht.Add(1, "Basti");
            ht.Add(2, "Poldi");
            ht.Add(3, "Lahm");

            foreach (var key in ht.Keys)
            {
                Console.WriteLine(ht[key]);
            }


            //-----Dictionary-----//

            Console.WriteLine("\n---Dictionary Example---");

            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "One");
            dict.Add(2, "Two");
            dict.Add(3, "Three");

            foreach(var key in dict.Keys)
            {
                Console.WriteLine(dict[key]);
            }


            //---KeyValuePair---//

            Console.WriteLine("\n---KeyValuePair Dictionary Example---");

            Dictionary<int, string> kvpDict = new Dictionary<int, string>();
            //kvpDict.Add(new KeyValuePair<int, string>(11, "Abraham"));
            kvpDict.Add(11, "Abraham");
            kvpDict.Add(12, "Brendon");
            kvpDict.Add(13, "Calix");

            foreach(KeyValuePair<int, string> item in kvpDict)
            {
                Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);
            }
            Console.ReadKey();
        }
    }
}
