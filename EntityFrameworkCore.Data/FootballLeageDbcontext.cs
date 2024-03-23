﻿using EntityFrameworkCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EntityFrameworkCore.Data
{
    public class FootballLeageDbcontext : DbContext
    {
        //public FootballLeageDbcontext(DbContextOptions<FootballLeageDbcontext>options):base(options)
        //{

        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=Emad;Initial Catalog=FootballLeague;Integrated Security=True;Encrypt=True;Trust Server Certificate=True")
                //.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking)
                .LogTo(Console.WriteLine, LogLevel.Information)
                .EnableDetailedErrors()
                .EnableSensitiveDataLogging();
        }
        public DbSet<Team> Teams { get; set; }

        public DbSet<Coach> Coachs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Team>().HasData(new TeamList().Teams);
        }
    }
}