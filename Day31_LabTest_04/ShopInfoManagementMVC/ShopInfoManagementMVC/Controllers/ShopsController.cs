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
        BlockManager blockManager = new BlockManager();
        LevelManager levelManager = new LevelManager();
        ShopViewModelManager viewManager = new ShopViewModelManager();

        // GET: Shops
        public ActionResult Index()
        {
            //List<Shop> shops = shopManager.GetShops();

            List<ShopViewModel> shopListView = viewManager.GetShopsWithLevelAndBlock();
            return View(shopListView);
        }

        [HttpPost]
        public ActionResult Index(string shopName)
        {
            List<ShopViewModel> shopListView = viewManager.GetShopsWithLevelAndBlock();

            if(shopName != null)
            {
                shopListView = viewManager.GetShopsWithLevelAndBlock().Where(match => match.ShopName.Contains(shopName)).ToList();
            }

            return View(shopListView);
        }
        
        public ActionResult Create()
        {
            var blocks = blockManager.GetBlocks();
            ViewBag.Blocks = blocks;

            var levels = levelManager.GetLevels();
            ViewBag.Levels = levels;

            ViewBag.IsSaved = true;
            return View();
        }

        [HttpPost]
        public ActionResult Create(Shop shop)
        {
            var blocks = blockManager.GetBlocks();
            ViewBag.Blocks = blocks;

            var levels = levelManager.GetLevels();
            ViewBag.Levels = levels;

            var isSaved  = shopManager.SaveShop(shop);

            if (isSaved)
            {
                ViewBag.IsSaved = true;
                return RedirectToAction("Index");
            }

            ViewBag.IsSaved = false;
            return View();
        }
    }
}