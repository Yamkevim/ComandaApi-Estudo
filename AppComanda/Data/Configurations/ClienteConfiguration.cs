using System.Net.Http.Headers;
using System.Collections.Immutable;
using AppComanda.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AppComanda.Data.Configurations
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Clientes");
            builder.HasKey(p=> p.Id);
            builder.Property(p=> p.Nome).HasColumnType("VARCHAR(80)").IsRequired();
            builder.Property(p=> p.Telefone).HasColumnType("CHAR(11)").IsRequired();
            builder.Property(p=> p.Cep).HasColumnType("CHAR(8)").IsRequired();
            builder.Property(p=> p.Estado).HasColumnType("CHAR(2)").IsRequired();
            builder.Property(p=> p.Cidade).HasMaxLength(60).IsRequired();

            builder.HasIndex(i => i.Telefone).HasDatabaseName("idx_cliente_telefone");

        }
    }
}