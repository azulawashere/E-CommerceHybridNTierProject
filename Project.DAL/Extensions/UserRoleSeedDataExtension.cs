using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Project.ENTITES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Extensions
{
    public static class UserRoleSeedDataExtension
    {
        public static void SeedUsers(ModelBuilder builder)
        {
            IdentityRole<int> role = new()
            {
                Id = 1,
                Name = "Admin",
                NormalizedName="ADMIN",
                ConcurrencyStamp=Guid.NewGuid().ToString(),

            };
            builder.Entity<IdentityRole<int>>().HasData(role);
            PasswordHasher<AppUser> passwordHasher= new PasswordHasher<AppUser>();
            AppUser appUser = new AppUser()
            {
                Id=1,
                UserName="mami123",
                Email="mami@gmail.com",
                NormalizedEmail="MAMI@GMAIL.COM",
                NormalizedUserName="MAMI123",EmailConfirmed=true,
                SecurityStamp=Guid.NewGuid().ToString(),
                PasswordHash=passwordHasher.HashPassword(null,"cgr123")
            };
          builder.Entity<AppUser>().HasData(appUser);


            builder.Entity<IdentityUserRole<int>>().HasData(new IdentityUserRole<int>
            {
                RoleId=role.Id,
                UserId=appUser.Id,
            });
        }
    }
}
