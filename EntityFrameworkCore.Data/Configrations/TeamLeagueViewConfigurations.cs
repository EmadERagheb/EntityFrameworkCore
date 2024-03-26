using EntityFrameworkCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntityFrameworkCore.Data.Configrations
{
    public class TeamLeagueViewConfigurations : IEntityTypeConfiguration<TeamLeagueView>
    {
        public void Configure(EntityTypeBuilder<TeamLeagueView> builder)
        {
            builder.HasNoKey().ToView("VW_TeamAndLeagues");
        }
    }
}
