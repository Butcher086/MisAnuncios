using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MisAnuncios.Models
{
    public class AnuncioViewModel
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string Categoria { get; set; }
        public string Autor { get; set; }
    }
}