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
    public class LevelGateway
    {
        private string connectionString = WebConfigurationManager.ConnectionStrings["ShopInfoDB"].ConnectionString;

        public List<Level> GetLevels()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("sPGetLevels", connection);
            command.CommandType = CommandType.StoredProcedure;

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<Level> levels = new List<Level>();

            while (reader.Read())
            {
                int levelId = Convert.ToInt32(reader["LevelId"]);
                int levelNo = Convert.ToInt32(reader["LevelNo"]);

                Level level = new Level(levelId, levelNo);
                levels.Add(level);
            }

            reader.Close();
            connection.Close();

            return levels;
        }
    }
}