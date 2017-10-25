using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppCinemaProva.Models.Cinema
{
    public class Sala
    {
        public int SalaId { get; set; }
        public int Numero { get; set; }
        public int Capacidade { get; set; }
        public string Descricao { get; set; }
        public virtual Sessao Sessao { get; set; }
    }
}