using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BasicMVCApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [ActionName("Teste")]
        public ActionResult Contact(string nome, int id)
        {
            ViewBag.Message = "Your contact page.";

            return View("Contact");
        }

        [HttpGet]
        public ActionResult Marcar(int pacienteId, int medicoId)
        {
            return View("Index");
        }
    }
}