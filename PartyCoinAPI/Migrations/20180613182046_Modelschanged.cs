using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace PartyCoinAPI.Migrations
{
    public partial class Modelschanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Partys",
                table: "Partys");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Companies",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "guid",
                table: "Partys");

            migrationBuilder.DropColumn(
                name: "age_required",
                table: "Partys");

            migrationBuilder.DropColumn(
                name: "guid_company",
                table: "Partys");

            migrationBuilder.DropColumn(
                name: "guid",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "guid_cmp",
                table: "AspNetRoles");

            migrationBuilder.RenameColumn(
                name: "website",
                table: "Partys",
                newName: "Website");

            migrationBuilder.RenameColumn(
                name: "price",
                table: "Partys",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Partys",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "logo",
                table: "Partys",
                newName: "Logo");

            migrationBuilder.RenameColumn(
                name: "adres",
                table: "Partys",
                newName: "Adres");

            migrationBuilder.RenameColumn(
                name: "zip_code",
                table: "Partys",
                newName: "ZipCode");

            migrationBuilder.RenameColumn(
                name: "status",
                table: "Partys",
                newName: "LActive");

            migrationBuilder.RenameColumn(
                name: "long_desc",
                table: "Partys",
                newName: "StatusId");

            migrationBuilder.RenameColumn(
                name: "line_up",
                table: "Partys",
                newName: "LongDescription");

            migrationBuilder.RenameColumn(
                name: "l_active",
                table: "Partys",
                newName: "AgeRequired");

            migrationBuilder.RenameColumn(
                name: "dt_party",
                table: "Partys",
                newName: "DtParty");

            migrationBuilder.RenameColumn(
                name: "dt_modified",
                table: "Partys",
                newName: "DtModified");

            migrationBuilder.RenameColumn(
                name: "dt_created",
                table: "Partys",
                newName: "DtCreated");

            migrationBuilder.RenameColumn(
                name: "desc",
                table: "Partys",
                newName: "LineUp");

            migrationBuilder.RenameColumn(
                name: "coord_y",
                table: "Partys",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "coord_x",
                table: "Partys",
                newName: "CoordY");

            migrationBuilder.RenameColumn(
                name: "zipcode",
                table: "Companies",
                newName: "Zipcode");

            migrationBuilder.RenameColumn(
                name: "website",
                table: "Companies",
                newName: "Website");

            migrationBuilder.RenameColumn(
                name: "phone",
                table: "Companies",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Companies",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "curreny",
                table: "Companies",
                newName: "Curreny");

            migrationBuilder.RenameColumn(
                name: "country",
                table: "Companies",
                newName: "Country");

            migrationBuilder.RenameColumn(
                name: "bank",
                table: "Companies",
                newName: "Bank");

            migrationBuilder.RenameColumn(
                name: "adres",
                table: "Companies",
                newName: "Adres");

            migrationBuilder.RenameColumn(
                name: "l_active",
                table: "Companies",
                newName: "LActive");

            migrationBuilder.RenameColumn(
                name: "kvk_num",
                table: "Companies",
                newName: "KvkNum");

            migrationBuilder.RenameColumn(
                name: "dt_modified",
                table: "Companies",
                newName: "DtModified");

            migrationBuilder.RenameColumn(
                name: "dt_created",
                table: "Companies",
                newName: "DtCreated");

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "Partys",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CmpId",
                table: "Partys",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CoordX",
                table: "Partys",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "Companies",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CmpId",
                table: "AspNetRoles",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Partys",
                table: "Partys",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Companies",
                table: "Companies",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Coins",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    AgeRequired = table.Column<int>(nullable: false),
                    CmpId = table.Column<string>(nullable: true),
                    DtCreated = table.Column<DateTime>(nullable: false),
                    DtModified = table.Column<DateTime>(nullable: false),
                    LActive = table.Column<int>(nullable: false),
                    Logo = table.Column<string>(nullable: true),
                    PartyId = table.Column<string>(nullable: true),
                    Price = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    AlcholPerc = table.Column<float>(nullable: false),
                    CmpId = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DtCreated = table.Column<DateTime>(nullable: false),
                    DtModified = table.Column<DateTime>(nullable: false),
                    Ingredients = table.Column<string>(nullable: true),
                    LActive = table.Column<int>(nullable: false),
                    PartyId = table.Column<string>(nullable: true),
                    Qty = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PayMethods",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CmpId = table.Column<string>(nullable: true),
                    DtCreated = table.Column<DateTime>(nullable: false),
                    DtModified = table.Column<DateTime>(nullable: false),
                    LActive = table.Column<int>(nullable: false),
                    Provider = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PayMethods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CmpId = table.Column<string>(nullable: true),
                    DtCreated = table.Column<DateTime>(nullable: false),
                    DtModified = table.Column<DateTime>(nullable: false),
                    LActive = table.Column<int>(nullable: false),
                    PartyId = table.Column<string>(nullable: true),
                    PaymethodId = table.Column<string>(nullable: true),
                    Qty = table.Column<float>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    WalletId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Wallets",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    DtCreated = table.Column<DateTime>(nullable: false),
                    DtModified = table.Column<DateTime>(nullable: false),
                    LActive = table.Column<int>(nullable: false),
                    PartyId = table.Column<string>(nullable: true),
                    Qty = table.Column<float>(nullable: false),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wallets", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Coins");

            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.DropTable(
                name: "PayMethods");

            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "Wallets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Partys",
                table: "Partys");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Companies",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Partys");

            migrationBuilder.DropColumn(
                name: "CmpId",
                table: "Partys");

            migrationBuilder.DropColumn(
                name: "CoordX",
                table: "Partys");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "CmpId",
                table: "AspNetRoles");

            migrationBuilder.RenameColumn(
                name: "Website",
                table: "Partys",
                newName: "website");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Partys",
                newName: "price");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Partys",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Logo",
                table: "Partys",
                newName: "logo");

            migrationBuilder.RenameColumn(
                name: "Adres",
                table: "Partys",
                newName: "adres");

            migrationBuilder.RenameColumn(
                name: "ZipCode",
                table: "Partys",
                newName: "zip_code");

            migrationBuilder.RenameColumn(
                name: "StatusId",
                table: "Partys",
                newName: "long_desc");

            migrationBuilder.RenameColumn(
                name: "LongDescription",
                table: "Partys",
                newName: "line_up");

            migrationBuilder.RenameColumn(
                name: "LineUp",
                table: "Partys",
                newName: "desc");

            migrationBuilder.RenameColumn(
                name: "LActive",
                table: "Partys",
                newName: "status");

            migrationBuilder.RenameColumn(
                name: "DtParty",
                table: "Partys",
                newName: "dt_party");

            migrationBuilder.RenameColumn(
                name: "DtModified",
                table: "Partys",
                newName: "dt_modified");

            migrationBuilder.RenameColumn(
                name: "DtCreated",
                table: "Partys",
                newName: "dt_created");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Partys",
                newName: "coord_y");

            migrationBuilder.RenameColumn(
                name: "CoordY",
                table: "Partys",
                newName: "coord_x");

            migrationBuilder.RenameColumn(
                name: "AgeRequired",
                table: "Partys",
                newName: "l_active");

            migrationBuilder.RenameColumn(
                name: "Zipcode",
                table: "Companies",
                newName: "zipcode");

            migrationBuilder.RenameColumn(
                name: "Website",
                table: "Companies",
                newName: "website");

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "Companies",
                newName: "phone");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Companies",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Curreny",
                table: "Companies",
                newName: "curreny");

            migrationBuilder.RenameColumn(
                name: "Country",
                table: "Companies",
                newName: "country");

            migrationBuilder.RenameColumn(
                name: "Bank",
                table: "Companies",
                newName: "bank");

            migrationBuilder.RenameColumn(
                name: "Adres",
                table: "Companies",
                newName: "adres");

            migrationBuilder.RenameColumn(
                name: "LActive",
                table: "Companies",
                newName: "l_active");

            migrationBuilder.RenameColumn(
                name: "KvkNum",
                table: "Companies",
                newName: "kvk_num");

            migrationBuilder.RenameColumn(
                name: "DtModified",
                table: "Companies",
                newName: "dt_modified");

            migrationBuilder.RenameColumn(
                name: "DtCreated",
                table: "Companies",
                newName: "dt_created");

            migrationBuilder.AddColumn<Guid>(
                name: "guid",
                table: "Partys",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<int>(
                name: "age_required",
                table: "Partys",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "guid_company",
                table: "Partys",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "guid",
                table: "Companies",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "guid_cmp",
                table: "AspNetRoles",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Partys",
                table: "Partys",
                column: "guid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Companies",
                table: "Companies",
                column: "guid");
        }
    }
}
