using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DateTimeApp.Models;

namespace DateTimeApp.DAL
{
    class PersonGateway
    {
        private string connectionString = "Server = RDFOX; Database = TestDB; Integrated Security = true";

        public int SavePerson(Person person)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "INSERT INTO Persons(Name, Age, Date) VALUES('"+person.Name+"', "+person.Age+", '"+person.Date+"')";

            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            int rowEffect = command.ExecuteNonQuery();
            connection.Close();

            return rowEffect;
        }
    }
}
