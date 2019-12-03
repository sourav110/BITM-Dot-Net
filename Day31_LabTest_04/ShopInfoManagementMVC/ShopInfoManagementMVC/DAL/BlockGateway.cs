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
    public class BlockGateway
    {
        private string connectionString = WebConfigurationManager.ConnectionStrings["ShopInfoDB"].ConnectionString;

        public List<Block> GetBlocks()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("sPGetBlocks", connection);
            command.CommandType = CommandType.StoredProcedure;

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<Block> blocks = new List<Block>();

            while (reader.Read())
            {
                int blockId = Convert.ToInt32(reader["BlockId"]);
                string blockNo = reader["BlockNo"].ToString();

                Block block = new Block(blockId, blockNo);
                blocks.Add(block);
            }

            reader.Close();
            connection.Close();

            return blocks;
        }
    }
}