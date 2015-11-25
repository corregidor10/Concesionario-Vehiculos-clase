using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Concesionario_Vehiculos_clase.Models;
using Concesionario_Vehiculos_clase.Utilidades;

namespace Concesionario_Vehiculos_clase.Controllers
{

    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Usuario model)
        {

            if (Membership.ValidateUser(model.Login, model.Password)) // AQUI LLAMAMOS AL MEMBERSHIP QUE TENEMOS DEFINIDO EN EL WEB CONFIG.
            {
                //TempData["HoraLogin"] = DateTime.Now; PUEDE COHABITAR CON LA SESION
                //HttpContext.Application["HoraLogin"] = DateTime.Now;
                Session["HoraLogin"] = DateTime.Now; // recupero la hora de conexion
                FormsAuthentication.RedirectFromLoginPage(model.Login, false); // si lo ponemos en true, mantendría el login en caché
                return null;
            }

            return View(model);
        }

        public ActionResult LogOff()
        {
            Session.Clear(); // borra los datos de la sesion
            Session.Abandon(); // abandona la sesion
            FormsAuthentication.SignOut();

            return RedirectToAction("Index");
        }

    }
}