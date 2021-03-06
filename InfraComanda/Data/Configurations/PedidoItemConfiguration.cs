using Microsoft.EntityFrameworkCore;
using InfraComanda.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
 

namespace InfraComanda.Data.Configurations
{
    public class PedidoItemConfiguration : IEntityTypeConfiguration<PedidoItem>
    {
        public void Configure(EntityTypeBuilder<PedidoItem> builder)
        {
            builder.ToTable("PedidoItens");
            builder.HasKey(p=> p.Id);
            builder.Property(p=> p.PedidoId).HasDefaultValue(1).IsRequired();
            builder.Property(p=> p.Valor).IsRequired();
            builder.Property(p=> p.Desconto).IsRequired();  
        }
    }
}