using EntityFrameworkCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace EntityFrameworkCore.Data.Configrations
{
    internal class TeamConfigurations : IEntityTypeConfiguration<Team>
    {

        public void Configure(EntityTypeBuilder<Team> builder)
        {
            builder.HasIndex(x => x.Name).IsUnique();
            builder.HasMany(t=>t.HomeTeamMatches)
                .WithOne(m=>m.HomeTeam).HasForeignKey(m=>m.HomeTeamId)
                .IsRequired().OnDelete(DeleteBehavior.Restrict);
            builder.HasMany(t=>t.AwayTeamMatches)
                .WithOne(m=>m.AwayTeam).HasForeignKey(m=>m.AwayTeamId)
                .IsRequired().OnDelete(DeleteBehavior.Restrict);
            builder.ToTable("Teams", q => q.IsTemporal());
            builder.HasData(new TeamList().Teams);
        }
    }
}
