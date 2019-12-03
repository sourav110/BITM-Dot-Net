using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ShopInfoManagementMVC.Models;
using ShopInfoManagementMVC.DAL;

namespace ShopInfoManagementMVC.BLL
{
    public class ShopViewModelManager
    {
        ShopViewModelGateway viewGateway = new ShopViewModelGateway();

        public List<ShopViewModel> GetShopsWithLevelAndBlock()
        {
            return viewGateway.GetShopsWithLevelAndBlock();
        }
    }
}