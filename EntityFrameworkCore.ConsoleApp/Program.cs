using EntityFrameworkCore.Data;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCore.ConsoleApp
{
    class teamInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public override string ToString() => $"{{Id:{Id}, Name:{Name}}}";

    }
    internal class Program
    {
        static async Task Main(string[] args)
        {
            using FootballLeageDbcontext context = new FootballLeageDbcontext();

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

            var Q11= await context.Coachs.Where(q=>q.Id==1).ExecuteDeleteAsync();









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
