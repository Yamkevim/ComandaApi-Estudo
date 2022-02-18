using EFcore.Domain;
using Microsoft.EntityFrameworkCore;

namespace EFcore.Data.Configurations
{
    public class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Pedido> builder)
        {
            builder.ToTable("Pedidos");
            builder.HasKey(p=> p.Id);
            builder.Property(p=> p.IniciadoEm).HasDefaultValue("GETDATE()").ValueGeneratedOnAdd();
            builder.Property(p=> p.TipoFrete).HasConversion<int>();
            builder.Property(p=> p.Observacao).HasColumnType("VARCHAR(512)");

            builder.HasMany(p=> p.Itens)
                .WithOne(p=> p.Pedido)
                .OnDelete(DeleteBehavior.Cascade);   
        }
    }
}