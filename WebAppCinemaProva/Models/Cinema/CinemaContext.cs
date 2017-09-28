using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace WebAppCinemaProva.Models.Cinema
{
    public class CinemaContext:DbContext
    {
        public CinemaContext():base("CinemaBD")
        {

        }
        public DbSet<Sessao> Sessoes { get; set; }
        public DbSet<Ingresso> Ingressos { get; set; }
        public DbSet<Filme> FIlmes { get; set; }
        public DbSet<Autor> Autores { get; set; }
        public DbSet<Sala> Salas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties<int>().Where(c => c.Name == c.ReflectedType + "Id").Configure(c => c.IsKey());
            modelBuilder.Properties<string>().Configure(c => c.HasMaxLength(150));
        }
    }
}