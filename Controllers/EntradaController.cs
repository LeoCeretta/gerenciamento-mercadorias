using Microsoft.AspNetCore.Mvc;

namespace LEKSupplyApplication.Controllers
{
    public class EntradaController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult RelatorioEntradas()
        {
            return View();
        }

        public IActionResult CadastrarEntrada()
        {
            return View();
        }

    }
}
