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
    public class puesto
    {
        private int id_puesto1;
        private String nombre_puesto1;

        public int id_puesto { get => id_puesto1; set => id_puesto1 = value; }

        [Required, StringLength(150), Display(Name = "Name")]
        public string nombre_puesto { get => nombre_puesto1; set => nombre_puesto1 = value; }

        public void inserta_puesto()
        {

            Conexion inst = new Conexion();
            SqlCommand cmd = new SqlCommand("spAddUser", inst.Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@id_puesto", this.id_puesto1);
            cmd.Parameters.AddWithValue("@nombre_puesto", this.nombre_puesto1);

            inst.openConnection();
            cmd.ExecuteNonQuery();
            inst.closeConnection();
        }
    }
}