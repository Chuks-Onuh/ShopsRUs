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

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false),
                    ProductAmount = table.Column<decimal>(type: "TEXT", nullable: false),
                    DiscountRate = table.Column<float>(type: "REAL", nullable: false),
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    AppUserId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Discounts",
                columns: new[] { "Id", "CreatedAt", "Name", "Rate" },
                values: new object[] { 1, new DateTime(2021, 10, 10, 22, 35, 14, 28, DateTimeKind.Local).AddTicks(662), "Employee", 0.3m });

            migrationBuilder.InsertData(
                table: "Discounts",
                columns: new[] { "Id", "CreatedAt", "Name", "Rate" },
                values: new object[] { 2, new DateTime(2021, 10, 10, 22, 35, 14, 28, DateTimeKind.Local).AddTicks(868), "Affiliate", 0.1m });

            migrationBuilder.InsertData(
                table: "Discounts",
                columns: new[] { "Id", "CreatedAt", "Name", "Rate" },
                values: new object[] { 3, new DateTime(2021, 10, 10, 22, 35, 14, 28, DateTimeKind.Local).AddTicks(871), "Customer", 0.05m });

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
                values: new object[] { 1, new DateTime(2021, 10, 10, 22, 35, 14, 29, DateTimeKind.Local).AddTicks(5826), "johndoe@gmail.com", "John", "Doe", "09045735473", 1 });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CreatedAt", "Email", "FirstName", "LastName", "PhoneNumber", "RoleId" },
                values: new object[] { 19, new DateTime(2021, 10, 10, 22, 35, 14, 29, DateTimeKind.Local).AddTicks(6998), "joshclem@gmail.com", "Joshua", "Clement", "090474838393", 2 });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CreatedAt", "Email", "FirstName", "LastName", "PhoneNumber", "RoleId" },
                values: new object[] { 18, new DateTime(2021, 10, 10, 22, 35, 14, 29, DateTimeKind.Local).AddTicks(6996), "kingsleyemenike@gmail.com", "Kingsley", "Emenike", "0813838383", 2 });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CreatedAt", "Email", "FirstName", "LastName", "PhoneNumber", "RoleId" },
                values: new object[] { 17, new DateTime(2021, 10, 10, 22, 35, 14, 29, DateTimeKind.Local).AddTicks(6994), "obygrace@gmail.com", "Grace", "Oby", "07036737373", 2 });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CreatedAt", "Email", "FirstName", "LastName", "PhoneNumber", "RoleId" },
                values: new object[] { 16, new DateTime(2021, 10, 10, 22, 35, 14, 29, DateTimeKind.Local).AddTicks(6992), "queen@gmail.com", "Queen", "Moses", "09063637373", 2 });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CreatedAt", "Email", "FirstName", "LastName", "PhoneNumber", "RoleId" },
                values: new object[] { 15, new DateTime(2021, 10, 10, 22, 35, 14, 29, DateTimeKind.Local).AddTicks(6991), "godsonemeka@gmail.com", "Godson", "Emeka", "0703748483", 2 });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CreatedAt", "Email", "FirstName", "LastName", "PhoneNumber", "RoleId" },
                values: new object[] { 14, new DateTime(2021, 10, 10, 22, 35, 14, 29, DateTimeKind.Local).AddTicks(6989), "okaforfaith@gmail.com", "Faith", "Okafor", "09037473736", 2 });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CreatedAt", "Email", "FirstName", "LastName", "PhoneNumber", "RoleId" },
                values: new object[] { 13, new DateTime(2021, 10, 10, 22, 35, 14, 29, DateTimeKind.Local).AddTicks(6988), "francisjoshua@gmail.com", "Francis", "Joshua", "0813473747374", 2 });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CreatedAt", "Email", "FirstName", "LastName", "PhoneNumber", "RoleId" },
                values: new object[] { 12, new DateTime(2021, 10, 10, 22, 35, 14, 29, DateTimeKind.Local).AddTicks(6986), "theresa@gmail.com", "Theresa", "Samson", "07074838833", 2 });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CreatedAt", "Email", "FirstName", "LastName", "PhoneNumber", "RoleId" },
                values: new object[] { 11, new DateTime(2021, 10, 10, 22, 35, 14, 29, DateTimeKind.Local).AddTicks(6984), "somtoochukwuonuh@gmail.com", "Somtoochukwu", "Onuh", "08063737373", 2 });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CreatedAt", "Email", "FirstName", "LastName", "PhoneNumber", "RoleId" },
                values: new object[] { 10, new DateTime(2021, 10, 10, 22, 35, 14, 29, DateTimeKind.Local).AddTicks(6945), "emmanuelpeter@gmail.com", "Emmanuel", "Peter", "09067374367", 2 });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CreatedAt", "Email", "FirstName", "LastName", "PhoneNumber", "RoleId" },
                values: new object[] { 8, new DateTime(2021, 10, 10, 22, 35, 14, 29, DateTimeKind.Local).AddTicks(6942), "godson@frank.com", "Frank", "Godson", "07035374833", 2 });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CreatedAt", "Email", "FirstName", "LastName", "PhoneNumber", "RoleId" },
                values: new object[] { 7, new DateTime(2021, 10, 10, 22, 35, 14, 29, DateTimeKind.Local).AddTicks(6940), "gabriel@benard.com", "Bernard", "Gabriel", "080465374833", 2 });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CreatedAt", "Email", "FirstName", "LastName", "PhoneNumber", "RoleId" },
                values: new object[] { 6, new DateTime(2021, 10, 10, 22, 35, 14, 29, DateTimeKind.Local).AddTicks(6938), "godwinjulieth@gmail.com", "Julieth", "Godwin", "0704674833", 2 });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CreatedAt", "Email", "FirstName", "LastName", "PhoneNumber", "RoleId" },
                values: new object[] { 5, new DateTime(2021, 10, 10, 22, 35, 14, 29, DateTimeKind.Local).AddTicks(6936), "olatobi@gmail.com", "Tobi", "Ola", "09086574839", 2 });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CreatedAt", "Email", "FirstName", "LastName", "PhoneNumber", "RoleId" },
                values: new object[] { 4, new DateTime(2021, 10, 10, 22, 35, 14, 29, DateTimeKind.Local).AddTicks(6935), "clement@gmail.com", "Clement", "Azabataram", "08136374833", 2 });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CreatedAt", "Email", "FirstName", "LastName", "PhoneNumber", "RoleId" },
                values: new object[] { 3, new DateTime(2021, 10, 10, 22, 35, 14, 29, DateTimeKind.Local).AddTicks(6933), "chuks@moses.com", "Chuks", "Moses", "07046537833", 2 });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CreatedAt", "Email", "FirstName", "LastName", "PhoneNumber", "RoleId" },
                values: new object[] { 2, new DateTime(2021, 10, 10, 22, 35, 14, 29, DateTimeKind.Local).AddTicks(6929), "barnesolson@ronbert.com", "Barnes", "Olson", "080465374833", 2 });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CreatedAt", "Email", "FirstName", "LastName", "PhoneNumber", "RoleId" },
                values: new object[] { 20, new DateTime(2021, 10, 10, 22, 35, 14, 29, DateTimeKind.Local).AddTicks(6999), "obinnachibueze@gmail.com", "Obinna", "Chibueze", "09037473833", 2 });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CreatedAt", "Email", "FirstName", "LastName", "PhoneNumber", "RoleId" },
                values: new object[] { 9, new DateTime(2021, 10, 10, 22, 35, 14, 29, DateTimeKind.Local).AddTicks(6943), "eunice@beauty.com", "Eunice", "Beauty", "09054836483", 3 });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_RoleId",
                table: "Customers",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_AppUserId",
                table: "Orders",
                column: "AppUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Discounts");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
