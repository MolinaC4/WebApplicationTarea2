using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace WebApplicationTarea2.BD
{
    public class Conexion
    {
        public string striConexion;
        private SqlConnection connection;

        public SqlConnection Connection { get => connection; set => connection = value; }

        public Conexion()
        {
            striConexion = "Data Source=DESKTOP-5T9QAJU\\SQLEXPRESS;Initial Catalog=bd_tarea2;Integrated Security=True";
            connection = new SqlConnection(striConexion);
        }

        public void CreateCommand(string queryString)
        {
            SqlCommand command = new SqlCommand(queryString, connection);
            command.Connection.Open();
            command.ExecuteNonQuery();
        }

        public void openConnection()
        {
            connection.Open();
        }

        public void closeConnection()
        {
            connection.Close();
        }
    }
}