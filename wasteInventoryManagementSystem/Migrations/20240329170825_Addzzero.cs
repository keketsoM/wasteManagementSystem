using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace wasteInventoryManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class Addzzero : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "wasteBuyings",
                keyColumn: "id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 3, 29, 19, 8, 25, 372, DateTimeKind.Local).AddTicks(2949));

            migrationBuilder.UpdateData(
                table: "wasteBuyings",
                keyColumn: "id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 3, 29, 19, 8, 25, 372, DateTimeKind.Local).AddTicks(2954));

            migrationBuilder.UpdateData(
                table: "wasteDonations",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 3, 29, 19, 8, 25, 372, DateTimeKind.Local).AddTicks(2803));

            migrationBuilder.UpdateData(
                table: "wasteDonations",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 3, 29, 19, 8, 25, 372, DateTimeKind.Local).AddTicks(2817));

            migrationBuilder.UpdateData(
                table: "wasteDonations",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 3, 29, 19, 8, 25, 372, DateTimeKind.Local).AddTicks(2819));

            migrationBuilder.UpdateData(
                table: "wasteSellings",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 3, 29, 19, 8, 25, 372, DateTimeKind.Local).AddTicks(2926));

            migrationBuilder.UpdateData(
                table: "wasteSellings",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 3, 29, 19, 8, 25, 372, DateTimeKind.Local).AddTicks(2930));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "wasteBuyings",
                keyColumn: "id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 3, 29, 0, 6, 13, 703, DateTimeKind.Local).AddTicks(4543));

            migrationBuilder.UpdateData(
                table: "wasteBuyings",
                keyColumn: "id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 3, 29, 0, 6, 13, 703, DateTimeKind.Local).AddTicks(4547));

            migrationBuilder.UpdateData(
                table: "wasteDonations",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 3, 29, 0, 6, 13, 703, DateTimeKind.Local).AddTicks(4402));

            migrationBuilder.UpdateData(
                table: "wasteDonations",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 3, 29, 0, 6, 13, 703, DateTimeKind.Local).AddTicks(4423));

            migrationBuilder.UpdateData(
                table: "wasteDonations",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 3, 29, 0, 6, 13, 703, DateTimeKind.Local).AddTicks(4424));

            migrationBuilder.UpdateData(
                table: "wasteSellings",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 3, 29, 0, 6, 13, 703, DateTimeKind.Local).AddTicks(4522));

            migrationBuilder.UpdateData(
                table: "wasteSellings",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 3, 29, 0, 6, 13, 703, DateTimeKind.Local).AddTicks(4526));
        }
    }
}
