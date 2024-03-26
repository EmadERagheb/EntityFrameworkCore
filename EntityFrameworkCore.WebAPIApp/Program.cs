
using EntityFrameworkCore.Data;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCore.WebAPIApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddDbContext<FootballLeageDbcontext>(option =>
            {
                option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
                  .LogTo(Console.WriteLine, LogLevel.Information)
                  .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
                if (builder.Environment.IsDevelopment())
                {
                    option.EnableDetailedErrors();
                    option.EnableSensitiveDataLogging();
                }


            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
