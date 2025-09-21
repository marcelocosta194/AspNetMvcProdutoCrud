using System.Data.Entity;

namespace AspNetMvcProdutoCrud.Models
{
    public class ProdutoContext : DbContext
    {
        public ProdutoContext() : base("DefaultConnection") { }

        public DbSet<Produto> Produtos { get; set; }
    }
}