using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace wasteInventoryManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class seedDataForDonation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "wasteDonations",
                columns: new[] { "Id", "BusinessName", "ContactNumber", "ContactPerson", "Date" },
                values: new object[,]
                {
                    { 1, "keke shop", "0658775412", "kk", new DateTime(2024, 3, 28, 12, 14, 39, 878, DateTimeKind.Local).AddTicks(2143) },
                    { 2, "L shop", "0658777862", "ks", new DateTime(2024, 3, 28, 12, 14, 39, 878, DateTimeKind.Local).AddTicks(2158) },
                    { 3, "M shop", "0846775412", "kl", new DateTime(2024, 3, 28, 12, 14, 39, 878, DateTimeKind.Local).AddTicks(2159) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "wasteDonations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "wasteDonations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "wasteDonations",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
