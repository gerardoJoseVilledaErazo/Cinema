

//En esta clase agregaremos las acciones del controlador de Cliente


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cinema.Models;

namespace Cinema.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente/Listado
        public ActionResult Listado()
        {
            
            var cliente1 = new Cliente() { Id = 1, Nombre = "Juan", Edad="26", NumeroTelefono="2255-2255", DUI="0421569-4", Direccion="El Pilar" };
            /*cliente.Id = 1;
            cliente.Nombre = "Juan";
            cliente.Edad = "26";*/
            return View(cliente1);

        }
    }
}