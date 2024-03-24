using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameworkCore.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddTeamLeagueManyToOneOptionalRelationShip : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "LeagueId",
                table: "Teams",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LeagueId" },
                values: new object[] { new DateTime(2023, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LeagueId" },
                values: new object[] { new DateTime(2023, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LeagueId" },
                values: new object[] { new DateTime(2023, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LeagueId" },
                values: new object[] { new DateTime(2023, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LeagueId" },
                values: new object[] { new DateTime(2023, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "LeagueId" },
                values: new object[] { new DateTime(2023, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "LeagueId" },
                values: new object[] { new DateTime(2023, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "LeagueId" },
                values: new object[] { new DateTime(2023, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.CreateIndex(
                name: "IX_Teams_LeagueId",
                table: "Teams",
                column: "LeagueId");

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Leagues_LeagueId",
                table: "Teams",
                column: "LeagueId",
                principalTable: "Leagues",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Leagues_LeagueId",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Teams_LeagueId",
                table: "Teams");

            migrationBuilder.AlterColumn<int>(
                name: "LeagueId",
                table: "Teams",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LeagueId" },
                values: new object[] { new DateTime(2024, 3, 24, 20, 58, 25, 484, DateTimeKind.Unspecified).AddTicks(4482), 0 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LeagueId" },
                values: new object[] { new DateTime(2024, 3, 24, 20, 58, 25, 484, DateTimeKind.Unspecified).AddTicks(4498), 0 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LeagueId" },
                values: new object[] { new DateTime(2024, 3, 24, 20, 58, 25, 484, DateTimeKind.Unspecified).AddTicks(4500), 0 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LeagueId" },
                values: new object[] { new DateTime(2024, 3, 24, 20, 58, 25, 484, DateTimeKind.Unspecified).AddTicks(4501), 0 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LeagueId" },
                values: new object[] { new DateTime(2024, 3, 24, 20, 58, 25, 484, DateTimeKind.Unspecified).AddTicks(4502), 0 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "LeagueId" },
                values: new object[] { new DateTime(2024, 3, 24, 20, 58, 25, 484, DateTimeKind.Unspecified).AddTicks(4506), 0 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "LeagueId" },
                values: new object[] { new DateTime(2024, 3, 24, 20, 58, 25, 484, DateTimeKind.Unspecified).AddTicks(4508), 0 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "LeagueId" },
                values: new object[] { new DateTime(2024, 3, 24, 20, 58, 25, 484, DateTimeKind.Unspecified).AddTicks(4509), 0 });
        }
    }
}
