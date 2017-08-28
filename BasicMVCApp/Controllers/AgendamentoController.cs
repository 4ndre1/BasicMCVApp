using System.Web.Mvc;

namespace BasicMVCApp.Controllers
{
    public class AgendamentoController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View("Agendar");
        }

        [HttpGet]
        public ActionResult Marcar(int pacienteId, int medicoId)
        {
            return View("Agendar");
        }

        [HttpGet]
        public ActionResult Teste(string nome, int id)
        {
            return View("Agendar");
        }
    }
} 