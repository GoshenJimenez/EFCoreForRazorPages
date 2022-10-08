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
            List<Role> roles = new List<Role>();

            roles.Add(new Role()
            {
                Id = Guid.Parse("00965ecf-acae-46fe-8775-d7834b07fd96"),
                Name = "Staff",
                Description = "People who work in school but not teaching",
                Abbreviation = "Stf"
            });

            roles.Add(new Role()
            {
                Id = Guid.Parse("7ce68d5c-5b65-495a-8a63-14aeb48da87d"),
                Name = "Faculty",
                Description = "People who teach in school",
                Abbreviation = "Fct"
            });


            roles.Add(new Role()
            {
                Id = Guid.Parse("1fb7085a-762f-440c-87de-59f75f85e935"),
                Name = "Student",
                Description = "People who learn in school",
                Abbreviation = "Std"
            });

            modelBuilder.Entity<Role>().HasData(roles);
        }

    }
}
