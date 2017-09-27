using System;
using System.Collections.Generic;
using System.Data.Entity;
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
    }
}