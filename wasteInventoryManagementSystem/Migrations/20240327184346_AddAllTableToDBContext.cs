using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace wasteInventoryManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class AddAllTableToDBContext : Migration
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
