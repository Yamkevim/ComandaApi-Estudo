using InfraComanda.Domain;
using Microsoft.EntityFrameworkCore;

namespace InfraComanda.Data.Configurations
{
    public class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Pedido> builder)
        {
            builder.ToTable("Pedidos");
            builder.HasKey(p=> p.Id);
            builder.Property(p=> p.Observacao).HasColumnType("VARCHAR(512)");

            builder.HasMany(p=> p.Itens)
                .WithOne(p=> p.Pedido)
                .OnDelete(DeleteBehavior.Cascade);   
        }
    }
}