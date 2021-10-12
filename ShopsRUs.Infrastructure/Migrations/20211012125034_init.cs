using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShopsRUs.Infrastructure.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Discounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Rate = table.Column<decimal>(type: "TEXT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Amount = table.Column<decimal>(type: "TEXT", nullable: false),
                    Category = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    RoleId = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Discounts",
                columns: new[] { "Id", "CreatedAt", "Name", "Rate" },
                values: new object[] { 1, new DateTime(2021, 10, 12, 13, 50, 33, 595, DateTimeKind.Local).AddTicks(9391), "Employee", 0.3m });

            migrationBuilder.InsertData(
                table: "Discounts",
                columns: new[] { "Id", "CreatedAt", "Name", "Rate" },
                values: new object[] { 2, new DateTime(2021, 10, 12, 13, 50, 33, 595, DateTimeKind.Local).AddTicks(9590), "Affiliate", 0.1m });

            migrationBuilder.InsertData(
                table: "Discounts",
                columns: new[] { "Id", "CreatedAt", "Name", "Rate" },
                values: new object[] { 3, new DateTime(2021, 10, 12, 13, 50, 33, 595, DateTimeKind.Local).AddTicks(9592), "Customer", 0.05m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Amount", "Category", "Name" },
                values: new object[] { 1, 300.0m, "Groceries", "Rice" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Amount", "Category", "Name" },
                values: new object[] { 2, 550.0m, "Stationaries", "Book" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Amount", "Category", "Name" },
                values: new object[] { 3, 175450.0m, "Electronics", "Plasma Televison" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Amount", "Category", "Name" },
                values: new object[] { 4, 500000.0m, "Hp Pavillion", "Hp Pavillion" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Amount", "Category", "Name" },
                values: new object[] { 5, 200000.0m, "Gaming", "PS 4" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Amount", "Category", "Name" },
                values: new object[] { 6, 550.0m, "Baby Product", "Diaper bag" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Amount", "Category", "Name" },
                values: new object[] { 7, 100000.0m, "Smart Phones", "Redmi Note 9" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Amount", "Category", "Name" },
                values: new object[] { 8, 150000.0m, "Building", "Rods" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Amount", "Category", "Name" },
                values: new object[] { 9, 80.0m, "Groceries", "Beans" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Employee" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Affiliate" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Customer" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CreatedAt", "Email", "FirstName", "LastName", "PhoneNumber", "RoleId" },
                values: new object[] { 1, new DateTime(2021, 10, 12, 13, 50, 33, 597, DateTimeKind.Local).AddTicks(6036), "johndoe@gmail.com", "John", "Doe", "09045735473", 1 });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CreatedAt", "Email", "FirstName", "LastName", "PhoneNumber", "RoleId" },
                values: new object[] { 3, new DateTime(2021, 10, 12, 13, 50, 33, 609, DateTimeKind.Local).AddTicks(8796), "chuka@moses.com", "Chuka", "Moses", "07046537833", 3 });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CreatedAt", "Email", "FirstName", "LastName", "PhoneNumber", "RoleId" },
                values: new object[] { 20, new DateTime(2021, 10, 12, 13, 50, 33, 609, DateTimeKind.Local).AddTicks(9033), "obinnachibueze@gmail.com", "Obinna", "Chibueze", "09037473833", 2 });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CreatedAt", "Email", "FirstName", "LastName", "PhoneNumber", "RoleId" },
                values: new object[] { 19, new DateTime(2021, 10, 12, 13, 50, 33, 609, DateTimeKind.Local).AddTicks(9032), "joshclem@gmail.com", "Joshua", "Clement", "090474838393", 2 });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CreatedAt", "Email", "FirstName", "LastName", "PhoneNumber", "RoleId" },
                values: new object[] { 18, new DateTime(2021, 10, 12, 13, 50, 33, 609, DateTimeKind.Local).AddTicks(9030), "kingsleyemenike@gmail.com", "Kingsley", "Emenike", "0813838383", 2 });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CreatedAt", "Email", "FirstName", "LastName", "PhoneNumber", "RoleId" },
                values: new object[] { 17, new DateTime(2021, 10, 12, 13, 50, 33, 609, DateTimeKind.Local).AddTicks(9028), "obygrace@gmail.com", "Grace", "Oby", "07036737373", 2 });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CreatedAt", "Email", "FirstName", "LastName", "PhoneNumber", "RoleId" },
                values: new object[] { 16, new DateTime(2021, 10, 12, 13, 50, 33, 609, DateTimeKind.Local).AddTicks(9027), "queen@gmail.com", "Queen", "Moses", "09063637373", 2 });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CreatedAt", "Email", "FirstName", "LastName", "PhoneNumber", "RoleId" },
                values: new object[] { 15, new DateTime(2021, 10, 12, 13, 50, 33, 609, DateTimeKind.Local).AddTicks(9025), "godsonemeka@gmail.com", "Godson", "Emeka", "0703748483", 2 });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CreatedAt", "Email", "FirstName", "LastName", "PhoneNumber", "RoleId" },
                values: new object[] { 14, new DateTime(2021, 10, 12, 13, 50, 33, 609, DateTimeKind.Local).AddTicks(9024), "okaforfaith@gmail.com", "Faith", "Okafor", "09037473736", 2 });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CreatedAt", "Email", "FirstName", "LastName", "PhoneNumber", "RoleId" },
                values: new object[] { 13, new DateTime(2021, 10, 12, 13, 50, 33, 609, DateTimeKind.Local).AddTicks(9023), "francisjoshua@gmail.com", "Francis", "Joshua", "0813473747374", 2 });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CreatedAt", "Email", "FirstName", "LastName", "PhoneNumber", "RoleId" },
                values: new object[] { 12, new DateTime(2021, 10, 12, 13, 50, 33, 609, DateTimeKind.Local).AddTicks(9021), "theresa@gmail.com", "Theresa", "Samson", "07074838833", 2 });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CreatedAt", "Email", "FirstName", "LastName", "PhoneNumber", "RoleId" },
                values: new object[] { 11, new DateTime(2021, 10, 12, 13, 50, 33, 609, DateTimeKind.Local).AddTicks(9019), "somtoochukwuonuh@gmail.com", "Somtoochukwu", "Onuh", "08063737373", 2 });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CreatedAt", "Email", "FirstName", "LastName", "PhoneNumber", "RoleId" },
                values: new object[] { 10, new DateTime(2021, 10, 12, 13, 50, 33, 609, DateTimeKind.Local).AddTicks(9018), "emmanuelpeter@gmail.com", "Emmanuel", "Peter", "09067374367", 2 });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CreatedAt", "Email", "FirstName", "LastName", "PhoneNumber", "RoleId" },
                values: new object[] { 8, new DateTime(2021, 10, 12, 13, 50, 33, 609, DateTimeKind.Local).AddTicks(9015), "godson@frank.com", "Frank", "Godson", "07035374833", 2 });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CreatedAt", "Email", "FirstName", "LastName", "PhoneNumber", "RoleId" },
                values: new object[] { 7, new DateTime(2021, 10, 12, 13, 50, 33, 609, DateTimeKind.Local).AddTicks(9013), "gabriel@benard.com", "Bernard", "Gabriel", "080465374833", 2 });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CreatedAt", "Email", "FirstName", "LastName", "PhoneNumber", "RoleId" },
                values: new object[] { 6, new DateTime(2021, 10, 12, 13, 50, 33, 609, DateTimeKind.Local).AddTicks(9011), "godwinjulieth@gmail.com", "Julieth", "Godwin", "0704674833", 2 });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CreatedAt", "Email", "FirstName", "LastName", "PhoneNumber", "RoleId" },
                values: new object[] { 5, new DateTime(2019, 10, 2, 14, 24, 59, 0, DateTimeKind.Local), "olatobi@gmail.com", "Tobi", "Ola", "09086574839", 2 });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CreatedAt", "Email", "FirstName", "LastName", "PhoneNumber", "RoleId" },
                values: new object[] { 2, new DateTime(2020, 2, 4, 14, 24, 59, 0, DateTimeKind.Local), "barnesolson@ronbert.com", "Barnes", "Olson", "080465374833", 2 });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CreatedAt", "Email", "FirstName", "LastName", "PhoneNumber", "RoleId" },
                values: new object[] { 4, new DateTime(2018, 7, 4, 14, 24, 59, 0, DateTimeKind.Local), "clement@gmail.com", "Clement", "Azabataram", "08136374833", 3 });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CreatedAt", "Email", "FirstName", "LastName", "PhoneNumber", "RoleId" },
                values: new object[] { 9, new DateTime(2021, 10, 12, 13, 50, 33, 609, DateTimeKind.Local).AddTicks(9016), "eunice@beauty.com", "Eunice", "Beauty", "09054836483", 3 });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_RoleId",
                table: "Customers",
                column: "RoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Discounts");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
