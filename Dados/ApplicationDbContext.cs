using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Dados
{
    public class ApplicationDbContext  : DbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base (options)
        {

        }

        public DbSet<Produto> Produtos { get; set; }

        public DbSet<Venda> Vendas { get; set; }

        public DbSet<ItensVendas> ItensVendas { get; set; }
    }

}