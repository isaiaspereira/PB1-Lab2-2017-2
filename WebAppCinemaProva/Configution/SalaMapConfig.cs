using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using WebAppCinemaProva.Models.Cinema;

namespace WebAppCinemaProva.Configution
{
    public class SalaMapConfig : EntityTypeConfiguration<Sala>
    {
        public SalaMapConfig()
        {
            HasKey(c => c.SalaId);

            Property(p => p.Numero)
                .IsRequired();

            Property(p => p.Capacidade)
                .IsRequired();

            Property(p => p.Descricao)
                .IsRequired()
                .HasMaxLength(300);

            HasOptional(c => c.Sessao)
             .WithRequired(c => c.Sala)
             .WillCascadeOnDelete(true);

            HasOptional(s => s.Localizacao)
                .WithRequired(c => c.Sala)
                .WillCascadeOnDelete(true);
        }
    }
}