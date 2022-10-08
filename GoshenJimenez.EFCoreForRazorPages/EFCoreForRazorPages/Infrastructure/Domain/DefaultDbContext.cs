using EFCoreForRazorPages.Infrastructure.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreForRazorPages.Infrastructure.Domain
{
    public class DefaultDbContext : DbContext
    {
        public DefaultDbContext(DbContextOptions<DefaultDbContext> options)
          : base(options)
        {
        }
        public DbSet<Role> Roles { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
 
        }

    }
}
