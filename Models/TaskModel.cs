using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Tasks_Manager.Models
{
    public class TaskModel : IDisposable
    {
        private SqlConnection connection;

        public TaskModel()
        {
            string strConn = "Data Source=localhost;Initial Catalog=tasks;Integrated Security=true";
            connection = new SqlConnection(strConn);
            connection.Open();
        }

        public void Dispose()
        {
            connection.Close();
        }

        public void Create(Task task)
        {
        }

        public List<Task> Read()
        {
            return null;
        }

    }
}