using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using WebAppCinemaProva.Models.Cinema;

namespace WebAppCinemaProva.Configution
{
    public class IngressoMapConfig:EntityTypeConfiguration<Ingresso>
    {
        public IngressoMapConfig()
        {
            HasKey(c => c.IngressoId);

            HasRequired(c => c.Sessao)
                .WithMany(c => c.Ingresso)
                .HasForeignKey(c => c.SessaoId);
        }
    }
}