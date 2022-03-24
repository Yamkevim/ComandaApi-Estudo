using Microsoft.EntityFrameworkCore;
using InfraComanda.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InfraComanda.Data.Configurations
{
    public class ProdutoConfiguration:IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("Produtos");
            builder.HasKey(p=> p.Id);
            builder.Property(p=> p.CodigoBarras).HasColumnType("VARCHAR(14)").IsRequired();
            builder.Property(p=> p.Descricao).HasColumnType("VARCHAR(100)").IsRequired();
            builder.Property(p=> p.Valor).IsRequired();
            builder.Property(p=> p.TipoProduto).HasConversion<string>();

        }

    }
}