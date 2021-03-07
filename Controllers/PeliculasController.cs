


//En esta clase agregaremos las acciones del controlador de Peliculas




using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cinema.Models;

namespace Cinema.Controllers
{
    public class PeliculasController : Controller
    {
        // GET: Peliculas/Aleatorias
        public ActionResult Aleatorias()
        {
            var pelicula1 = new Pelicula() { Id=1, Nombre = "Shrek", Genero="Animacion, Aventura, Comedia", AnioLanzamiento=2001, Clasificacion="PG" };
            //pelicula1.Nombre = "Shrek";

            return View(pelicula1);
        }
    }
}