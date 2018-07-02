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
        public DbSet<UserRole> AspNetRoles { get; set; } // Roles
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
            ////Company 1 :N Partys
            //builder.Entity<Company>()
            //.HasMany(x => x.Partys)
            //.WithOne(y => y.Company)
            //.HasForeignKey(x => x.CmpId)
            //.OnDelete(DeleteBehavior.Restrict);

            //// Company 1  : N Paymethods
            //builder.Entity<Company>()
            //.HasMany(x => x.PayMethods)
            //.WithOne(y => y.Company)
            //.HasForeignKey(x => x.CmpId)
            //.OnDelete(DeleteBehavior.Restrict);

            //// Company 1  : N  Users
            //builder.Entity<Company>()
            //.HasMany(x => x.Users)
            // .WithOne(y => y.Company)
            //.HasForeignKey(x => x.CmpId)
            //.OnDelete(DeleteBehavior.Restrict);

            //// Company 1  : N  Currencys
            //builder.Entity<Company>()
            //.HasMany(x => x.Currenys)
            // .WithOne(y => y.Company)
            //.HasForeignKey(x => x.Id)
            //.OnDelete(DeleteBehavior.Restrict);

            //// User 1  : 1 Wallet
            //builder.Entity<ApplicationUser>()
            //.HasOne(x => x.Wallet)
            // .WithOne(y => y.User);
            
            

            //// User 1  : 1 Wallet
            //builder.Entity<ApplicationUser>()
            //.HasOne(x => x.Wallet)
            // .WithOne(y => y.User);

            ////// User 1 : 1 UserRole
            ////builder.Entity<ApplicationUser>()
            ////.HasOne(x => x.UserRole)
            //// .WithOne(y => y.User);

            //// Wallet 1 : N Usercoins
            //builder.Entity<Wallet>()
            //.HasMany(x => x.UserCoins)
            // .WithOne(y => y.Wallet)
            //.HasForeignKey(x => x.Id)
            //.OnDelete(DeleteBehavior.Restrict);

            //// Party 1 : N Menus
            //builder.Entity<Party>()
            //.HasMany(x => x.Menus)
            // .WithOne(y => y.Party)
            //.HasForeignKey(x => x.Id)
            //.OnDelete(DeleteBehavior.Restrict);

            //// Party 1 : N PayMethods
            //builder.Entity<Party>()
            //.HasMany(x => x.PayMethods)
            // .WithOne(y => y.Party)
            //.HasForeignKey(x => x.Id)
            //.OnDelete(DeleteBehavior.Restrict);

            //// Transaction 1 : 1 Company
            //builder.Entity<Transaction>()
            //.HasOne(x => x.Company)
            // .WithOne(y => y.Transaction);

            //// Transaction 1 : 1 Company
            //builder.Entity<Transaction>()
            //.HasOne(x => x.Party)
            // .WithOne(y => y.Transactions);

            //// Transaction 1 : 1 Company
            //builder.Entity<Transaction>()
            //.HasOne(x => x.Wallet)
            // .WithOne(y => y.Transactions);
            //// Company 1  : N Paymethods
            ////builder.Entity<Company>()
            ////.HasMany(x => x.Users)
            //// .(y => y);
            ////builder.Entity<Company>()
            ////.HasMany(x => x.Users)
            ////    .WithMany(y => y.)
            ////    .Map(cs =>
            ////    {
            ////        cs.MapLeftKey("StudentRefId");
            ////        cs.MapRightKey("CourseRefId");
            ////        cs.ToTable("StudentCourse");
            ////    });

            //// Festival 1  : N Menus
            //builder.Entity<Party>()
            //.HasMany(x => x.Menus)
            //.WithOne(y => y.Party)
            //.HasForeignKey(x => x.Id)
            //.OnDelete(DeleteBehavior.Restrict);



            //// Wallet 1 : N UserCoins
            //builder.Entity<Wallet>()
            //.HasMany(x => x.UserCoins)
            //.WithOne(y=> y.Wallet);

            //// Wallet 1 : 1 User
            //builder.Entity<Wallet>()
            //.HasOne(x => x.User)
            //.WithOne(y => y.Wallet);
            ///*********************************/




            ////builder.Entity<Wallet>()
            ////.HasMany(u => u.UserCoin)
            ////.WithOne(w => w.ser);

            ////builder.Entity<Company>()
            ////   .HasOne(p => p.Id)
            ////   )
            ////   .
        }
    }
}
