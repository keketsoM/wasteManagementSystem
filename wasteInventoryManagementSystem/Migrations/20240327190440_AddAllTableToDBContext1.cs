using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace wasteInventoryManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class AddAllTableToDBContext1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_wasteBuyings_WeightAndPrice_WeightAndPriceId",
                table: "wasteBuyings");

            migrationBuilder.DropForeignKey(
                name: "FK_wasteDonations_WeightAndPrice_WeightAndPriceId",
                table: "wasteDonations");

            migrationBuilder.DropForeignKey(
                name: "FK_wasteSellings_WeightAndPrice_WeightAndPriceId",
                table: "wasteSellings");

            migrationBuilder.DropTable(
                name: "WeightAndPrice");

            migrationBuilder.DropIndex(
                name: "IX_wasteSellings_WeightAndPriceId",
                table: "wasteSellings");

            migrationBuilder.DropIndex(
                name: "IX_wasteDonations_WeightAndPriceId",
                table: "wasteDonations");

            migrationBuilder.DropIndex(
                name: "IX_wasteBuyings_WeightAndPriceId",
                table: "wasteBuyings");

            migrationBuilder.DropColumn(
                name: "WeightAndPriceId",
                table: "wasteSellings");

            migrationBuilder.DropColumn(
                name: "WeightAndPriceId",
                table: "wasteDonations");

            migrationBuilder.DropColumn(
                name: "WeightAndPriceId",
                table: "wasteBuyings");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "WeightAndPriceId",
                table: "wasteSellings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WeightAndPriceId",
                table: "wasteDonations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WeightAndPriceId",
                table: "wasteBuyings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "WeightAndPrice",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AluminumCansPrice = table.Column<double>(type: "float", nullable: false),
                    AluminumCansWeight = table.Column<double>(type: "float", nullable: false),
                    CardboardPrice = table.Column<double>(type: "float", nullable: false),
                    CardboardWeight = table.Column<double>(type: "float", nullable: false),
                    GlassBottlesPrice = table.Column<double>(type: "float", nullable: false),
                    GlassBottlesWeight = table.Column<double>(type: "float", nullable: false),
                    MetalsPrice = table.Column<double>(type: "float", nullable: false),
                    MetalsWeight = table.Column<double>(type: "float", nullable: false),
                    PlasticPrice = table.Column<double>(type: "float", nullable: false),
                    PlasticWeight = table.Column<double>(type: "float", nullable: false),
                    TotalSalePrice = table.Column<double>(type: "float", nullable: false),
                    Totalweight = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeightAndPrice", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_wasteSellings_WeightAndPriceId",
                table: "wasteSellings",
                column: "WeightAndPriceId");

            migrationBuilder.CreateIndex(
                name: "IX_wasteDonations_WeightAndPriceId",
                table: "wasteDonations",
                column: "WeightAndPriceId");

            migrationBuilder.CreateIndex(
                name: "IX_wasteBuyings_WeightAndPriceId",
                table: "wasteBuyings",
                column: "WeightAndPriceId");

            migrationBuilder.AddForeignKey(
                name: "FK_wasteBuyings_WeightAndPrice_WeightAndPriceId",
                table: "wasteBuyings",
                column: "WeightAndPriceId",
                principalTable: "WeightAndPrice",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_wasteDonations_WeightAndPrice_WeightAndPriceId",
                table: "wasteDonations",
                column: "WeightAndPriceId",
                principalTable: "WeightAndPrice",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_wasteSellings_WeightAndPrice_WeightAndPriceId",
                table: "wasteSellings",
                column: "WeightAndPriceId",
                principalTable: "WeightAndPrice",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
