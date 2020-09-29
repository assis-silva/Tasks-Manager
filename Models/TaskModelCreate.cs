using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace Tasks_Manager.Models
{
    public class TaskModelCreate
    {
        private SqlConnection connection;
        public void Create(Task task)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = @"INSERT INTO task VALUES (@Title, @Description, @Status)";

            cmd.Parameters.AddWithValue("@Title", task.Title);
            cmd.Parameters.AddWithValue("@Description", task.Description);
            cmd.Parameters.AddWithValue("@Status", task.Status);

            cmd.ExecuteNonQuery();
        }

    }
}