using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace BasicMVCApp
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            //Adicionando rotas diferenciadas para controllers ;)
            routes.MapRoute(
                name: "Gerenciamento",
                url: "{controller}/{action}/{nome}/{id}",
                defaults: new { controller = "Gerenciamento", action = "Buscar", nome = UrlParameter.Optional, id = UrlParameter.Optional },
                constraints: new { nome = @"\w+", id = @"\d+" }
            );

            routes.MapRoute(
                name: "Teste",
                url: "{controller}/{nome}/{action}/{id}",
                defaults: new { controller = "Home", action = "Teste", nome = UrlParameter.Optional, id = UrlParameter.Optional },
                constraints: new { nome = @"\w+", id = @"\d+"}
            );
        }
    }
}
