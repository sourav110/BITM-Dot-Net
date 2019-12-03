using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ShopInfoManagementMVC.Models;
using ShopInfoManagementMVC.DAL;

namespace ShopInfoManagementMVC.BLL
{
    public class LevelManager
    {
        LevelGateway levelGateway = new LevelGateway();

        public List<Level> GetLevels()
        {
            return levelGateway.GetLevels();
        }
    }
}