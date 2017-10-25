using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using WebAppCinemaProva.Models.Cinema;

namespace WebAppCinemaProva.Configution
{
    public class FilmeMapConfig:EntityTypeConfiguration<Filme>
    {
        public FilmeMapConfig()
        {
            HasKey(c => c.FilmeId);

            Property(c => c.Titulo)
                .IsRequired();

        }
    }
}