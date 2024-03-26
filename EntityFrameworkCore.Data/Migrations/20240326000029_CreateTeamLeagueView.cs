using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameworkCore.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreateTeamLeagueView : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"create view VW_TeamAndLeagues
                                    as
	                                    select l.Name as LeagueName, t.Name as TeamName
	                                        from Leagues l, Teams t
	                                        where l.Id=t.LeagueId");
        }


        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Drop view VW_TeamAndLeagues");
        }
    }
}

