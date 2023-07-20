using LEKSupplyApplication.Data;
using LEKSupplyApplication.Models;

namespace LEKSupplyApplication.Repositorio
{
    public class MercadoriaRepositorio : InterfaceMercadoriaRepositorio
    {
        private readonly BancoContext _bancoContext;
        public MercadoriaRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public List<MercadoriaModel> BuscarTodos()
        {
            // Buscar todos os dados
            return _bancoContext.Mercadoria.ToList();
        }

        public MercadoriaModel Adicionar(MercadoriaModel mercadoria)
        {
            // Gravar no banco de dados
            _bancoContext.Mercadoria.Add(mercadoria);
            _bancoContext.SaveChanges();
            return mercadoria;
        }

    }
}
