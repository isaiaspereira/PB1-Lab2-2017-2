using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppCinemaProva.Models.Cinema
{
    public class Filme
    {
        public int FilmeId { get; set; }
        public string Titulo { get; set; }
        public decimal Duracao { get; set; }
        public List<Sessao> Sessao { get; set; }
        public List<Autor> Autor { get; set; }
    }
}