using System.Collections.Generic;
using System.Data.SqlClient;


namespace Tasks_Manager.Models
{
    public class TaskModelread
    {
        private SqlConnection connection;
        public List<Task> Read()
        {
            List<Task> list = new List<Task>();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = @"SELECT * FROM task";

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                Task task = new Task();
                task.Id = (int)reader["Id"];
                task.Title = (string)reader["Title"];
                task.Description = (string)reader["Description"];
                task.Status = (int)reader["Status"];

                list.Add(task);
            }

            return list;
        }

    }
}