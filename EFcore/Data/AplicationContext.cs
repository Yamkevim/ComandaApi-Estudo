
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;
using EFcore.Domain;
using EFcore.Data.Configurations;

namespace EFcore.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            const string strConnection="Data source=(localdb)\\mssqllocaldb; Initial Catalog=EFcore;Integrated Security=true;pooling=true;";
            optionsBuilder
                .UseSqlServer(strConnection);
                
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClienteConfiguration());
            ModuleBuilder.ApplyCAssembly(new )
        }
    }
}