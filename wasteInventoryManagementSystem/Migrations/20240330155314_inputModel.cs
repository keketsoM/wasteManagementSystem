using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace wasteInventoryManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class inputModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "wasteBuyings",
                keyColumn: "id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 3, 30, 17, 53, 13, 521, DateTimeKind.Local).AddTicks(9613));

            migrationBuilder.UpdateData(
                table: "wasteBuyings",
                keyColumn: "id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 3, 30, 17, 53, 13, 521, DateTimeKind.Local).AddTicks(9617));

            migrationBuilder.UpdateData(
                table: "wasteDonations",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 3, 30, 17, 53, 13, 521, DateTimeKind.Local).AddTicks(9475));

            migrationBuilder.UpdateData(
                table: "wasteDonations",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 3, 30, 17, 53, 13, 521, DateTimeKind.Local).AddTicks(9492));

            migrationBuilder.UpdateData(
                table: "wasteDonations",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 3, 30, 17, 53, 13, 521, DateTimeKind.Local).AddTicks(9493));

            migrationBuilder.UpdateData(
                table: "wasteSellings",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 3, 30, 17, 53, 13, 521, DateTimeKind.Local).AddTicks(9590));

            migrationBuilder.UpdateData(
                table: "wasteSellings",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 3, 30, 17, 53, 13, 521, DateTimeKind.Local).AddTicks(9593));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "wasteBuyings",
                keyColumn: "id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 3, 30, 12, 13, 2, 318, DateTimeKind.Local).AddTicks(497));

            migrationBuilder.UpdateData(
                table: "wasteBuyings",
                keyColumn: "id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 3, 30, 12, 13, 2, 318, DateTimeKind.Local).AddTicks(500));

            migrationBuilder.UpdateData(
                table: "wasteDonations",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 3, 30, 12, 13, 2, 318, DateTimeKind.Local).AddTicks(364));

            migrationBuilder.UpdateData(
                table: "wasteDonations",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 3, 30, 12, 13, 2, 318, DateTimeKind.Local).AddTicks(378));

            migrationBuilder.UpdateData(
                table: "wasteDonations",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 3, 30, 12, 13, 2, 318, DateTimeKind.Local).AddTicks(379));

            migrationBuilder.UpdateData(
                table: "wasteSellings",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 3, 30, 12, 13, 2, 318, DateTimeKind.Local).AddTicks(476));

            migrationBuilder.UpdateData(
                table: "wasteSellings",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 3, 30, 12, 13, 2, 318, DateTimeKind.Local).AddTicks(479));
        }
    }
}
