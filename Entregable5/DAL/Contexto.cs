using Entregable5.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace Entregable5.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Grupos> Grupo { get; set; }

        public DbSet<Personas> Personas { get; set; }
        public DbSet<Cargos> Cargos { get; set; }
        // base("ConStr") para pasar la conexion a la clase base de EntityFramework 
        public Contexto() : base("ConStr")
        { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
