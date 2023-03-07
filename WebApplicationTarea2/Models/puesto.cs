using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Xml.Linq;
using WebApplicationTarea2.BD;

namespace WebApplicationTarea2.Models
{
    public class Puesto
    {
        private int Id_puesto1;
        private String nombre_puesto1;

        public int Id_puesto { get => Id_puesto1; set => Id_puesto1 = value; }

        [Required, StringLength(150), Display(Name = "Name")]
        public string Nombre_puesto { get => nombre_puesto1; set => nombre_puesto1 = value; }

        public void Inserta_puesto()
        {

            Conexion inst = new Conexion();
            SqlCommand sqlCommand = new SqlCommand("spAddUser", inst.Connection);
            SqlCommand cmd = sqlCommand;
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@id_puesto", this.Id_puesto1);
            cmd.Parameters.AddWithValue("@nombre_puesto", this.nombre_puesto1);

            inst.OpenConnection();
            cmd.ExecuteNonQuery();
            inst.CloseConnection();
        }
    }
}