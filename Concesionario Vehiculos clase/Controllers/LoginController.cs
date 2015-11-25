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
             FormsAuthentication.RedirectFromLoginPage(model.Login, false); // si lo ponemos en true, mantendría el login en caché
                return null;
            }

            return View(model);
        }

        public ActionResult LogOff()
        {
           FormsAuthentication.SignOut();

            return RedirectToAction("Index");
        }

    }
}