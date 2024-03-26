using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace EntityFrameworkCore.Data
{
    public class FootballLeagueDbcontectFactory : IDesignTimeDbContextFactory<FootballLeageDbcontext>
    {
        public FootballLeageDbcontext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile(@"F:\MyWork\EF Remmber\EntityFrameworkCore\EntityFrameworkCore.WebAPIApp\appsettings.json")
                    .Build();
            var optionBuilder = new DbContextOptionsBuilder<FootballLeageDbcontext>();
            optionBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            return new FootballLeageDbcontext(optionBuilder.Options);
        }
    }
}
