using LEKSupplyApplication.Data;
using LEKSupplyApplication.Models;

namespace LEKSupplyApplication.Repositorio
{
    public class EntradaRepositorio : InterfaceEntradaRepositorio
    {
        private readonly BancoContext _bancoContext;
        public EntradaRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public List<EntradaModel> BuscarTodos()
        {
            // Buscar todos os dados
            return _bancoContext.Entradas.ToList();
        }

        public EntradaModel Adicionar(EntradaModel entrada)
        {
            // Gravar no banco de dados
            _bancoContext.Entradas.Add(entrada);
            _bancoContext.SaveChanges();
            return entrada;
        }
    }
}
