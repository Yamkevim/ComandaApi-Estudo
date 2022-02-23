
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;
using EFcore.Domain;
using EFcore.Data.Configurations;
using Microsoft.Extensions.Logging;

namespace EFcore.Data
{
    public class ApplicationContext : DbContext
    {
        private static readonly ILoggerFactory _logger = LoggerFactory.Create(p=>p.AddConsole());

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Produto> Produtos{get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            const string strConnection="Data source=(localdb)\\mssqllocaldb; Initial Catalog=EFcore;Integrated Security=true;pooling=true;";
            optionsBuilder
                .UseLoggerFactory(_logger)
                .EnableSensitiveDataLogging()
                .UseSqlServer(strConnection);

                
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClienteConfiguration());
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationContext).Assembly );
        }
    }
}