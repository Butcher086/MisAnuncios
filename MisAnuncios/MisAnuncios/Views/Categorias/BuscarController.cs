using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using MisAnuncios.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MisAnuncios.Views.Categorias
{
    [Authorize]
    public class BuscarController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Buscar
        public ActionResult Index()
        {
            var categorias = db.Categorias.ToList();
            ViewBag.Categorias = new List<SelectListItem>();
            categorias.ForEach(c =>
            {
                ViewBag.Categorias.Add(new SelectListItem()
                {
                    Text = c.Nombre,
                    Value = c.Id.ToString()
                });
            });
            return View();
        }
        [HttpPost]
        public ActionResult Index(string query, int categoria)
        { 
            var userManager = HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            var userId = User.Identity.GetUserId();
            var user = userManager.FindById(userId);

            var results = db.Anuncios
                .Where(a => a.CategoriaId == categoria && a.Autor.Ciudad == user.Ciudad &&
                    a.Titulo.ToLower().Contains(query.ToLower()))
                .ToList();
            return PartialView("_resultados", results);
        }
    }
}