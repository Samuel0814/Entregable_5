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

        public virtual ICollection<GruposDetalle> Detalles { get; set; }

        public Grupos()
        {
            this.Detalles = new List<GruposDetalle>();
        }


        public void AgregarDetalle(int Id, int GruposId, int PersonasId, String Cargo)
        {
            this.Detalles.Add(new GruposDetalle(Id, GrupoId, PersonasId, Cargo));
        }
    }
}
