using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entregable5.Entidades
{
    public class Personas
    {
        [Key]
        public int PersonasId { get; set; }
        public DateTime Fecha { get; set; }
        public string Nombres { get; set; }
        public string Cedula { get; set; }
        public String Telefono { get; set; }
        public string Direccion { get; set; }


        public Personas()
        {
            PersonasId = 0;
            Fecha = DateTime.Now;//inicializamos con la fecha actual.
            Nombres = string.Empty;
            Cedula = string.Empty;
            Telefono = string.Empty;
            Direccion = string.Empty;
        }
    }
}
