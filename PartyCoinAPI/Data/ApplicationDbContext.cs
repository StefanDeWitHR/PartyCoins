using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PartyCoinAPI.Models;

namespace PartyCoinAPI.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Company> Companies { get; set; } // Companies
        public DbSet<Party> Partys { get; set; } // Partys
        public DbSet<ApplicationUser> ApplicationUsers { get; set; } // Users
        public DbSet<UserRoles> AspNetRoles { get; set; } // Roles
        public DbSet<PayMethod> PayMethods { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Coin> Coins { get; set; }
        public DbSet<Wallet> Wallets { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            //builder.Entity<Company>()
            //   .HasOne(p => p.Id)
            //   )
            //   .
        }
    }
}
