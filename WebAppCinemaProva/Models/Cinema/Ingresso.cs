using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppCinemaProva.Models.Cinema
{
    public class Ingresso
    {
        public int IngressoId { get; set; }
        public Tipo Tipo { get; set; }
        public List<Sessao> Sessao { get; set; }
    }
}