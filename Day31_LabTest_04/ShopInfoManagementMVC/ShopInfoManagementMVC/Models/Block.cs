using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopInfoManagementMVC.Models
{
    public class Block
    {
        public Block(int blockId, string blockNo)
        {
            BlockId = blockId;
            BlockNo = blockNo;
        }

        public int BlockId { get; set; }
        public string BlockNo { get; set; }
    }
}