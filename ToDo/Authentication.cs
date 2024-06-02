using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ToDo
{
    public class Authentication
    {
        string connString = "Server=localhost;Database=todo;User ID=user;Password=password;AllowPublicKeyRetrieval=True;";

        //Gets the user's id
        public int getUserId(string username, string password)
        {
            int userId = 0;

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                string query = "select id from users where username = @username and password = @password";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                try
                {
                    conn.Open();
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        userId = Convert.ToInt32(result);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e.Message);
                }
            }
            return userId;
        }
    }
}
