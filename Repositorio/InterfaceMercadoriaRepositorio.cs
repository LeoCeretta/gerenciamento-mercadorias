using LEKSupplyApplication.Models;

namespace LEKSupplyApplication.Repositorio
{
    public interface InterfaceMercadoriaRepositorio
    {
        List<MercadoriaModel> BuscarTodos();
        MercadoriaModel Adicionar(MercadoriaModel mercadoria);
    }
}
