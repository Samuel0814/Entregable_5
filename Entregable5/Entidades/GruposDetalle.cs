using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entregable5.Entidades
{
    public class GruposDetalle
    {
        [Key]
        public int Id { get; set; }
        public int GruposId { get; set; }
        public int PersonasId { get; set; }
        public string Cargo { get; set; }

        public GruposDetalle()
        {
            this.Id = 0;
            this.GruposId = 0;
            this.PersonasId = 0;
        }
        public GruposDetalle(int id, int GruposId, int PersonaId, String Cargo)
        {
            this.Id = id;
            this.GruposId = GruposId;
            this.PersonasId = PersonasId;
            this.Cargo = Cargo;
        }
    }
}
