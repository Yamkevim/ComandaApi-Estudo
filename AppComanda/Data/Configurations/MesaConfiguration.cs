using Microsoft.EntityFrameworkCore;
using AppComanda.Domain;

namespace AppComanda.Data.Configurations
{
    public class MesaConfiguration : IEntityTypeConfiguration<Mesa>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Mesa> builder)
        {
            builder.ToTable("Mesas");
            builder.HasKey(p=> p.Id);
            builder.Property(p=> p.Status).HasConversion<int>();

              
        }
    }
}