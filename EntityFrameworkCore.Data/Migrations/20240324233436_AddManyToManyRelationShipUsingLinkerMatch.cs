using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameworkCore.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddManyToManyRelationShipUsingLinkerMatch : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Teams",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_Name",
                table: "Teams",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Matchs_AwayTeamId",
                table: "Matchs",
                column: "AwayTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Matchs_HomeTeamId",
                table: "Matchs",
                column: "HomeTeamId");

            migrationBuilder.AddForeignKey(
                name: "FK_Matchs_Teams_AwayTeamId",
                table: "Matchs",
                column: "AwayTeamId",
                principalTable: "Teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Matchs_Teams_HomeTeamId",
                table: "Matchs",
                column: "HomeTeamId",
                principalTable: "Teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Matchs_Teams_AwayTeamId",
                table: "Matchs");

            migrationBuilder.DropForeignKey(
                name: "FK_Matchs_Teams_HomeTeamId",
                table: "Matchs");

            migrationBuilder.DropIndex(
                name: "IX_Teams_Name",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Matchs_AwayTeamId",
                table: "Matchs");

            migrationBuilder.DropIndex(
                name: "IX_Matchs_HomeTeamId",
                table: "Matchs");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Teams",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }
    }
}
