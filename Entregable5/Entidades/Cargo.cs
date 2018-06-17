using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entregable5.Entidades
{
    public class Cargos
    {
        [Key]
        public int CargoId { get; set; }
        public string Cargo { get; set; }

        public Cargos()
        {

        }

        //Este truco permitira que se vea el Cargo 
        //en el grid.
        public override string ToString()
        {
            return this.Cargo;
        }

    }
}
