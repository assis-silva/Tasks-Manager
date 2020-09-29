using System.Collections.Generic;
using System.Data.SqlClient;

namespace Tasks_Manager.Models
{
    public class TaskModelDelete
    {
        private SqlConnection connection;
        public void Delete(int Id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = @"DELETE FROM task WHERE Id=@Id";

            cmd.Parameters.AddWithValue("@Id", Id);

            cmd.ExecuteNonQuery();
        }

    }
}