using Ecommerce.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Data{
    public class AppDbContext : IdentityDbContext<ApplicationUser>{
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {}

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<ProdutoCarrinho> ProdutosCarrinho { get; set; }
        public DbSet<Scored> Scoreds { get; set; }
        public DbSet<Comentario> Comentarios { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<PedidoDetalhe> PedidoDetalhes { get; set; }
    }
}