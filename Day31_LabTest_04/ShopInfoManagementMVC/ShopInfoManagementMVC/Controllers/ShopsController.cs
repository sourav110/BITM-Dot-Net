using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShopInfoManagementMVC.Models;
using ShopInfoManagementMVC.BLL;

namespace ShopInfoManagementMVC.Controllers
{
    public class ShopsController : Controller
    {
        ShopManager shopManager = new ShopManager();

        // GET: Shops
        public ActionResult Index()
        {
            List<Shop> shops = shopManager.GetShops();
            return View(shops);
        }
    }
}