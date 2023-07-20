using LEKSupplyApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace LEKSupplyApplication.Data
{
    public class BancoContext : DbContext
    {
        
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
        }
        //Contexto de tabelas, posso criar várias
        
        //Mercadorias
        public DbSet<MercadoriaModel> Mercadoria { get; set;}

        //Entradas
        public DbSet<EntradaModel> Entradas { get; set;}


        //Saídas
        public DbSet<SaidaModel> Saidas { get; set;}
    }
}
