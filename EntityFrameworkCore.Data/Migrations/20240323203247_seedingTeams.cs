using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EntityFrameworkCore.Data.Migrations
{
    /// <inheritdoc />
    public partial class seedingTeams : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Teams",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Coachs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "CreatedDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 23, 20, 32, 47, 199, DateTimeKind.Unspecified).AddTicks(7002), "Tivoli Garden F.C." },
                    { 2, new DateTime(2024, 3, 23, 20, 32, 47, 199, DateTimeKind.Unspecified).AddTicks(7023), "Waterhourse  F.C." },
                    { 3, new DateTime(2024, 3, 23, 20, 32, 47, 199, DateTimeKind.Unspecified).AddTicks(7024), "Humble Lions F.C." }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Coachs");
        }
    }
}
