using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EntityFrameworkCore.Data.Migrations
{
    /// <inheritdoc />
    public partial class addingMoreTeams : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 24, 14, 37, 16, 937, DateTimeKind.Unspecified).AddTicks(8910));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 24, 14, 37, 16, 937, DateTimeKind.Unspecified).AddTicks(8925));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 24, 14, 37, 16, 937, DateTimeKind.Unspecified).AddTicks(8926));

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "CreatedDate", "Name" },
                values: new object[,]
                {
                    { 4, new DateTime(2024, 3, 24, 14, 37, 16, 937, DateTimeKind.Unspecified).AddTicks(8927), "Chelsea F.C." },
                    { 5, new DateTime(2024, 3, 24, 14, 37, 16, 937, DateTimeKind.Unspecified).AddTicks(8929), "Real Madrid " },
                    { 6, new DateTime(2024, 3, 24, 14, 37, 16, 937, DateTimeKind.Unspecified).AddTicks(8933), "Inter Milan" },
                    { 7, new DateTime(2024, 3, 24, 14, 37, 16, 937, DateTimeKind.Unspecified).AddTicks(8934), "Inter Miami" },
                    { 8, new DateTime(2024, 3, 24, 14, 37, 16, 937, DateTimeKind.Unspecified).AddTicks(8936), "Seba United" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 23, 20, 32, 47, 199, DateTimeKind.Unspecified).AddTicks(7002));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 23, 20, 32, 47, 199, DateTimeKind.Unspecified).AddTicks(7023));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 23, 20, 32, 47, 199, DateTimeKind.Unspecified).AddTicks(7024));
        }
    }
}
