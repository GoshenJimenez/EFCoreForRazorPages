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
        public DbSet<User> Users { get; set; }
        public DbSet<UserLogin> UserLogins { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            List<Role> roles = new List<Role>();
            List<User> users = new List<User>();
            List<UserLogin> userLogins = new List<UserLogin>(); 

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


            users.Add(new User()
            {
                Id = Guid.Parse("1d72f000-dbbd-419b-8af2-f571e1486ac0"),
                Name = "Ajani",
                DateOfBirth = DateTime.Now,
                EmailAddress = "avengeant@mailinator.com",
                Gender = Gender.Male,
                RoleId = Guid.Parse("7ce68d5c-5b65-495a-8a63-14aeb48da87d")
            });

            userLogins.AddRange(new List<UserLogin>()
            {
                new UserLogin()
                {
                    Id = Guid.NewGuid(),
                    UserId =Guid.Parse("1d72f000-dbbd-419b-8af2-f571e1486ac0"),
                    Type = "General",
                    Key = "Password",
                    Value = BCrypt.Net.BCrypt.EnhancedHashPassword("Accord605")
                },
                new UserLogin()
                {
                    Id = Guid.NewGuid(),
                    UserId =Guid.Parse("1d72f000-dbbd-419b-8af2-f571e1486ac0"),
                    Type = "General",
                    Key = "IsActive",
                    Value = "true"
                },
                new UserLogin()
                {
                    Id = Guid.NewGuid(),
                    UserId =Guid.Parse("1d72f000-dbbd-419b-8af2-f571e1486ac0"),
                    Type = "General",
                    Key = "LoginRetries",
                    Value = "0"
                }
            });


            users.Add(new User()
            {
                Id = Guid.Parse("1d72f000-dbbd-419b-8af2-f571e1486ac1"),
                Name = "Liliana",
                DateOfBirth = DateTime.Now,
                EmailAddress = "lvess@mailinator.com",
                Gender = Gender.Female,
                RoleId = Guid.Parse("00965ecf-acae-46fe-8775-d7834b07fd96")
            });

            userLogins.AddRange(new List<UserLogin>()
            {
                new UserLogin()
                {
                    Id = Guid.NewGuid(),
                    UserId =Guid.Parse("1d72f000-dbbd-419b-8af2-f571e1486ac1"),
                    Type = "General",
                    Key = "Password",
                    Value = BCrypt.Net.BCrypt.EnhancedHashPassword("Accord605")
                },
                new UserLogin()
                {
                    Id = Guid.NewGuid(),
                    UserId =Guid.Parse("1d72f000-dbbd-419b-8af2-f571e1486ac1"),
                    Type = "General",
                    Key = "IsActive",
                    Value = "true"
                },
                new UserLogin()
                {
                    Id = Guid.NewGuid(),
                    UserId =Guid.Parse("1d72f000-dbbd-419b-8af2-f571e1486ac1"),
                    Type = "General",
                    Key = "LoginRetries",
                    Value = "0"
                }
            });

            users.Add(new User()
            {
                Id = Guid.Parse("1d72f000-dbbd-419b-8af2-f571e1486ac2"),
                Name = "Kiora",
                DateOfBirth = DateTime.Now,
                EmailAddress = "ktide@mailinator.com",
                Gender = Gender.Female,
                RoleId = Guid.Parse("1fb7085a-762f-440c-87de-59f75f85e935")
            });

            userLogins.AddRange(new List<UserLogin>()
            {
                new UserLogin()
                {
                    Id = Guid.NewGuid(),
                    UserId =Guid.Parse("1d72f000-dbbd-419b-8af2-f571e1486ac2"),
                    Type = "General",
                    Key = "Password",
                    Value = BCrypt.Net.BCrypt.EnhancedHashPassword("Accord605")
                },
                new UserLogin()
                {
                    Id = Guid.NewGuid(),
                    UserId =Guid.Parse("1d72f000-dbbd-419b-8af2-f571e1486ac2"),
                    Type = "General",
                    Key = "IsActive",
                    Value = "true"
                },
                new UserLogin()
                {
                    Id = Guid.NewGuid(),
                    UserId =Guid.Parse("1d72f000-dbbd-419b-8af2-f571e1486ac2"),
                    Type = "General",
                    Key = "LoginRetries",
                    Value = "0"
                }
            });

            modelBuilder.Entity<User>().HasData(users);
            modelBuilder.Entity<UserLogin>().HasData(userLogins);
        }

    }
}
