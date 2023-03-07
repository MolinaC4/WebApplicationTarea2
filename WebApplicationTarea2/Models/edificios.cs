using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace WebApplicationTarea2.Models
{
    public class Edificios
    {
        [ScaffoldColumn(false)]
        public int Id_edificio { get; set; }

        [Required, StringLength(150), Display(Name = "Name")]
        public string Nombre_edificio { get; set; }
    }
}