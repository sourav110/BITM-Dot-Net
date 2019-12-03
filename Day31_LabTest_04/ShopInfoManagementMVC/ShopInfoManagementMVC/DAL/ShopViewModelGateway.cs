using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using ShopInfoManagementMVC.Models;

namespace ShopInfoManagementMVC.DAL
{
    public class ShopViewModelGateway
    {
        private string connectionString = WebConfigurationManager.ConnectionStrings["ShopInfoDB"].ConnectionString;

        public List<ShopViewModel> GetShopsWithLevelAndBlock()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("sPGetShopsWithLevelAndBlock", connection);
            command.CommandType = CommandType.StoredProcedure;

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<ShopViewModel> shopList = new List<ShopViewModel>();

            while (reader.Read())
            {
                int shopId = Convert.ToInt32(reader["ShopId"]);
                string shopName = reader["ShopName"].ToString();
                string contactNo = reader["ContactNo"].ToString();
                int levelId = Convert.ToInt32(reader["LevelId"]);
                int blockId = Convert.ToInt32(reader["BlockId"]);
                string blockNo = reader["BlockNo"].ToString();

                ShopViewModel shopView = new ShopViewModel(shopId, shopName, contactNo, levelId, blockId, blockNo);
                shopList.Add(shopView);
            }

            reader.Close();
            connection.Close();

            return shopList;
        }
    }
}