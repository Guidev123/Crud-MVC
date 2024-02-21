using DevEcomerce.Business.Models;
using Microsoft.EntityFrameworkCore;
namespace DevEcomerce.Data.Context
{
    public class EcomerceDbContext : DbContext
    {
        public EcomerceDbContext(DbContextOptions options)
            :base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            ChangeTracker.AutoDetectChangesEnabled = false; //Config asnotracking
        }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var property in modelBuilder.Model.GetEntityTypes()
                .SelectMany(e => e.GetProperties()
                    .Where(p => p.ClrType == typeof(string))))
            {
                property.SetColumnType("varchar(100)");
            }

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(EcomerceDbContext).Assembly);

            //Isto serve para desativar o modo cascata, por exemplo um fornecedor que tenha vários produtos é deletado e os produtos iriam ser deletados junto, mas desativando o Cascate desta maneira, isso não ocorrera e teremos que exculuir os produtos um por um no sistema
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys())) relationship.DeleteBehavior = DeleteBehavior.ClientSetNull;

            base.OnModelCreating(modelBuilder);
        }

    }
}
