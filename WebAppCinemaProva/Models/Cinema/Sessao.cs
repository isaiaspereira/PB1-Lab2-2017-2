using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppCinemaProva.Models.Cinema
{
    public class Sessao
    {
        public int SessaoId { get; set; }
        public DateTime DataHoraInicio { get; set; }
        public DateTime DataHoraFim { get; set; }
        public decimal ValorInteira { get; set; }
        public bool Encerrada { get; set; }
        public List<Ingresso> Ingresso { get; set; }
        public int FilmeId { get; set; }
        public Filme Filme { get; set; }
        public int SalaId { get; set; }
        public Sala Sala { get; set; }
    }
}