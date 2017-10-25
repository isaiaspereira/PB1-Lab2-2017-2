using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using WebAppCinemaProva.Models.Cinema;

namespace WebAppCinemaProva.Configution
{
    public class SessaoMapConfig:EntityTypeConfiguration<Sessao>
    {
        public SessaoMapConfig()
        {
            HasKey(k => k.SessaoId);

            Property(c => c.DataHoraFim)
                .IsRequired()
                .HasColumnType("dateTime2");

            Property(c => c.DataHoraInicio)
                .IsRequired()
                .HasColumnType("dateTime2");

            Property(p => p.ValorInteira)
                .IsRequired();

            HasRequired(c => c.Filme)
                .WithMany(c => c.Sessao)
                .HasForeignKey(c => c.FilmeId);


            Property(c => c.ValorMeia)
                .IsOptional();
        }
    }
}