using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace wasteInventoryManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WeightAndPrice",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GlassBottlesWeight = table.Column<double>(type: "float", nullable: false),
                    GlassBottlesPrice = table.Column<double>(type: "float", nullable: false),
                    MetalsWeight = table.Column<double>(type: "float", nullable: false),
                    MetalsPrice = table.Column<double>(type: "float", nullable: false),
                    PlasticWeight = table.Column<double>(type: "float", nullable: false),
                    PlasticPrice = table.Column<double>(type: "float", nullable: false),
                    PaperWeight = table.Column<double>(type: "float", nullable: false),
                    PaperPrice = table.Column<double>(type: "float", nullable: false),
                    CardboardWeight = table.Column<double>(type: "float", nullable: false),
                    CardboardPrice = table.Column<double>(type: "float", nullable: false),
                    AluminumCansWeight = table.Column<double>(type: "float", nullable: false),
                    AluminumCansPrice = table.Column<double>(type: "float", nullable: false),
                    TotalSalePrice = table.Column<double>(type: "float", nullable: false),
                    Totalweight = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeightAndPrice", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "wasteBuyings",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WeightAndPriceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wasteBuyings", x => x.id);
                    table.ForeignKey(
                        name: "FK_wasteBuyings_WeightAndPrice_WeightAndPriceId",
                        column: x => x.WeightAndPriceId,
                        principalTable: "WeightAndPrice",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "wasteDonations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BusinessName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactPerson = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WeightAndPriceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wasteDonations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_wasteDonations_WeightAndPrice_WeightAndPriceId",
                        column: x => x.WeightAndPriceId,
                        principalTable: "WeightAndPrice",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "wasteSellings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WholesaleCompany = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WholesaleContact = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WeightAndPriceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wasteSellings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_wasteSellings_WeightAndPrice_WeightAndPriceId",
                        column: x => x.WeightAndPriceId,
                        principalTable: "WeightAndPrice",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "WeightAndPrice",
                columns: new[] { "Id", "AluminumCansPrice", "AluminumCansWeight", "CardboardPrice", "CardboardWeight", "GlassBottlesPrice", "GlassBottlesWeight", "MetalsPrice", "MetalsWeight", "PaperPrice", "PaperWeight", "PlasticPrice", "PlasticWeight", "TotalSalePrice", "Totalweight" },
                values: new object[,]
                {
                    { 1, 2.0, 1.0, 0.5, 1.0, 5.0, 1.0, 10.0, 1.0, 0.20000000000000001, 1.0, 1.0, 1.0, 50.0, 50.0 },
                    { 2, 4.0, 2.0, 1.0, 2.0, 10.0, 2.0, 20.0, 2.0, 0.40000000000000002, 2.0, 2.0, 2.0, 100.0, 100.0 },
                    { 3, 6.0, 3.0, 1.5, 3.0, 15.0, 3.0, 30.0, 3.0, 0.59999999999999998, 3.0, 3.0, 3.0, 150.0, 150.0 }
                });

            migrationBuilder.InsertData(
                table: "wasteBuyings",
                columns: new[] { "id", "Date", "Name", "Surname", "WeightAndPriceId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 30, 12, 13, 2, 318, DateTimeKind.Local).AddTicks(497), "keke shop", "kk", 1 },
                    { 2, new DateTime(2024, 3, 30, 12, 13, 2, 318, DateTimeKind.Local).AddTicks(500), "L shop", "ks", 2 }
                });

            migrationBuilder.InsertData(
                table: "wasteDonations",
                columns: new[] { "Id", "BusinessName", "ContactNumber", "ContactPerson", "Date", "WeightAndPriceId" },
                values: new object[,]
                {
                    { 1, "keke shop", "0658775412", "kk", new DateTime(2024, 3, 30, 12, 13, 2, 318, DateTimeKind.Local).AddTicks(364), 1 },
                    { 2, "L shop", "0658777862", "ks", new DateTime(2024, 3, 30, 12, 13, 2, 318, DateTimeKind.Local).AddTicks(378), 2 },
                    { 3, "M shop", "0846775412", "kl", new DateTime(2024, 3, 30, 12, 13, 2, 318, DateTimeKind.Local).AddTicks(379), 3 }
                });

            migrationBuilder.InsertData(
                table: "wasteSellings",
                columns: new[] { "Id", "Date", "WeightAndPriceId", "WholesaleCompany", "WholesaleContact" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 30, 12, 13, 2, 318, DateTimeKind.Local).AddTicks(476), 1, "keke shop", "kk" },
                    { 2, new DateTime(2024, 3, 30, 12, 13, 2, 318, DateTimeKind.Local).AddTicks(479), 2, "L shop", "ks" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_wasteBuyings_WeightAndPriceId",
                table: "wasteBuyings",
                column: "WeightAndPriceId");

            migrationBuilder.CreateIndex(
                name: "IX_wasteDonations_WeightAndPriceId",
                table: "wasteDonations",
                column: "WeightAndPriceId");

            migrationBuilder.CreateIndex(
                name: "IX_wasteSellings_WeightAndPriceId",
                table: "wasteSellings",
                column: "WeightAndPriceId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "wasteBuyings");

            migrationBuilder.DropTable(
                name: "wasteDonations");

            migrationBuilder.DropTable(
                name: "wasteSellings");

            migrationBuilder.DropTable(
                name: "WeightAndPrice");
        }
    }
}
