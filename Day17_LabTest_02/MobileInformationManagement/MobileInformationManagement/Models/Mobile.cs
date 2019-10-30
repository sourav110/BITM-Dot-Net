using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MobileInformationManagement.Models
{
    public class Mobile
    {
        public Mobile()
        {
        }

        public Mobile(string modelName, string iMEI, int price)
        {
            ModelName = modelName;
            IMEI = iMEI;
            Price = price;
        }

        public Mobile(int mobileId, string modelName, string iMEI, int price)
        {
            MobileId = mobileId;
            ModelName = modelName;
            IMEI = iMEI;
            Price = price;
        }

        public int MobileId { get; set; }
        public string ModelName { get; set; }
        public string IMEI { get; set; }
        public int Price { get; set; }
    }
}