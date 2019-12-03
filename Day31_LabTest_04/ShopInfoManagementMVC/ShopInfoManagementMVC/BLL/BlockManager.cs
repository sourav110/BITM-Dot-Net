using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ShopInfoManagementMVC.Models;
using ShopInfoManagementMVC.DAL;

namespace ShopInfoManagementMVC.BLL
{
    public class BlockManager
    {
        BlockGateway blockGateway = new BlockGateway();

        public List<Block> GetBlocks()
        {
            return blockGateway.GetBlocks();
        }
    }
}