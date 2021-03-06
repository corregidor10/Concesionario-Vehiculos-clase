﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Concesionario_Vehiculos_clase
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            //routes.MapRoute(
            //    name: "BuscarVehiculo",
            //    url: "Vehiculos/Buscar/{idTipo}/{campo}/{contenido}",
            //    defaults: new
            //    {
            //        controller="Vehiculo",
            //        action="Buscar"
            //    }
            //    );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Tipo", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
