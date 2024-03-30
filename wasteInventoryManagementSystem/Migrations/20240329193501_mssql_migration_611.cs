using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace wasteInventoryManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class mssql_migration_611 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_wasteDonations_WeightAndPrice_WeightAndPriceId",
                table: "wasteDonations");

            migrationBuilder.AlterColumn<int>(
                name: "WeightAndPriceId",
                table: "wasteDonations",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "wasteBuyings",
                keyColumn: "id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 3, 29, 21, 35, 0, 689, DateTimeKind.Local).AddTicks(6028));

            migrationBuilder.UpdateData(
                table: "wasteBuyings",
                keyColumn: "id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 3, 29, 21, 35, 0, 689, DateTimeKind.Local).AddTicks(6031));

            migrationBuilder.UpdateData(
                table: "wasteDonations",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 3, 29, 21, 35, 0, 689, DateTimeKind.Local).AddTicks(5884));

            migrationBuilder.UpdateData(
                table: "wasteDonations",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 3, 29, 21, 35, 0, 689, DateTimeKind.Local).AddTicks(5902));

            migrationBuilder.UpdateData(
                table: "wasteDonations",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 3, 29, 21, 35, 0, 689, DateTimeKind.Local).AddTicks(5904));

            migrationBuilder.UpdateData(
                table: "wasteSellings",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 3, 29, 21, 35, 0, 689, DateTimeKind.Local).AddTicks(6007));

            migrationBuilder.UpdateData(
                table: "wasteSellings",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 3, 29, 21, 35, 0, 689, DateTimeKind.Local).AddTicks(6011));

            migrationBuilder.AddForeignKey(
                name: "FK_wasteDonations_WeightAndPrice_WeightAndPriceId",
                table: "wasteDonations",
                column: "WeightAndPriceId",
                principalTable: "WeightAndPrice",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_wasteDonations_WeightAndPrice_WeightAndPriceId",
                table: "wasteDonations");

            migrationBuilder.AlterColumn<int>(
                name: "WeightAndPriceId",
                table: "wasteDonations",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_wasteDonations_WeightAndPrice_WeightAndPriceId",
                table: "wasteDonations",
                column: "WeightAndPriceId",
                principalTable: "WeightAndPrice",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
