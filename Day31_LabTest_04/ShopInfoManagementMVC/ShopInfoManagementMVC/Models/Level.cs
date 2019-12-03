using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopInfoManagementMVC.Models
{
    public class Level
    {
        public Level(int levelId, int levelNo)
        {
            LevelId = levelId;
            LevelNo = levelNo;
        }

        public int LevelId { get; set; }
        public int LevelNo { get; set; }
    }
}