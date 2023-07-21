using LEKSupplyApplication.Models;

namespace LEKSupplyApplication.Repositorio
{
    public interface InterfaceSaidaRepositorio
    {
        List<SaidaModel> BuscarTodos();

        SaidaModel Adicionar(SaidaModel saida);
    }
}
