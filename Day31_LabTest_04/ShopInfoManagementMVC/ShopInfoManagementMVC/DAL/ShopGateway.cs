using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Data;
using System.Web.Configuration;
using ShopInfoManagementMVC.Models;

namespace ShopInfoManagementMVC.DAL
{
    public class ShopGateway
    {
        private string connectionString = WebConfigurationManager.ConnectionStrings["ShopInfoDB"].ConnectionString;

        public List<Shop> GetShops()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("sPGetShops", connection);
            command.CommandType = CommandType.StoredProcedure;

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<Shop> shops = new List<Shop>();

            while (reader.Read())
            {
                int shopId = Convert.ToInt32(reader["ShopId"]);
                string shopName = reader["ShopName"].ToString();
                string contactNo = reader["ContactNo"].ToString();
                int levelId = Convert.ToInt32(reader["LevelId"]);
                int blockId = Convert.ToInt32(reader["BlockId"]);
                DateTime openingOn = Convert.ToDateTime(reader["OpeningOn"]);

                Shop shop = new Shop(shopId, shopName, contactNo, levelId, blockId, openingOn);
                shops.Add(shop);
            }

            reader.Close();
            connection.Close();

            return shops;
        }

        public bool SaveShop(Shop shop)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("sPSaveShop", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@ShopName", shop.ShopName);
            command.Parameters.AddWithValue("@ContactNo", shop.ContactNo);
            command.Parameters.AddWithValue("@LevelId", shop.LevelId);
            command.Parameters.AddWithValue("@BlockId", shop.BlockId);
            command.Parameters.AddWithValue("@OpeningOn", shop.OpeningOn);
            
            connection.Open();
            int rowAffect = command.ExecuteNonQuery();
            connection.Close();

            if(rowAffect > 0)
            {
                return true;
            }

            return false;
        }
    }
}