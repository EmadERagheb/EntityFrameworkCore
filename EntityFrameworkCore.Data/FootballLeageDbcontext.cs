using EntityFrameworkCore.Domain;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace EntityFrameworkCore.Data
{
    public class FootballLeageDbcontext : DbContext
    {
        public FootballLeageDbcontext(DbContextOptions<FootballLeageDbcontext> options) : base(options)
        {

        }
        #region ConsoleApplication Configurations
        //public FootballLeageDbcontext()
        //{
        //}
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Data Source=Emad;Initial Catalog=FootballLeague;Integrated Security=True;Encrypt=True;Trust Server Certificate=True")
        //       //.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking)
        //       .UseLazyLoadingProxies()
        //        .LogTo(Console.WriteLine, LogLevel.Information)
        //        .EnableDetailedErrors()
        //        .EnableSensitiveDataLogging();
        //}
        #endregion
        public DbSet<Team> Teams { get; set; }

        public DbSet<Coach> Coachs { get; set; }
        public DbSet<Match> Matchs { get; set; }
        public DbSet<League> Leagues { get; set; }

        public DbSet<TeamLeagueView> TeamLeagueView { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var entries = ChangeTracker.Entries<BaseDomainModel>().Where(q => q.State == EntityState.Added || q.State == EntityState.Modified);
            foreach (var entry in entries)
            {
                entry.Entity.Version = Guid.NewGuid();
                entry.Entity.UpdatedDate = DateTime.UtcNow;
                entry.Entity.UpdatedBy = "Emad Eid Ragheb";
                if (entry.State == EntityState.Added)
                {
                    entry.Entity.CreatedDate = DateTime.UtcNow;
                    entry.Entity.CreatedBy = "Ereen";

                }


            }
            return base.SaveChangesAsync(cancellationToken);
        }
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<string>().HaveMaxLength(200);
            configurationBuilder.Properties<decimal>().HavePrecision(16, 5);
        }
    }
}
