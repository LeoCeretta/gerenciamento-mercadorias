using LEKSupplyApplication.Models;
using LEKSupplyApplication.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace LEKSupplyApplication.Controllers
{
    public class EntradaController : Controller
    {
        private readonly InterfaceEntradaRepositorio _entradaRepositorio;
        public EntradaController(InterfaceEntradaRepositorio entradaRepositorio)
        {
            _entradaRepositorio = entradaRepositorio;
        }
        public IActionResult Index()
        {
            List<EntradaModel> entrada = _entradaRepositorio.BuscarTodos();
            return View(entrada);
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
