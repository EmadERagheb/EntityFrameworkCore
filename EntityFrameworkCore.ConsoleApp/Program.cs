﻿using EntityFrameworkCore.Data;
using EntityFrameworkCore.Domain;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCore.ConsoleApp
{
    class teamInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public override string ToString() => $"{{Id:{Id}, Name:{Name}}}";

    }
    class TeamDetails
    {
        public int TeamId { get; set; }
        public string TeamName { get; set; }

        public string CoachName {  get; set; }
        public int TotalHomeScore {  get; set; }

        public int TotalAwayScore { get; set; }
        public override string ToString()
        => $"{{TeamId:{TeamId}, TeamName:{TeamName}, CoachName:{CoachName}, TotalAwayScore:{TotalAwayScore}, TotalHomeScore:{TotalHomeScore} }}";
           
        
    }
    internal class Program
    {
        static async Task Main(string[] args)
        {
            using FootballLeageDbcontext context = new FootballLeageDbcontext();
            #region LINQ Queries

            //GetAllTeams(context);
            //var T01 = await context.Teams.FirstOrDefaultAsync();
            //Console.WriteLine(T01.Name);
            //var T02 = await context.Teams.Where(q => EF.Functions.Like(q.Name, "%F.M%")).ToListAsync();
            //foreach (var item in T02)
            //{
            //    Console.WriteLine(item.Name);

            //}
            //var T03 = await context.Teams.MaxAsync(q => q.Id);
            //Console.WriteLine(T03);
            //var T05 = context.Teams.Max(q => q.Id);
            //Console.WriteLine(T05);
            //var T04 = context.Teams.AsEnumerable().MaxBy(t => t.Name);
            //Console.WriteLine(T04.Name);

            //List<teamInfo> Q02 = await context.Teams.Select(q => new teamInfo() { Id = q.Id, Name = q.Name }).ToListAsync();
            //Q02.ForEach(q => Console.WriteLine(q));

            //Coach C01 = new Coach() { Name = "Josea Morinhio", CreatedDate = DateTime.Now };
            //Coach C02 = new Coach() { Name = "Guardiula", CreatedDate = DateTime.Now };
            //List<Coach> coaches = new List<Coach>() { C01, C02 };

            //Console.WriteLine(context.ChangeTracker.DebugView.LongView);
            //await context.Coachs.AddRangeAsync(coaches);
            //Console.WriteLine(context.ChangeTracker.DebugView.LongView);
            //await context.SaveChangesAsync();
            //Console.WriteLine(context.ChangeTracker.DebugView.LongView);

            //  var Q10 = await context.Coachs.AsNoTracking().FirstOrDefaultAsync(q => q.Id == 1);
            //  Console.WriteLine(Q10.Name);
            //  Console.WriteLine(context.ChangeTracker.DebugView.LongView);
            //  context.Coachs.Update(Q10);
            //  Console.WriteLine(context.ChangeTracker.DebugView.LongView);
            //await  context.SaveChangesAsync();
            //  Console.WriteLine(context.ChangeTracker.DebugView.LongView);

            //var Q11= await context.Coachs.Where(q=>q.Id==1).ExecuteDeleteAsync();
            //var Q12 = await context.Coachs.Where(q => q.Id == 2).ExecuteUpdateAsync(set => set.SetProperty(prop => prop.Name , "Emad")); 
            #endregion
            #region Insert Related Data

            //League newLeague = new League()
            //{
            //    Name = "Serie A",
            //    Teams = new List<Team>()
            //    {
            //         new Team()
            //         {
            //            Name="Jueventus",
            //            Coach= new Coach()
            //            {
            //             Name="Juve Coach"
            //            },
            //         }  ,
            //         new Team()
            //         {
            //            Name="AC Milan",
            //            Coach= new Coach()
            //            {
            //             Name="Milan Coach"
            //            },
            //         },
            //        new Team()
            //         {
            //            Name="AS Roma",
            //            Coach= new Coach()
            //            {
            //             Name="Roma Coach"
            //            },
            //         },


            //    }
            //};
            //await context.AddAsync(newLeague);
            // await context.SaveChangesAsync(); 
            #endregion
            #region Eager Loading Data
            //var leagues = await context.Leagues.
            //      Include(l => l.Teams)
            //       .ThenInclude(t => t.Coach)
            //          .ToListAsync();

            //foreach (var league in leagues)
            //{
            //    Console.WriteLine($"League - {league.Name}");
            //    league?.Teams?.ForEach(t => Console.WriteLine($"{t.Name} - {t.Coach.Name} "));
            //}
            #endregion
            #region Explicit Loading Data
            //var league = await context.Leagues.FindAsync(4);
            //if (!league.Teams.Any())
            //{
            //    Console.WriteLine("Teams have not been loaded");
            //}
            //await context.Entry(league).Collection(q=>q.Teams).LoadAsync();
            //if (league.Teams.Any())
            //{

            //    foreach (var team in league.Teams)
            //    {
            //        Console.WriteLine($"{team.Name}");
            //    }
            //}
            #endregion
            #region Lazy Loading

            //foreach (var league in  context.Leagues)
            //{
            //    //Console.WriteLine($"{league.Name}");
            //    foreach (var team in league.Teams)
            //    {

            //        Console.WriteLine(team.Name);
            //    }
            //}
            #endregion
            #region MyRegion
            //await InsertMaches(context);
            //var Teams = await context.Teams.
            //     Include(t=>t.HomeTeamMatches.Where(h=>h.HomeTeamScore>0))
            //     .Include(t=>t.Coach)
            //     .ToListAsync();
            // foreach(var team in Teams)
            // {
            //     Console.WriteLine($"Team Name-{team.Name}\n" +
            //         $" Coach Name-{team.Coach.Name}\n");
            //     foreach(var match in team.HomeTeamMatches)
            //     {
            //         Console.WriteLine($"Home Scores -{match.HomeTeamScore}");
            //     }
            //     Console.WriteLine("******************");

            // } 
            #endregion
            #region Use Projection To Get Data
            //var teams = await context.Teams
            //      .Select(q => new TeamDetails
            //      {
            //          TeamId = q.Id,
            //          TeamName = q.Name,
            //          CoachName = q.Coach.Name,
            //          TotalAwayScore = q.AwayTeamMatches.Sum(x => x.AwayTeamScore),
            //          TotalHomeScore = q.HomeTeamMatches.Sum(x => x.HomeTeamScore)
            //      })
            //      .ToListAsync();
            //teams.ForEach(t => Console.WriteLine(t)); 
            #endregion
            #region Query View
            var TeamLeagueViewData = await context.TeamLeagueView.ToListAsync();
            foreach (var record in TeamLeagueViewData)
            {
                Console.WriteLine(record);
            }
            #endregion

        }




        static async Task InsertMaches(FootballLeageDbcontext context)
        {
            var M01 = new Match()
            {
                AwayTeamId = 2,
                HomeTeamId = 3,
                HomeTeamScore = 1,
                AwayTeamScore = 0,
                Date = new DateTime(2023, 03, 15),
                TicketPrice = 20

            };
            var M02 = new Match()
            {
                AwayTeamId = 2,
                HomeTeamId = 1,
                HomeTeamScore = 1,
                AwayTeamScore = 0,
                Date = new DateTime(2023, 04, 15),
                TicketPrice = 20

            };
            var M03 = new Match()
            {
                AwayTeamId = 1,
                HomeTeamId = 3,
                HomeTeamScore = 1,
                AwayTeamScore = 0,
                Date = new DateTime(2023, 05, 15),
                TicketPrice = 20
            };
            var M04 = new Match()
            {
                AwayTeamId = 4,
                HomeTeamId = 3,
                HomeTeamScore = 0,
                AwayTeamScore = 1,
                Date = new DateTime(2023, 01, 15),
                TicketPrice = 20

            };

           await context.Matchs.AddRangeAsync(M01,M02, M03,M04);
           await context.SaveChangesAsync();

        }


        static void GetAllTeams(FootballLeageDbcontext context)
        {
            var teams = context.Teams.ToList();
            foreach (var item in teams)
            {
                Console.WriteLine(item.Name);
            }
        }
        async static Task Pagination(FootballLeageDbcontext context)
        {
            var recordCount = 3;
            var page = 0;
            var next = true;
            while (next)
            {
                var Q01 = await context.Teams.Skip(page * recordCount).Take(recordCount).ToListAsync();
                foreach (var item in Q01)
                {

                    Console.WriteLine(item.Name);
                }
                Console.WriteLine("enter true for the next set of records or false to end");

                next = Boolean.Parse(Console.ReadLine());
                page++;


            }
        }
    }
}


