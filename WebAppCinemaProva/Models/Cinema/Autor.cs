using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppCinemaProva.Models.Cinema
{
    public class Autor
    {
        public int AutorId { get; set; }
        public string Nome { get; set; }
        public List<Filme> Filme { get; set; }

    }
}