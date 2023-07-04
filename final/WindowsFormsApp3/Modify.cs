using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace WindowsFormsApp3
{
    internal class Modify
    {
        public Modify() { }

        SqlCommand sqlCommand;
        SqlDataReader reader;

        public List<User> Users(string query)
        { 
            List<User> users = new List<User>();

            using(SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                reader = sqlCommand.ExecuteReader();
                while (reader.Read()) 
                {
                    users.Add(new User(reader.GetString(0),reader.GetString(1)));
                }
                sqlConnection.Close();
            }
            return users;
        }

        public void Command(string query)
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection()) 
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand (query, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }
    }
}
