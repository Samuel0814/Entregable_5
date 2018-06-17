using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entregable5.Entidades
{
    public class Grupos
    {
        [Key]
        public int GrupoId { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public int Grupox { get; set; }
        public int Integrantes { get; set; }
        public Grupos()
        {
            GrupoId = 0;
            Fecha = DateTime.Now;
            Descripcion = string.Empty;
            Cantidad = 0;
            Grupox = 0;
            Integrantes = 0;
        }
    }
}
