using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MobileInformationManagement.Models;
using MobileInformationManagement.BLL;
using System.Web.Configuration;
using System.Data.SqlClient;

namespace MobileInformationManagement.DAL
{
    public class MobileGateway
    {
        Mobile mobile = new Mobile();
        string connectionString = WebConfigurationManager.ConnectionStrings["MobileDB"].ConnectionString;


        public bool ExistIMEI(Mobile mobile)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM Mobile_tbl WHERE IMEI = '" + mobile.IMEI + "'";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            Mobile aMobile = null;
            while (reader.Read())
            {
                aMobile = new Mobile();

                aMobile.MobileId = Convert.ToInt32(reader["MobileId"]);
                aMobile.ModelName = reader["ModelName"].ToString();
                aMobile.IMEI = reader["IMEI"].ToString();
                aMobile.Price = Convert.ToInt32(reader["Price"]);

            }

            reader.Close();
            connection.Close();

            if (aMobile != null)
            {
                return true;
            }

            return false;
        }

        public bool SaveMobile(Mobile mobile)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = @"INSERT INTO Mobile_tbl(ModelName, IMEI, Price)" +
                            "VALUES('" + mobile.ModelName + "', '" + mobile.IMEI + "', '" + mobile.Price + "')";

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            int rowEffect = command.ExecuteNonQuery();
            connection.Close();

            if (rowEffect > 0)
            {
                return true;
            }

            return false;
        }


        public List<Mobile> GetAllMobileFromDB(int lower, int higher)
        {
            List<Mobile> mobileList = new List<Mobile>();

            SqlConnection connection = new SqlConnection(connectionString);
            string query;

            if (lower > 0 && higher > 0 && lower < higher)
            {
                query = "SELECT * FROM Mobile_tbl WHERE Price BETWEEN '" + lower + "' AND '" + higher + "';";
            }


            else
            {
                query = "SELECT * FROM Mobile_tbl";
            }



            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {

                int mobileId = Convert.ToInt32(reader["MobileId"]);
                string modelName = reader["ModelName"].ToString();
                string imei = reader["IMEI"].ToString();
                int price = Convert.ToInt32(reader["Price"]);

                Mobile mobile = new Mobile(modelName, imei, price);
                mobile.MobileId = mobileId;
                mobileList.Add(mobile);

            }

            reader.Close();
            connection.Close();

            return mobileList;
        }


        public List<Mobile> GetAllAddedMobileFromDB()
        {
            List<Mobile> mobileList = new List<Mobile>();

            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT * FROM Mobile_tbl";

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {

                int mobileId = Convert.ToInt32(reader["MobileId"]);
                string modelName = reader["ModelName"].ToString();
                string imei = reader["IMEI"].ToString();
                int price = Convert.ToInt32(reader["Price"]);

                Mobile mobile = new Mobile(modelName, imei, price);
                mobile.MobileId = mobileId;
                mobileList.Add(mobile);
            }

            reader.Close();
            connection.Close();

            return mobileList;
        }

        public Mobile GetMobileByIMEI(string imei)
        {
            List<Mobile> mobiles = new List<Mobile>();

            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT * FROM Mobile_tbl WHERE IMEI = '"+imei+"'";

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            Mobile mobile = new Mobile();

            while (reader.Read())
            {
                mobile.ModelName = reader["ModelName"].ToString();
                mobile.IMEI = reader["IMEI"].ToString();
                mobile.Price = Convert.ToInt32(reader["Price"]);
                
            }

            reader.Close();
            connection.Close();

            return mobile;
        }
    }
}