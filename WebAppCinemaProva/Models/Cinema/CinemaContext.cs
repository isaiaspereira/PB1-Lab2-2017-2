using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using WebAppCinemaProva.Configution;

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

            modelBuilder.Conventions.Add<EntityConvention>();

            modelBuilder.Configurations.Add(new SalaMapConfig());
            modelBuilder.Configurations.Add(new SessaoMapConfig());
        }
    }
}