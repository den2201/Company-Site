
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using My_company.Domain.Entities;

namespace My_company.Domain
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
             
        public DbSet<TextField> TextFields { get; set; }
        public DbSet<ServiceItem> ServiceItems { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<IdentityRole>().HasData(new IdentityRole()
            {
                Id = "0589C86B-94E1-400E-A544-A285B17F7CCE",
                Name = "Admin",
                NormalizedName = "ADMIN"
            });
            
            builder.Entity<IdentityUser>().HasData(new IdentityUser()
            {
                Id = "B399E0B3-08E6-4409-9420-B3F22EC6390A",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "1@mail.ru",
                NormalizedEmail = "1@MAIL.RU",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null,"12345"),
                SecurityStamp = string.Empty
            });
            
            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>()
            {
                RoleId = "0589C86B-94E1-400E-A544-A285B17F7CCE",
                UserId = "B399E0B3-08E6-4409-9420-B3F22EC6390A"
            });
           
            builder.Entity<TextField>().HasData(new TextField()
            {
                Id = new System.Guid("681A5C5A-5D3E-4CFD-AC4A-C789D7E0159C"),
                CodeWord = "PageIndex",
                Title = "Main"
            });

            builder.Entity<TextField>().HasData(new TextField()
            {
                Id = new System.Guid("04C00F48-9CC0-4C29-9727-4AED3EA9F081"),
                CodeWord = "PageServices",
                Title = "Services"
            });

            builder.Entity<TextField>().HasData(new TextField()
            {
                Id = new System.Guid("6C1A2F5F-A7DF-44D5-9DD7-33DA4D5A68C9"),
                CodeWord = "PageContacts",
                Title = "Contacts"
            });

        }

    }
}
