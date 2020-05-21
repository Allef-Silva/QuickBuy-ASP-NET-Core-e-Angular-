using Microsoft.EntityFrameworkCore;
using QuickBuy.Dominio;
using QuickBuy.Dominio.Entidades;
using QuickBuy.Repositorio.Config;

namespace QuickBuy.Repositorio.Contexto
{
    public class QuickBuyContext : DbContext
    {
        
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<FormaPagamento> FormaPagamento { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<ItemPedido> ItensPedidos { get; set; }

        public QuickBuyContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ///Classes de mapeamento aqui...
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration);
            modelBuilder.ApplyConfiguration(new ProdutoConfiguration);
            modelBuilder.ApplyConfiguration(new PedidoConfiguration);
            modelBuilder.ApplyConfiguration(new ItemPedidoConfiguration);
            modelBuilder.ApplyConfiguration(new FormaPagamentoConfiguration);
            base.OnModelCreating(modelBuilder);
        }




    }
}
