
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;
using AppComanda.Domain;
using AppComanda.Data.Configurations;
using Microsoft.Extensions.Logging;

namespace AppComanda.Data
{
    public class ApplicationContext : DbContext
    {
        

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Produto> Produtos{get; set;}
        public DbSet<Mesa> Mesas { get; set; }

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