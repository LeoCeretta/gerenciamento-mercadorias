using LEKSupplyApplication.Data;
using LEKSupplyApplication.Models;

namespace LEKSupplyApplication.Repositorio
{
    public class SaidaRepositorio : InterfaceSaidaRepositorio
    {
        private readonly BancoContext _bancoContext;
        public SaidaRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public List<SaidaModel> BuscarTodos()
        {
            // Buscar todos os dados
            return _bancoContext.Saidas.ToList();
        }

        public SaidaModel Adicionar(SaidaModel saida)
        {
            // Gravar no banco de dados
            _bancoContext.Saidas.Add(saida);
            _bancoContext.SaveChanges();
            return saida;
        }
    }
}
