using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopInfoManagementMVC.Models
{
    public class Shop
    {
        public Shop(int shopId, string shopName, string contactNo, int levelId, int blockId, DateTime openingOn)
        {
            ShopId = shopId;
            ShopName = shopName;
            ContactNo = contactNo;
            LevelId = levelId;
            BlockId = blockId;
            OpeningOn = openingOn;
        }

        public Shop()
        {

        }

        public int ShopId { get; set; }
        public string ShopName { get; set; }
        public string ContactNo { get; set; }
        public int LevelId { get; set; }
        public int BlockId { get; set; }
        public DateTime OpeningOn { get; set; }
    }
}