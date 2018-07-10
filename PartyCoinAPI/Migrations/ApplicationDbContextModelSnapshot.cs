﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using PartyCoinAPI.Data;
using System;

namespace PartyCoinAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityRole");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("PartyCoinAPI.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<Guid>("CmpId");

                    b.Property<Guid?>("CompanyId");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<DateTime>("DtBirth");

                    b.Property<DateTime>("DtCreated");

                    b.Property<DateTime>("DtLastLogin");

                    b.Property<DateTime>("DtModified");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<int>("LActive");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.Property<string>("UserRoleId")
                        .IsRequired();

                    b.Property<Guid>("WalletId");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("PartyCoinAPI.Models.Coin", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AgeRequired");

                    b.Property<DateTime>("DtCreated");

                    b.Property<DateTime>("DtModified");

                    b.Property<int>("LActive");

                    b.Property<string>("Logo");

                    b.Property<Guid>("PartyId");

                    b.Property<float>("Price");

                    b.HasKey("Id");

                    b.ToTable("Coins");
                });

            modelBuilder.Entity("PartyCoinAPI.Models.Company", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("address")
                        .IsRequired();

                    b.Property<string>("Bank");

                    b.Property<string>("City")
                        .IsRequired();

                    b.Property<string>("Country")
                        .IsRequired();

                    b.Property<DateTime>("DtCreated");

                    b.Property<DateTime>("DtModified");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("KvkNum")
                        .IsRequired();

                    b.Property<int>("LActive");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Phone")
                        .IsRequired();

                    b.Property<string>("VatNum")
                        .IsRequired();

                    b.Property<string>("Website");

                    b.Property<string>("ZipCode")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("PartyCoinAPI.Models.Currency", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("CoinId");

                    b.Property<Guid?>("CompanyId");

                    b.Property<DateTime>("DtCreated");

                    b.Property<DateTime>("DtModified");

                    b.Property<int>("LActive");

                    b.Property<Guid?>("PartyId");

                    b.HasKey("Id");

                    b.HasIndex("CoinId");

                    b.HasIndex("CompanyId");

                    b.HasIndex("PartyId");

                    b.ToTable("Currency");
                });

            modelBuilder.Entity("PartyCoinAPI.Models.Menu", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<float>("AlcholPerc");

                    b.Property<Guid>("CmpId");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<DateTime>("DtCreated");

                    b.Property<DateTime>("DtModified");

                    b.Property<string>("Ingredients")
                        .IsRequired();

                    b.Property<int>("LActive");

                    b.Property<Guid>("PartyId");

                    b.Property<float>("Qty");

                    b.HasKey("Id");

                    b.HasIndex("PartyId");

                    b.ToTable("Menus");
                });

            modelBuilder.Entity("PartyCoinAPI.Models.Party", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<int>("AgeRequired");

                    b.Property<string>("City")
                        .IsRequired();

                    b.Property<Guid>("CmpId");

                    b.Property<Guid>("CoinId");

                    b.Property<Guid?>("CompanyId");

                    b.Property<string>("CoordX")
                        .IsRequired();

                    b.Property<string>("CoordY")
                        .IsRequired();

                    b.Property<string>("Country");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<DateTime>("DtCreated");

                    b.Property<DateTime>("DtModified");

                    b.Property<DateTime>("DtParty");

                    b.Property<int>("LActive");

                    b.Property<string>("LineUp")
                        .IsRequired();

                    b.Property<string>("Logo")
                        .IsRequired();

                    b.Property<string>("LongDescription");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<float>("Price");

                    b.Property<string>("Route");

                    b.Property<Guid>("StatusId");

                    b.Property<string>("Website");

                    b.Property<string>("ZipCode")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Partys");
                });

            modelBuilder.Entity("PartyCoinAPI.Models.PayMethod", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("CmpId");

                    b.Property<Guid?>("CompanyId");

                    b.Property<DateTime>("DtCreated");

                    b.Property<DateTime>("DtModified");

                    b.Property<int>("LActive");

                    b.Property<Guid>("PartyId");

                    b.Property<string>("Provider")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("PartyId");

                    b.ToTable("PayMethods");
                });

            modelBuilder.Entity("PartyCoinAPI.Models.Transaction", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("CmpId");

                    b.Property<DateTime>("DtCreated");

                    b.Property<DateTime>("DtModified");

                    b.Property<int>("LActive");

                    b.Property<Guid>("PartyId");

                    b.Property<Guid>("PaymethodId");

                    b.Property<float>("Qty");

                    b.Property<Guid>("UserId");

                    b.Property<Guid>("WalletId");

                    b.HasKey("Id");

                    b.HasIndex("WalletId");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("PartyCoinAPI.Models.UserCoin", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("CoinId");

                    b.Property<string>("Qty")
                        .IsRequired();

                    b.Property<Guid>("UserId");

                    b.Property<Guid>("WalletId");

                    b.HasKey("Id");

                    b.HasIndex("WalletId");

                    b.ToTable("UserCoin");
                });

            modelBuilder.Entity("PartyCoinAPI.Models.Wallet", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DtCreated");

                    b.Property<DateTime>("DtModified");

                    b.Property<int>("LActive");

                    b.Property<Guid>("UserId");

                    b.HasKey("Id");

                    b.ToTable("Wallets");
                });

            modelBuilder.Entity("PartyCoinAPI.Models.UserRole", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityRole");

                    b.Property<Guid>("CmpId");

                    b.Property<Guid>("PartyId");

                    b.ToTable("UserRole");

                    b.HasDiscriminator().HasValue("UserRole");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("PartyCoinAPI.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("PartyCoinAPI.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PartyCoinAPI.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("PartyCoinAPI.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PartyCoinAPI.Models.ApplicationUser", b =>
                {
                    b.HasOne("PartyCoinAPI.Models.Company")
                        .WithMany("Users")
                        .HasForeignKey("CompanyId");
                });

            modelBuilder.Entity("PartyCoinAPI.Models.Currency", b =>
                {
                    b.HasOne("PartyCoinAPI.Models.Coin")
                        .WithMany("Currencys")
                        .HasForeignKey("CoinId");

                    b.HasOne("PartyCoinAPI.Models.Company")
                        .WithMany("Currenys")
                        .HasForeignKey("CompanyId");

                    b.HasOne("PartyCoinAPI.Models.Party")
                        .WithMany("Currencyss")
                        .HasForeignKey("PartyId");
                });

            modelBuilder.Entity("PartyCoinAPI.Models.Menu", b =>
                {
                    b.HasOne("PartyCoinAPI.Models.Party")
                        .WithMany("Menus")
                        .HasForeignKey("PartyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PartyCoinAPI.Models.Party", b =>
                {
                    b.HasOne("PartyCoinAPI.Models.Company")
                        .WithMany("Partys")
                        .HasForeignKey("CompanyId");
                });

            modelBuilder.Entity("PartyCoinAPI.Models.PayMethod", b =>
                {
                    b.HasOne("PartyCoinAPI.Models.Company")
                        .WithMany("PayMethods")
                        .HasForeignKey("CompanyId");

                    b.HasOne("PartyCoinAPI.Models.Party")
                        .WithMany("PayMethods")
                        .HasForeignKey("PartyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PartyCoinAPI.Models.Transaction", b =>
                {
                    b.HasOne("PartyCoinAPI.Models.Wallet")
                        .WithMany("Transactions")
                        .HasForeignKey("WalletId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PartyCoinAPI.Models.UserCoin", b =>
                {
                    b.HasOne("PartyCoinAPI.Models.Wallet")
                        .WithMany("UserCoins")
                        .HasForeignKey("WalletId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
