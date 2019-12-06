using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using ProtPracticeMVC.Models;

namespace ProtPracticeMVC.DAL
{
    public class SemesterGateway
    {
        private string connectionString = WebConfigurationManager.ConnectionStrings["ProjectDbContext"].ConnectionString;

        public List<Semester> GetSemesters()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("sPGetSemesters", connection);
            command.CommandType = CommandType.StoredProcedure;

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<Semester> semesters = new List<Semester>();

            while (reader.Read())
            {
                int semesterId = Convert.ToInt32(reader["SemesterId"]);
                string semesterNo = reader["SemesterNo"].ToString();

                Semester semester = new Semester(semesterId, semesterNo);
                semesters.Add(semester);
            }

            reader.Close();
            connection.Close();

            return semesters;
        }
    }
}