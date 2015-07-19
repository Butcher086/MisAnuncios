using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MisAnuncios.Models
{
    public class Anuncio
    {
        public int Id { get; set; }        
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public virtual int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
        public virtual string AutorId { get; set; }
        public virtual ApplicationUser Autor { get; set; }
        
    }
}