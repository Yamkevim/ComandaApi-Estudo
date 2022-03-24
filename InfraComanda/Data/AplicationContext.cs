
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore; 
using InfraComanda.Data.Configurations;
using InfraComanda.Domain;
using Microsoft.Extensions.Logging;

namespace InfraComanda.Data
{
    public class ApplicationContext : DbContext
    {
        

        public DbSet<Cliente>? Clientes { get; set; }
        public DbSet<Pedido>? Pedidos { get; set; }
        public DbSet<Produto>? Produtos{get; set;}
        public DbSet<Mesa>? Mesas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            const string strConnection="Data source=(localdb)\\mssqllocaldb; Initial Catalog=EFcore;Integrated Security=true;pooling=true;";
            optionsBuilder
                .UseSqlServer(strConnection);

                
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClienteConfiguration());
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationContext).Assembly );
        }
    }
}