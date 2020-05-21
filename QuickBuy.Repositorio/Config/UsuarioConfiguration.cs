using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entidades;
using System;


namespace QuickBuy.Repositorio.Config
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(u => u.Id);




            //Builder utiliza padrão Fluent
            builder
                .Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(40);
            builder
               .Property(u => u.Nome)
               .IsRequired()
               .HasMaxLength(40);
            builder
               .Property(u => u.Senha)
               .IsRequired()
               .HasMaxLength(400);
            builder
               .Property(u => u.SobreNome)
               .IsRequired()
               .HasMaxLength(40);
            //builder
            //   .Property(u => u.Pedidos)
            //   .IsRequired()
            //   .HasMaxLength(40);




        }
    }
}
