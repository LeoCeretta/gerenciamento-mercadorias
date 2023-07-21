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

        public IActionResult Editar(int id)
        {
            MercadoriaModel mercadoria = _mercadoriaRepositorio.ListarPorId(id);
            return View(mercadoria);
        }

        public IActionResult ApagarConfirmacao()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Adicionar(MercadoriaModel mercadoria)
        {
            try
            {
                //Validação
                if (ModelState.IsValid)
                {
                    _mercadoriaRepositorio.Adicionar(mercadoria);
                    TempData["MensagemSucesso"] = "Mercadoria cadastrada com sucesso";
                    return RedirectToAction("Index");
                }

                return View(mercadoria);
            }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, não foi possível cadastrar a sua mercadoria, tente novamente! Detalhe do erro: {erro.Message}";
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Alterar(MercadoriaModel mercadoria)
        {
            try
            {
                //Validação
                if (ModelState.IsValid)
                {
                    _mercadoriaRepositorio.Atualizar(mercadoria);
                    TempData["MensagemSucesso"] = "Mercadoria atualizada com sucesso";
                    return RedirectToAction("Index");
                }

                return View("Editar", mercadoria);
            }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, não foi possível atualizar a sua mercadoria, tente novamente! Detalhe do erro: {erro.Message}";
                return RedirectToAction("Index");
            }
        }
    }
}
