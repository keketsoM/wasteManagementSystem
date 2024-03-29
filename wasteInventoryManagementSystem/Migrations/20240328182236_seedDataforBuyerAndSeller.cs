using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace wasteInventoryManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class seedDataforBuyerAndSeller : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "wasteBuyings",
                columns: new[] { "id", "Date", "Name", "Surname", "WeightAndPriceId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 28, 20, 22, 35, 901, DateTimeKind.Local).AddTicks(3814), "keke shop", "kk", 1 },
                    { 2, new DateTime(2024, 3, 28, 20, 22, 35, 901, DateTimeKind.Local).AddTicks(3820), "L shop", "ks", 2 }
                });

            migrationBuilder.UpdateData(
                table: "wasteDonations",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 3, 28, 20, 22, 35, 901, DateTimeKind.Local).AddTicks(3633));

            migrationBuilder.UpdateData(
                table: "wasteDonations",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 3, 28, 20, 22, 35, 901, DateTimeKind.Local).AddTicks(3654));

            migrationBuilder.UpdateData(
                table: "wasteDonations",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 3, 28, 20, 22, 35, 901, DateTimeKind.Local).AddTicks(3656));

            migrationBuilder.InsertData(
                table: "wasteSellings",
                columns: new[] { "Id", "Date", "WeightAndPriceId", "WholesaleCompany", "WholesaleContact" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 28, 20, 22, 35, 901, DateTimeKind.Local).AddTicks(3786), 1, "keke shop", "kk" },
                    { 2, new DateTime(2024, 3, 28, 20, 22, 35, 901, DateTimeKind.Local).AddTicks(3791), 2, "L shop", "ks" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "wasteBuyings",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "wasteBuyings",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "wasteSellings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "wasteSellings",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "wasteDonations",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 3, 28, 17, 51, 30, 499, DateTimeKind.Local).AddTicks(6907));

            migrationBuilder.UpdateData(
                table: "wasteDonations",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 3, 28, 17, 51, 30, 499, DateTimeKind.Local).AddTicks(6925));

            migrationBuilder.UpdateData(
                table: "wasteDonations",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 3, 28, 17, 51, 30, 499, DateTimeKind.Local).AddTicks(6927));
        }
    }
}
