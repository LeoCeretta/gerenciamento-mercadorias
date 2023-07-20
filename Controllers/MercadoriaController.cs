using LEKSupplyApplication.Models;
using LEKSupplyApplication.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace LEKSupplyApplication.Controllers
{
    public class MercadoriaController : Controller
    {
        private readonly InterfaceMercadoriaRepositorio _mercadoriaRepositorio;
        public MercadoriaController(InterfaceMercadoriaRepositorio mercadoriaRepositorio) 
        {
            _mercadoriaRepositorio = mercadoriaRepositorio;
        }
        public IActionResult Index()
        {   
            List<MercadoriaModel> mercadoria = _mercadoriaRepositorio.BuscarTodos();
            return View(mercadoria);
        }

        public IActionResult Adicionar()
        {
            return View();
        }

        public IActionResult Editar()
        {
            return View();
        }

        public IActionResult ApagarConfirmacao()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(MercadoriaModel mercadoria)
        {
            _mercadoriaRepositorio.Adicionar(mercadoria);
            return RedirectToAction("Index");
        }
    }
}
