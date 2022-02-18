
using Microsoft.EntityFrameworkCore;
using EFcore.Domain;

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
           modelBuilder.Entity<Cliente>(p=>
           {
               p.ToTable("Clientes");
               p.HasKey(p=> p.Id);
               p.Property(p=> p.Nome).HasColumnType("VARCHAR(80)").IsRequired();
               p.Property(p=> p.Telefone).HasColumnType("CHAR(11)").IsRequired();
               p.Property(p=> p.Cep).HasColumnType("CHAR(8)").IsRequired();
               p.Property(p=> p.Estado).HasColumnType("CHAR(2)").IsRequired();
               p.Property(p=> p.Cidade).HasMaxLength(60).IsRequired();

               p.HasIndex(i => i.Telefone).HasDatabaseName("idx_cliente_telefone");

             
           }); 

           modelBuilder.Entity<Produto>(p=>
           {
               p.ToTable("Produtos");
               p.HasKey(p=> p.Id);
               p.Property(p=> p.CodigoBarras).HasColumnType("VARCHAR(14)").IsRequired();
               p.Property(p=> p.Descricao).HasColumnType("VARCHAR(100)").IsRequired();
               p.Property(p=> p.Valor).IsRequired();
               p.Property(p=> p.TipoProduto).HasConversion<string>();
              

             
           });

            modelBuilder.Entity<Pedido>(p=>
           {
                p.ToTable("Pedidos");
                p.HasKey(p=> p.Id);
                p.Property(p=> p.IniciadoEm).HasDefaultValue("GETDATE()").ValueGeneratedOnAdd();
                p.Property(p=> p.TipoFrete).HasConversion<int>();
                p.Property(p=> p.Observacao).HasColumnType("VARCHAR(512)");

                    p.HasMany(p=> p.Itens)
                        .WithOne(p=> p.Pedido)
                        .OnDelete(DeleteBehavior.Cascade);   

             
           });

            modelBuilder.Entity<PedidoItem>(p=>
           {
               p.ToTable("PedidoItens");
               p.HasKey(p=> p.Id);
               p.Property(p=> p.PedidoId).HasDefaultValue(1).IsRequired();
               p.Property(p=> p.Valor).IsRequired();
               p.Property(p=> p.Desconto).IsRequired();

              

             
           });  
        }
    }
}