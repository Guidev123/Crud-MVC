using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using DevEcomerce.ViewModels;

namespace DevEcomerce.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        //public DbSet<DevEcomerce.ViewModels.ProdutoViewModel> ProdutoViewModel { get; set; } = default!;
    }
}
