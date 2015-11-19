using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Concesionario_Vehiculos_clase.Models;

namespace Concesionario_Vehiculos_clase.Controllers
{
    public class TipoController : Controller
    {
        Vehiculo20Entities db= new Vehiculo20Entities();
        
        // GET: Tipo
        public ActionResult Index()
        {
         
            return View(db.Tipo.ToList());
        }

        public ActionResult Alta()
        {
            return View(new Tipo());
        }

        [HttpPost]
        public ActionResult Alta(Tipo model)
        {
            if (ModelState.IsValid)
            {
                db.Tipo.Add(model);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }
    }
}