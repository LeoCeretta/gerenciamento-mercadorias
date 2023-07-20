using Microsoft.AspNetCore.Mvc;

namespace LEKSupplyApplication.Controllers
{
    public class SaidaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult RelatorioSaidas()
        {
            return View();
        }

        public IActionResult CadastrarSaida()
        {
            return View();
        }
    }
}
