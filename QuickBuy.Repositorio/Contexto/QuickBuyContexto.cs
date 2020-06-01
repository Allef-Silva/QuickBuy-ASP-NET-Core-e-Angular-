using Microsoft.EntityFrameworkCore;
using QuickBuy.Dominio;
using QuickBuy.Dominio.Entidades;
using QuickBuy.Repositorio.Config;

namespace QuickBuy.Repositorio.Contexto
{
    public class QuickBuyContexto : DbContext
    {
        
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<FormaPagamento> FormaPagamento { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<ItemPedido> ItensPedidos { get; set; }

        public QuickBuyContexto(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ///Classes de mapeamento aqui...
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new ProdutoConfiguration());
            modelBuilder.ApplyConfiguration(new PedidoConfiguration());
            modelBuilder.ApplyConfiguration(new ItemPedidoConfiguration());
            modelBuilder.ApplyConfiguration(new FormaPagamentoConfiguration());

            modelBuilder.Entity<FormaPagamento>().HasData
                (new FormaPagamento() {
                    Id=1,Nome="Boleto",
                    Descricao= "Forma De Pagamento Boleto" },
                    new FormaPagamento()
                    {
                        Id = 2,
                        Nome = "Cartão De Crédito",
                        Descricao = "Forma De Pagamento Cartão de Crédito"
                    },
                    new FormaPagamento()
                    {
                        Id = 3,
                        Nome = "Depósito",
                        Descricao = "Forma De Pagamento Depósito"
                    }
                );
            base.OnModelCreating(modelBuilder);
        }




    }
}
