using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace wasteInventoryManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class AddProperties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "PaperPrice",
                table: "WeightAndPrice",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "PaperWeight",
                table: "WeightAndPrice",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "WeightAndPrice",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PaperPrice", "PaperWeight" },
                values: new object[] { 0.20000000000000001, 1.0 });

            migrationBuilder.UpdateData(
                table: "WeightAndPrice",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PaperPrice", "PaperWeight" },
                values: new object[] { 0.40000000000000002, 2.0 });

            migrationBuilder.UpdateData(
                table: "WeightAndPrice",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PaperPrice", "PaperWeight" },
                values: new object[] { 0.59999999999999998, 3.0 });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PaperPrice",
                table: "WeightAndPrice");

            migrationBuilder.DropColumn(
                name: "PaperWeight",
                table: "WeightAndPrice");

            migrationBuilder.UpdateData(
                table: "wasteBuyings",
                keyColumn: "id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 3, 28, 20, 22, 35, 901, DateTimeKind.Local).AddTicks(3814));

            migrationBuilder.UpdateData(
                table: "wasteBuyings",
                keyColumn: "id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 3, 28, 20, 22, 35, 901, DateTimeKind.Local).AddTicks(3820));

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

            migrationBuilder.UpdateData(
                table: "wasteSellings",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 3, 28, 20, 22, 35, 901, DateTimeKind.Local).AddTicks(3786));

            migrationBuilder.UpdateData(
                table: "wasteSellings",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 3, 28, 20, 22, 35, 901, DateTimeKind.Local).AddTicks(3791));
        }
    }
}
