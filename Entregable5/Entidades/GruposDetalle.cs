using System;
using System.Collections.Generic;
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
    }
}
