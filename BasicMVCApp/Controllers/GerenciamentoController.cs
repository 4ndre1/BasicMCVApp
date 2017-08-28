using System.Web.Mvc;

namespace BasicMVCApp.Controllers
{
    public class GerenciamentoController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Buscar(string nome, int id)
        {
            return View();
        }
    }
}