using LEKSupplyApplication.Models;

namespace LEKSupplyApplication.Repositorio
{
    public interface InterfaceMercadoriaRepositorio
    {
        MercadoriaModel ListarPorId(int id);
        List<MercadoriaModel> BuscarTodos();
        MercadoriaModel Adicionar(MercadoriaModel mercadoria);
        MercadoriaModel Atualizar(MercadoriaModel mercadoria);
    }
}
