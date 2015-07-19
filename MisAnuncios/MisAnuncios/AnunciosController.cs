using MisAnuncios.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MisAnuncios
{
    public class AnunciosController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public IHttpActionResult Get(Ciudades ciudad)
        {
            var anuncios = db.Anuncios.Where(a => a.Autor.Ciudad == ciudad)
                .Select(a => new AnuncioViewModel()
                {
                    Id = a.Id,
                    Autor = a.Autor.Nombre,
                    Categoria = a.Categoria.Nombre,
                    Descripcion = a.Descripcion,
                    Titulo = a.Titulo
                }).ToList();
            
            return Ok(anuncios);
        }
    }
}
