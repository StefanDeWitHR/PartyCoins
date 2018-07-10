using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

namespace WebAPI.Data
{
    public class DBContext : IDisposable
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

        protected IDbConnection con { get; set; }
        public DBContext()
        {
            string connectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = PartyCoinDB; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
            con = new SqlConnection(connectionString);
        }
        public void Dispose()
        {
            //throw new NotImplementedException();  
        }
    }


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
