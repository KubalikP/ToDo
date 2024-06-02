using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ToDo
{
    public class UserAccess
    {
        private string connString = "Server=localhost;Database=todo;User ID=user;Password=password;AllowPublicKeyRetrieval=True;";

        //Creates a user
        public void createUser(string username, string password)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                try
                {
                    string query = "insert into users (username, password) values (@username, @password)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registered succesfully");
                }
                catch (MySqlException e)
                {
                    if (e.Message.Contains("Duplicate entry"))
                    {
                        MessageBox.Show("Username already exists");
                    }
                }
            }
        }

        //Gets user username
        public string getUsername(int userId)
        {
            string username = "";

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                string query = "select username from users where id = @userId";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@userId", userId);
                conn.Open();
                cmd.ExecuteNonQuery();
                username = Convert.ToString(cmd.ExecuteScalar());
            }

            return username;
        }

        //Gets user password
        public string getPassword(int userId)
        {
            string password = "";

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                string query = "select password from users where id = @userId";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@userId", userId);
                conn.Open();
                cmd.ExecuteNonQuery();
                password = Convert.ToString(cmd.ExecuteScalar());
            }

            return password;
        }

        //Gets all tasks
        public List<Task> getTasks(int userId)
        {
            List<Task> tasks = new List<Task>();

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                string query = "SELECT id, taskName, start_date, end_date, end_time, completed FROM tasks WHERE user_id = @userId";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@userId", userId);
                conn.Open();

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Task task = new Task(
                            reader.GetInt32("id"),
                            reader.GetString("taskName"),
                            reader.GetDateTime("start_date"),
                            reader.GetDateTime("end_date"),
                            reader.GetDateTime("end_time"),
                            reader.GetBoolean("completed")
                        );

                        tasks.Add(task);
                    }
                }
            }

            return tasks;
        }

        //Adds a task
        public void addTask(Task task, int userId)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                string query = "INSERT INTO tasks (user_id, taskName, start_date, end_date, end_time) VALUES (@userId, @taskName, @startDate, @endDate, @endTime)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@userId", userId);
                cmd.Parameters.AddWithValue("@taskName", task.TaskName);
                cmd.Parameters.AddWithValue("@startDate", task.Start_date);
                cmd.Parameters.AddWithValue("@endDate", task.End_date);
                cmd.Parameters.AddWithValue("@endTime", task.End_time);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        //Removes a task
        public void removeTask(int taskId, int userId)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                string query = "delete from tasks where id = @id and user_id = @userId";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", taskId);
                cmd.Parameters.AddWithValue("@userId", userId);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Method to remove all tasks for a user
        public void removeAllTasks(int userId)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                string query = "DELETE FROM tasks WHERE user_id = @userId";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@userId", userId);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        //Updates "completed" columns
        public void saveCompleted(List<Task> tasks, int userId)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();

                foreach (Task task in tasks)
                {
                    string query = "update tasks set completed = @completed where id = @taskId and user_id = @userId";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@completed", task.Completed);
                    cmd.Parameters.AddWithValue("@taskId", task.Id);
                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        //Updates username and password
        public void updateUser(int userId, string newUsername, string newPassword)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                string query = "update users set username = @newUsername, password = @newPassword where id = @userId";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@newUsername", newUsername);
                cmd.Parameters.AddWithValue("@newPassword", newPassword);
                cmd.Parameters.AddWithValue("@userId", userId);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        //Updates username only
        public void updateUsername(int userId, string newUsername)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                string query = "update users set username = @newUsername where id = @userId";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@newUsername", newUsername);
                cmd.Parameters.AddWithValue("@userId", userId);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        //Updates password only
        public void updatePassword(int userId, string newPassword)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                string query = "update users set password = @newPassword where id = @userId";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@newPassword", newPassword);
                cmd.Parameters.AddWithValue("@userId", userId);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
