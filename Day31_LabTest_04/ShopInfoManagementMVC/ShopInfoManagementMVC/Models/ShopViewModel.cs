﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopInfoManagementMVC.Models
{
    public class ShopViewModel
    {
        public ShopViewModel(int shopId, string shopName, string contactNo, int levelId, int blockId, string blockNo)
        {
            ShopId = shopId;
            ShopName = shopName;
            ContactNo = contactNo;
            LevelId = levelId;
            BlockId = blockId;
            BlockNo = blockNo;
        }

        public int ShopId { get; set; }
        public string ShopName { get; set; }
        public string ContactNo { get; set; }
        public int LevelId { get; set; }
        public int BlockId { get; set; }
        public string BlockNo { get; set; }
    }
}