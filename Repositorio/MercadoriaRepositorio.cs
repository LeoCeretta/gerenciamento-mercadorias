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
        public MercadoriaModel ListarPorId(int id)
        {
            return _bancoContext.Mercadoria.FirstOrDefault(x => x.Id == id);
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

        public MercadoriaModel Atualizar(MercadoriaModel mercadoria)
        {
            MercadoriaModel mercadoriaDB = ListarPorId(mercadoria.Id);

            if (mercadoriaDB == null) throw new System.Exception("Houve um erro na atualização do contato");

            mercadoriaDB.Nome = mercadoria.Nome;
            mercadoriaDB.NmrRegistro = mercadoria.NmrRegistro;
            mercadoriaDB.Fornecedor = mercadoria.Fornecedor;
            mercadoriaDB.Tipo = mercadoria.Tipo;
            mercadoriaDB.Descricao = mercadoria.Descricao;

            _bancoContext.Mercadoria.Update(mercadoriaDB);
            _bancoContext.SaveChanges();

            return mercadoriaDB;
        }
    }
}
