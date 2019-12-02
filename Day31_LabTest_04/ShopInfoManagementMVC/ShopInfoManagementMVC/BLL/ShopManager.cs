using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ShopInfoManagementMVC.Models;
using ShopInfoManagementMVC.DAL;

namespace ShopInfoManagementMVC.BLL
{
    public class ShopManager
    {
        ShopGateway shopGateway = new ShopGateway();

        public List<Shop> GetShops()
        {
            return shopGateway.GetShops();
        }
    }
}