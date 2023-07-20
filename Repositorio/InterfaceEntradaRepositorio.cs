using LEKSupplyApplication.Models;

namespace LEKSupplyApplication.Repositorio
{
    public interface InterfaceEntradaRepositorio
    {
        List<EntradaModel> BuscarTodos();

        EntradaModel Adicionar(EntradaModel entrada);
      
    }
}