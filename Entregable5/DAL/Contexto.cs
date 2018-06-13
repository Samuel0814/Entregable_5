using Entregable5.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace Entregable5.DAL
{
    public class Contexto
    {
        public DbSet<Grupos> Grupo { get; set; }
        public Contexto() : base("ConStr")
        { }

        internal void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
