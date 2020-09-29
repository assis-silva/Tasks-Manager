using System.Collections.Generic;
using System.Data.SqlClient;

namespace Tasks_Manager.Models
{
    public class TaskModelUpdate
    {
        private SqlConnection connection;
        public void Update(Task task)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = @"UPDATE task SET Title=@Title, Description=@Description, Status WHERE Id=@Id";

            cmd.Parameters.AddWithValue("@Title", task.Title);
            cmd.Parameters.AddWithValue("@Description", task.Description);
            cmd.Parameters.AddWithValue("@Status", task.Status);
            cmd.Parameters.AddWithValue("@Id", task.Id);


            cmd.ExecuteNonQuery();
        }

    }
}